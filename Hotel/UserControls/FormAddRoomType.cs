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
    public partial class FormAddRoomType : UserControl
    {
        public FormAddRoomType()
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
            string title = textBoxBaslik.Text;
            int bedCount;
            double price;

            if (string.IsNullOrWhiteSpace(title) || !int.TryParse(textBoxYatakSayisi.Text, out bedCount) || !double.TryParse(textBoxFiyat.Text, out price))
            {
                MessageBox.Show("Lütfen geçerli değerler girin.");
                return; // Geçersiz değerler var, işlemi sonlandır
            }

            // Aynı isimde bir kayıt var mı diye kontrol et
            string checkQuery = "SELECT COUNT(*) FROM oda_tip WHERE tipAdi = @tipAdi";
            using MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("@tipAdi", title);

            int existingRecordCount = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (existingRecordCount > 0)
            {
                // Aynı isimde bir kayıt zaten var, uyarı ver
                MessageBox.Show("Bu isimde bir oda tipi zaten mevcut.");
            }
            else
            {
                // "oda_tip" tablosuna veri eklemek için INSERT sorgusu oluşturun
                string insertQuery = "INSERT INTO oda_tip (tipAdi, yatakSayisi, fiyat) VALUES (@tipAdi, @yatakSayisi, @fiyat)";

                // Sorgu için MySqlCommand oluşturun ve parametreleri ayarlayın
                using MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@tipAdi", title);
                insertCommand.Parameters.AddWithValue("@yatakSayisi", bedCount);
                insertCommand.Parameters.AddWithValue("@fiyat", price);

                // Sorguyu çalıştırın
                int rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Başarıyla eklendi
                    MessageBox.Show("Oda tipi başarıyla eklendi.");
                }
                else
                {
                    // Ekleme başarısız oldu
                    MessageBox.Show("Oda tipi eklenirken bir hata oluştu.");
                }
            }
        }
    }
}
