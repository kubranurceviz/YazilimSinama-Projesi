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

        
        Person person;
        public vbGor(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

        private void vbGor_Load(object sender, EventArgs e)
        {
            labelİism.Text = person.ToString();
            txbMevcutRCmiktari.Text = person.account.recycleCoin.ToString();
        }
    }
}
