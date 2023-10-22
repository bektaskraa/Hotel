using Hotel.Modules;
using MySql.Data.MySqlClient;
using static Hotel.Modules.FormController;

namespace Hotel
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            contentPanel_ = contentPanel;
            InitializeConnection();
        }




        private void InitializeConnection()
        {
            string connectionString = "server=localhost;user=root;password=;database=sistemtest;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeView("main");

            button2.BackColor = Color.Gray;

            button1.BackColor = Color.FromArgb(0, 169, 255);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeView("main");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeView("rooms");

            button1.BackColor = Color.Gray;

            button2.BackColor = Color.FromArgb(0, 169, 255);
        }


    }
}
