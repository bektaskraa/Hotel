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

            string selectedRoomText = comboBox1.SelectedItem.ToString();
            int selectedRoomId = 0;

            // Seçilen oda ID'sini çıkarın
            int startIndex = selectedRoomText.IndexOf('[') + 1;
            int endIndex = selectedRoomText.IndexOf(',');
            if (startIndex > 0 && endIndex > 0)
            {
                string roomIdStr = selectedRoomText.Substring(startIndex, endIndex - startIndex);
                if (int.TryParse(roomIdStr, out selectedRoomId))
                {
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

                    // Müşterinin aynı tarih aralığında aynı oda için rezervasyonu var mı diye kontrol et
                    if (HasExistingReservationWithinDateRange(customerId, Date, NightCount, selectedRoomId))
                    {
                        MessageBox.Show("Bu odanın belirlediğiniz tarihler arasında rezervasyonu bulunuyor.");
                        return; // işlemi sonlandır
                    }

                    // Rezervasyonun fiyatını hesaplayın
                    decimal price = CalculateReservationPrice(selectedRoomId, NightCount);

                    // "musteri_oda" tablosuna rezervasyon eklemek için sorgu oluşturun
                    string insertReservationQuery = "INSERT INTO musteri_oda (musteriId, odaId, geceSayisi, fiyat, rezervasyonGunu) VALUES (@musteriId, @odaId, @geceSayisi, @fiyat, @rezervasyonGunu)";
                    using MySqlCommand insertReservationCommand = new MySqlCommand(insertReservationQuery, connection);
                    insertReservationCommand.Parameters.AddWithValue("@musteriId", customerId);
                    insertReservationCommand.Parameters.AddWithValue("@odaId", selectedRoomId);
                    insertReservationCommand.Parameters.AddWithValue("@geceSayisi", NightCount);
                    insertReservationCommand.Parameters.AddWithValue("@fiyat", price);
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
                else
                {
                    // ID dönüştürme hatası
                    MessageBox.Show("Oda ID'si alınamadı.");
                    return;
                }
            }
            else
            {
                // Seçilen oda bilgileri hatalı
                MessageBox.Show("Oda bilgileri alınamadı.");
                return;
            }
        }

        private decimal CalculateReservationPrice(int roomId, int nightCount)
        {
            // İlk adımda ilgili oda kaydını bulalım
            string roomQuery = "SELECT tipId FROM oda WHERE id = @roomId";
            using MySqlCommand roomCommand = new MySqlCommand(roomQuery, connection);
            roomCommand.Parameters.AddWithValue("@roomId", roomId);

            int tipId = Convert.ToInt32(roomCommand.ExecuteScalar());

            if (tipId > 0)
            {
                // Ardından, tipId ile "oda_tip" tablosundan fiyatı alalım
                string priceQuery = "SELECT fiyat FROM oda_tip WHERE id = @tipId";
                using MySqlCommand priceCommand = new MySqlCommand(priceQuery, connection);
                priceCommand.Parameters.AddWithValue("@tipId", tipId);

                decimal roomPrice = Convert.ToDecimal(priceCommand.ExecuteScalar());

                // Toplam fiyatı hesaplayalım
                decimal totalPrice = nightCount * roomPrice;

                return totalPrice;
            }
            else
            {
                return 0; // Geçersiz oda veya tipId
            }
        }










        private bool HasExistingReservation(int selectedRoomId, DateTime startDate, int nightCount)
        {
            // Aynı odanın ve tarih aralığının başka bir rezervasyonu var mı diye kontrol et
            string query = "SELECT COUNT(*) FROM musteri_oda " +
                           "WHERE odaId = @odaId AND " +
                           "((rezervasyonGunu >= @startDate AND rezervasyonGunu < DATE_ADD(@startDate, INTERVAL @nightCount DAY)) " +
                           "OR (DATE_ADD(rezervasyonGunu, INTERVAL geceSayisi DAY) > @startDate AND DATE_ADD(rezervasyonGunu, INTERVAL geceSayisi DAY) <= DATE_ADD(@startDate, INTERVAL @nightCount DAY)))";

            using MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@odaId", selectedRoomId);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@nightCount", nightCount);

            int reservationCount = Convert.ToInt32(command.ExecuteScalar());
            return reservationCount > 0;
        }

        private bool HasExistingReservationWithinDateRange(int customerId, DateTime startDate, int nightCount, int roomId)
        {
            // Müşterinin aynı tarih aralığında başka bir rezervasyonu olup olmadığını kontrol edin
            string query = "SELECT COUNT(*) FROM musteri_oda " +
                           "WHERE musteriId = @musteriId AND " +
                           "odaId = @odaId AND " +
                           "((rezervasyonGunu >= @startDate AND rezervasyonGunu < DATE_ADD(@startDate, INTERVAL @nightCount DAY)) " +
                           "OR (DATE_ADD(rezervasyonGunu, INTERVAL geceSayisi DAY) > @startDate AND DATE_ADD(rezervasyonGunu, INTERVAL geceSayisi DAY) <= DATE_ADD(@startDate, INTERVAL @nightCount DAY)))";

            using MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@musteriId", customerId);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@nightCount", nightCount);
            command.Parameters.AddWithValue("@odaId", roomId);

            int reservationCount = Convert.ToInt32(command.ExecuteScalar());
            return reservationCount > 0;
        }




        private int GetCustomerIdByTC(string tc)
        {
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

        private decimal CalculatePrice(int nightCount, int roomId)
        {
            // Oda fiyatlarını veritabanından alın
            string query = "SELECT fiyat FROM oda WHERE id = @odaId";
            using MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@odaId", roomId);
            decimal roomPrice = Convert.ToDecimal(command.ExecuteScalar());

            // Toplam fiyatı hesaplayın
            decimal totalPrice = nightCount * roomPrice;

            return totalPrice;
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

            string searchCustomerQuery = "SELECT * FROM musteri WHERE TC = @TC";
            using MySqlCommand searchCustomerCommand = new MySqlCommand(searchCustomerQuery, connection);
            searchCustomerCommand.Parameters.AddWithValue("@TC", searchTC);

            using MySqlDataReader customerReader = searchCustomerCommand.ExecuteReader();

            if (customerReader.Read())
            {
                DialogResult result = MessageBox.Show("Müşteri bulundu. Bilgileri doldurmak istiyor musunuz?", "Müşteri Bulundu", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    textBoxTC.Text = customerReader.GetString("TC");
                    textBoxAdSoyad.Text = customerReader.GetString("adi");
                    textBoxTelefon.Text = customerReader.GetString("telefon");
                    textBoxEmail.Text = customerReader.GetString("mail");
                }
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.");
            }
        }

        private void groupBox11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            // Odaları veritabanından çekin
            string query = "SELECT oda.id AS OdaID, oda.numara AS OdaNumarasi, oda_tip.tipAdi AS OdaTipi FROM oda " +
                           "INNER JOIN oda_tip ON oda.tipId = oda_tip.id";

            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader roomReader = command.ExecuteReader();

            // ComboBox'a odaları ekleyin
            while (roomReader.Read())
            {
                int roomId = roomReader.GetInt32("OdaID");
                string roomNumber = roomReader.GetString("OdaNumarasi");
                string roomType = roomReader.GetString("OdaTipi");

                string displayText = string.Format("[{0},{1},{2}]", roomId, roomNumber, roomType);
                comboBox1.Items.Add(displayText);
            }
        }
    }
}
