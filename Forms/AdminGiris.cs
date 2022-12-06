using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yaz.sın_4.Forms
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string ad = "Admin";
            string sifre = "1234";
            if(textBoxAd.Text == ad.ToLower() && textBoxSifre.Text == sifre )
            {
                OperatorAtikKaydi operatorAtikKaydi = new OperatorAtikKaydi();
                operatorAtikKaydi.Show();
                this.Show();
            }
        }
    }
}
