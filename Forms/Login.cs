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
           personDB = new PersonDataBase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = personDB.GetPerson(textBoxHash.Text);
                Account account = personDB.GetAccount(textBoxHash.Text);
                if (person != null && account != null)
                {
                    person.account = account;
                    account.person = person;
                    person.account = account;
                    KullaniciAnaSayfa anaSayfa = new KullaniciAnaSayfa(person);
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış veya Eksik değer girdiniz");
                }
            }
            catch
            {
                MessageBox.Show("Yanlış veya Eksik değer girdiniz");
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            int personResult = 0;
            int accountResult = 0;
            try
            {
                Person person = new Person()
                {
                    password = textBoxKaydolSifre.Text,
                    username = textBoxKaydolAd.Text,
                    lastname = textBoxLastName.Text,
                    firstname = textBoxFirstName.Text,
                    email = textBoxEmail.Text
                };
                if (person.username != "" && person.password != "")
                {
                    person.Hash = Person.CalculateHash(person.username, person.password);
                    Account account = new Account(person);
                    person.account = account;
                    personResult = personDB.CreatePerson(person);
                    accountResult = personDB.CreateAccount(account);
                }
                else
                {
                    MessageBox.Show("Kayıt alanlarını boş bırakmayınız");
                }
                if (personResult > 0 && accountResult > 0)
                {

                    MessageBox.Show($"Başarılı bir şekilde kaydoldunuz {person.Hash} ");
                    KullaniciAnaSayfa anaSayfa = new KullaniciAnaSayfa(person);
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt işleminiz başarısız");
                }
            }
            catch
            {
                MessageBox.Show("Yanlış veya Eksik değer girdiniz");
            }
        
        }
    }
}
   