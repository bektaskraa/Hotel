using Hotel.Design;
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
    public partial class Customers : UserControl
    {
        public Customers()
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

        private void Customers_Load(object sender, EventArgs e)
        {
            string query = "SELECT adi, TC, telefon, mail FROM musteri";

            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString("adi");
                string tc = reader.GetString("TC");
                string telefon = reader.GetString("telefon");
                string mail = reader.GetString("mail");


                Design.ItemCustomer customer = new Design.ItemCustomer();
                customer.setName(name);
                customer.setTC(tc);
                customer.setMail(mail);
                customer.setPhone(telefon);

                // Diğer verileri kullanarak gerekli işlemleri yapabilirsiniz
                flowLayoutPanel1.Controls.Add(customer);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
