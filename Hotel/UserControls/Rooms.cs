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
    public partial class Rooms : UserControl
    {
        private MySqlConnection connection;

        public Rooms()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            string connectionString = "server=localhost;user=root;password=;database=hotel;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            string query = "SELECT o.*, ot.tipAdi, ot.yatakSayisi, ot.fiyat " +
               "FROM oda o " +
               "INNER JOIN oda_tip ot ON o.tipId = ot.id";

            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string roomNo = reader.GetString(1);
                int roomType = reader.GetInt32(2);
                string roomTitle = reader.GetString(4); // "oda_tip" tablosundan gelen "tipAdi" değeri
                int yatakSayisi = reader.GetInt32(5); // "oda_tip" tablosundan gelen "yatakSayisi" değeri
                decimal fiyat = reader.GetDecimal(6); // "oda_tip" tablosundan gelen "fiyat" değeri
                string roomStatus = reader.GetString(3);

                Design.ItemRoom room = new Design.ItemRoom();
                room.roomId = reader.GetInt32(0);
                room.changeTitle(roomTitle);
                room.changeRoomNumber(roomNo);
                room.changeBedCount(yatakSayisi.ToString());
                room.changeTotalPrice(fiyat.ToString());
                // Diğer verileri kullanarak gerekli işlemleri yapabilirsiniz
                flowLayoutPanel1.Controls.Add(room);
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeView("add_room");
        }
    }
}
