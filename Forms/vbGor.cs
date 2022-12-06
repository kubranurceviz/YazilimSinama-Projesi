using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yaz.sın_4
{
    public partial class vbGor : Form
    {

        //***ÖNEMLİ NOT: borç ise -'li sayıları kullanmayı düşündüm!!
        Person person;
        public vbGor(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

        private void vbGor_Load(object sender, EventArgs e)
        {
            txbMevcutCmiktari.Text = person.account.quantityOfCarbon.ToString();
            txbMevcutRCmiktari.Text = person.account.recycleCoin.ToString();
        }
    }
}
