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
    public partial class ItemCustomer : UserControl
    {
        public ItemCustomer()
        {
            InitializeComponent();
        }

        private void ItemCustomer_Load(object sender, EventArgs e)
        {

        }

        public void setName(string value)
        {
            labelMusteriAdi.Text = value;
        }
        public void setPhone(string value)
        {
            labelTelefon.Text = value;
        }
        public void setTC(string value)
        {
            labelTC.Text = value;
        }
        public void setMail(string value)
        {
            labelEmail.Text = value;
        }
    }
}
