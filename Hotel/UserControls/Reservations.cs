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
    public partial class Reservations : UserControl
    {
        public Reservations()
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            string query = "SELECT m.adi AS MusteriAdi, o.numara AS OdaNumarasi, ot.tipAdi AS OdaTipi, " +
                           "mo.geceSayisi AS KalacagiGun, mo.rezervasyonGunu AS RezervasyonTarihi, DATEDIFF(mo.rezervasyonGunu, CURDATE()) AS BitimineKacGunKaldi " +
                           "FROM musteri_oda mo " +
                           "JOIN musteri m ON mo.musteriId = m.id " +
                           "JOIN oda o ON mo.odaId = o.id " +
                           "JOIN oda_tip ot ON o.tipId = ot.id " +
                           "WHERE (mo.rezervasyonGunu >= CURDATE() OR DATEDIFF(mo.rezervasyonGunu, CURDATE()) + mo.geceSayisi > 0)";

            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string musteriAdi = reader.GetString("MusteriAdi");
                string odaNumarasi = reader.GetString("OdaNumarasi");
                //double fiyat = reader.GetDouble("fiyat");
                double fiyat = 0;
                string odaTipi = reader.GetString("OdaTipi");
                int kalacagiGun = reader.GetInt32("KalacagiGun");
                int bitimineKacGunKaldi = reader.GetInt32("BitimineKacGunKaldi");
                DateTime rezervasyonTarihi = reader.GetDateTime("RezervasyonTarihi");

                Design.ItemReservation reservation = new Design.ItemReservation();
                reservation.setCustomerName(musteriAdi);
                reservation.setRoom(odaNumarasi, odaTipi);
                reservation.setDay(kalacagiGun, bitimineKacGunKaldi, rezervasyonTarihi);
                reservation.setPrice(fiyat);

                // Diğer verileri kullanarak gerekli işlemleri yapabilirsiniz
                flowLayoutPanel1.Controls.Add(reservation);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
