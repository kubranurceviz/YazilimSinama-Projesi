using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yaz.sın_4.Forms
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            adminGiris.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
