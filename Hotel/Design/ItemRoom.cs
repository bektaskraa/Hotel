using Hotel.Modules;
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

namespace Hotel.Design
{
    public partial class ItemRoom : UserControl
    {
        public ItemRoom()
        {
            InitializeComponent();
        }

        private void ItemRoom_Load(object sender, EventArgs e)
        {

        }

        public int roomId = 0;

        public void changeTitle(string title)
        {
            label1.Text = title;
        }
        public void changeRoomNumber(string number)
        {
            label2.Text = "Oda Numarası: " + number;
        }
        public void changeTotalPrice(string totalPrice)
        {
            label3.Text = totalPrice + "₺";
        }
        public void changeBedCount(string bedCount)
        {
            label4.Text = "Yatak Sayısı: " + bedCount;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            changeView("roomdetail", roomId);
        }
    }
}
