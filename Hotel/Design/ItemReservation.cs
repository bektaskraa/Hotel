using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Design
{
    public partial class ItemReservation : UserControl
    {
        public ItemReservation()
        {
            InitializeComponent();
        }

        private void ItemReservation_Load(object sender, EventArgs e)
        {

        }

        public void setCustomerName(string value)
        {
            labelMusteriAdi.Text = value;
        }
        public void setRoom(string number, string roomType)
        {
            labelOdaBilgileri.Text = number + " - " + roomType;
        }
        public void setDay(int value, int value2, DateTime date)
        {
            if (value2 >= value)
            {
                labelKalanGun.Text = "Başlamasına: " + value2.ToString() + " gün kaldı - " + date.ToString("dd/MM/yyyy");
            }
            else
            {
                labelKalanGun.Text = "Bitimine: " + value.ToString() + " gün kaldı";
            }
        }

        public void setPrice(double value)
        {
            labelFiyat.Text = value.ToString() + "₺";
        }
    }
}
