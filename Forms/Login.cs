using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yaz.sın_4
{
    public partial class Login : Form
    {
        PersonDataBase personDB;
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Person person = personDB.GetPerson(textBoxHash.Text);
            
            person.account = personDB.GetAccount(textBoxHash.Text);
            KullaniciAnaSayfa anaSayfa = new KullaniciAnaSayfa(person);

            anaSayfa.Show();
            this.Hide();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            int personResult = 0;
            int accountResult = 0;
            Person person = new Person()
            {
                password = textBoxKaydolSifre.Text,
                username = textBoxKaydolAd.Text
            };
            Account account = new Account(person);
            person.account = account;
            personResult=personDB.CreatePerson(person);
            accountResult=personDB.CreateAccount(account);
            if( personResult > 0 && accountResult > 0)
            {
                KullaniciAnaSayfa anaSayfa = new KullaniciAnaSayfa(person);
            }
        }
    }
}
