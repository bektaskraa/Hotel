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
    public partial class RoomDetail : UserControl
    {
        
        public RoomDetail()
        {
            InitializeConnection();
            InitializeComponent();
        }

        private MySqlConnection connection;
        private void InitializeConnection()
        {
            string connectionString = "server=localhost;user=root;password=;database=hotel;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public int roomId = 0;

        private void RoomDetail_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT o.*, ot.tipAdi, ot.yatakSayisi, ot.fiyat, mo.geceSayisi, mo.fiyat AS musteriOdaFiyati, m.adi AS musteriAdi, mo.rezervasyonGunu " +
                "FROM oda o " +
                "INNER JOIN oda_tip ot ON o.tipId = ot.id " +
                "LEFT JOIN musteri_oda mo ON o.id = mo.odaId " +
                "LEFT JOIN musteri m ON mo.musteriId = m.id " +
                "WHERE o.id = " + roomId;

            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                textBoxOdaNo.Text = reader.GetString("numara");
                labelTitle.Text = reader.GetString("tipAdi");
                textBoxGecelikFiyat.Text = reader.GetString("fiyat");

                if (!reader.IsDBNull("geceSayisi"))
                {
                    int geceSayisi = reader.GetInt32("geceSayisi");
                    decimal musteriOdaFiyati = reader.GetDecimal("musteriOdaFiyati");
                    string musteriAdi = reader.GetString("musteriAdi");


                    textBoxMusteriAdi.Text = musteriAdi;
                    textBoxGeceSayisi.Text = geceSayisi.ToString();
                    textBoxToplamOdeme.Text = musteriOdaFiyati.ToString();


                    DateTime rezervasyonGunu = reader.GetDateTime("rezervasyonGunu");
                    DateTime bugun = DateTime.Now;
                    int gecenGunSayisi = (bugun - rezervasyonGunu).Days;
                    int kalanGunSayisi = geceSayisi - gecenGunSayisi;

                    labelRezarvasyonGunuDegeri.Text = rezervasyonGunu.ToString("dd/MM/yyyy");
                    labelKalanGunDegeri.Text = kalanGunSayisi.ToString() + " gün";

                }
            }



        }
    }
}

