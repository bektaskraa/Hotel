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
using static Hotel.Modules.FormController;
namespace Hotel.UserControls
{
    public partial class FormAddRoom : UserControl
    {
        public FormAddRoom()
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


        private void FormAddRoom_Load(object sender, EventArgs e)
        {

            // Oda tiplerini veritabanından çekin
            string query = "SELECT id, tipAdi FROM oda_tip";
            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader reader = command.ExecuteReader();

            // ComboBox'a oda tiplerini ekleyin
            while (reader.Read())
            {
                int typeId = reader.GetInt32("id");
                string typeName = reader.GetString("tipAdi");
                comboBox1.Items.Add(new KeyValuePair<int, string>(typeId, typeName));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is KeyValuePair<int, string> selectedType)
            {
                int selectedTypeId = selectedType.Key;
                string roomNumber = textBoxOdaNumarasi.Text;

                // Aynı numaraya sahip oda var mı diye kontrol et
                string checkQuery = "SELECT COUNT(*) FROM oda WHERE numara = @numara";
                using MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@numara", roomNumber);

                int existingRoomCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingRoomCount > 0)
                {
                    // Aynı numaraya sahip oda zaten var, uyarı ver
                    MessageBox.Show("Bu numaraya sahip bir oda zaten mevcut.");
                }
                else
                {
                    // "oda" tablosuna veri eklemek için INSERT sorgusu oluşturun
                    string insertQuery = "INSERT INTO oda (numara, tipId) VALUES (@numara, @tipId)";

                    // Sorgu için MySqlCommand oluşturun ve parametreleri ayarlayın
                    using MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@numara", roomNumber);
                    insertCommand.Parameters.AddWithValue("@tipId", selectedTypeId);

                    // Sorguyu çalıştırın
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Başarıyla eklendi
                        MessageBox.Show("Oda başarıyla eklendi.");
                    }
                    else
                    {
                        // Ekleme başarısız oldu
                        MessageBox.Show("Oda eklenirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                // Bir oda tipi seçilmedi, bir hata mesajı gösterebilirsiniz.
                MessageBox.Show("Lütfen bir oda tipi seçin.");
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changeView("add_room_type");
        }
    }
}
