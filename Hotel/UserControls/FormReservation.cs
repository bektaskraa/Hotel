using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UserControls
{
    public partial class FormReservation : UserControl
    {
        public FormReservation()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private MySqlConnection connection;
        private void InitializeConnection()
        {
            string connectionString = "server=localhost;user=root;password=;database=hotel;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TC = textBoxTC.Text;
            string Name = textBoxAdSoyad.Text;
            string Phone = textBoxTelefon.Text;
            string Email = textBoxEmail.Text;
            int NightCount = Int32.Parse(textBoxGeceSayisi.Text);
            DateTime Date = dateTimePicker1.Value;

            int selectedRoomId = 0; // Seçilen oda ID'sini burada ayarlayın

            // Eski rezervasyonun tarihi kontrolü
            if (Date < DateTime.Now)
            {
                MessageBox.Show("Rezervasyon tarihi geçmiş bir tarih olamaz.");
                return; // işlemi sonlandır
            }

            int customerId = GetCustomerIdByTC(TC);

            if (customerId == 0)
            {
                // Müşteri yoksa yeni müşteri ekleyin
                customerId = AddNewCustomer(Name, TC, Phone, Email);

                if (customerId == 0)
                {
                    // Müşteri eklemesi başarısız oldu
                    MessageBox.Show("Müşteri eklenirken bir hata oluştu.");
                    return; // işlemi sonlandır
                }
            }

            // Müşterinin, belirlediği tarih aralığında başka bir rezervasyonu olup olmadığını kontrol edin
            if (HasExistingReservation(customerId, Date, NightCount))
            {
                MessageBox.Show("Müşterinin belirlediği tarihler arasında başka bir rezervasyonu bulunuyor.");
                return; // işlemi sonlandır
            }

            // "musteri_oda" tablosuna rezervasyon eklemek için sorgu oluşturun
            string insertReservationQuery = "INSERT INTO musteri_oda (musteriId, odaId, geceSayisi, rezervasyonGunu) VALUES (@musteriId, @odaId, @geceSayisi, @rezervasyonGunu)";
            using MySqlCommand insertReservationCommand = new MySqlCommand(insertReservationQuery, connection);
            insertReservationCommand.Parameters.AddWithValue("@musteriId", customerId);
            insertReservationCommand.Parameters.AddWithValue("@odaId", selectedRoomId); // Seçilen oda ID'si
            insertReservationCommand.Parameters.AddWithValue("@geceSayisi", NightCount);
            insertReservationCommand.Parameters.AddWithValue("@rezervasyonGunu", Date);

            int rowsAffectedReservation = insertReservationCommand.ExecuteNonQuery();

            if (rowsAffectedReservation > 0)
            {
                // Başarıyla eklendi
                MessageBox.Show("Rezervasyon başarıyla eklendi.");
            }
            else
            {
                // Ekleme başarısız oldu
                MessageBox.Show("Rezervasyon eklenirken bir hata oluştu.");
            }
        }

        private bool HasExistingReservation(int customerId, DateTime startDate, int nightCount)
        {
            // Müşterinin belirlediği tarihler arasında başka bir rezervasyonu olup olmadığını kontrol edin
            string query = "SELECT COUNT(*) FROM musteri_oda " +
                           "WHERE musteriId = @musteriId AND " +
                           "((rezervasyonGunu >= @startDate AND rezervasyonGunu < DATE_ADD(@startDate, INTERVAL @nightCount DAY)) " +
                           "OR (DATE_ADD(rezervasyonGunu, INTERVAL geceSayisi DAY) > @startDate AND DATE_ADD(rezervasyonGunu, INTERVAL geceSayisi DAY) <= DATE_ADD(@startDate, INTERVAL @nightCount DAY)))";
            using MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@musteriId", customerId);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@nightCount", nightCount);

            int reservationCount = Convert.ToInt32(command.ExecuteScalar());
            return reservationCount > 0;
        }



        private int GetCustomerIdByTC(string tc)
        {
            // TC'ye sahip müşterinin ID'sini veritabanından sorgulayın
            // Eğer müşteri yoksa 0 döndürün, aksi takdirde müşteri ID'sini döndürün
            // Bu kısmı veritabanı yapısına göre uyarlamalısınız
            // Örnek bir sorgu:
            string query = "SELECT id FROM musteri WHERE TC = @TC";
            using MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@TC", tc);
            object result = command.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }

        private int AddNewCustomer(string name, string tc, string phone, string email)
        {
            // Yeni müşteriyi veritabanına ekleyin
            string insertCustomerQuery = "INSERT INTO musteri (adi, TC, telefon, mail) VALUES (@adi, @TC, @telefon, @mail)";
            using MySqlCommand insertCustomerCommand = new MySqlCommand(insertCustomerQuery, connection);
            insertCustomerCommand.Parameters.AddWithValue("@adi", name);
            insertCustomerCommand.Parameters.AddWithValue("@TC", tc);
            insertCustomerCommand.Parameters.AddWithValue("@telefon", phone);
            insertCustomerCommand.Parameters.AddWithValue("@mail", email);

            int rowsAffectedCustomer = insertCustomerCommand.ExecuteNonQuery();
            if (rowsAffectedCustomer > 0)
            {
                return Convert.ToInt32(insertCustomerCommand.LastInsertedId);
            }
            return 0;
        }







        private void button2_Click(object sender, EventArgs e)
        {
            string searchTC = textBoxSearchTC.Text;

            // Müşteriyi aramak için bir sorgu oluşturun
            string searchCustomerQuery = "SELECT * FROM musteri WHERE TC = @TC";
            using MySqlCommand searchCustomerCommand = new MySqlCommand(searchCustomerQuery, connection);
            searchCustomerCommand.Parameters.AddWithValue("@TC", searchTC);

            // Sorguyu çalıştırın ve sonucu bir SqlDataReader'da saklayın
            using MySqlDataReader customerReader = searchCustomerCommand.ExecuteReader();

            if (customerReader.Read())
            {
                // Müşteri bulundu, kullanıcıya onu kullanmak isteyip istemediğini sorsun
                DialogResult result = MessageBox.Show("Müşteri bulundu. Bilgileri doldurmak istiyor musunuz?", "Müşteri Bulundu", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Müşteri bilgilerini TextBox'lara yaz
                    textBoxTC.Text = customerReader.GetString("TC");
                    textBoxAdSoyad.Text = customerReader.GetString("adi");
                    textBoxTelefon.Text = customerReader.GetString("telefon");
                    textBoxEmail.Text = customerReader.GetString("mail");
                }
            }
            else
            {
                // Müşteri bulunamadı, hata mesajı göster
                MessageBox.Show("Müşteri bulunamadı.");
            }
        }

    }
}
