using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace yaz.sın_4
{
    public partial class tIslem : Form
    {
        Person person;
        PersonDataBase personDB;
        public tIslem(Person person)
        {
            InitializeComponent();
            this.person = person;
            personDB = new PersonDataBase();
        }

        private void btnTransferEt_Click(object sender, EventArgs e)
        {
            int senderResult = 0;
            int receiverResult = 0;
            Person receiver = personDB.GetPerson(txbTransferSHA.Text);
            Account account = personDB.GetAccount(txbTransferSHA.Text);
           
            if(receiver != null) {
                try
                {
                    receiver.account = account;
                    account.person = receiver;
                    if (account.recycleCoin > double.Parse(txbTransferRCAmount.Text))
                    {
                        person.account.transfer(receiver, double.Parse(txbTransferRCAmount.Text));
                        senderResult = personDB.Update(person.account);
                        receiverResult = personDB.Update(receiver.account);
                    }
                    else
                    {
                        MessageBox.Show("Hesabınızda yeterli bakiye yok!");
                    }
                }
                catch 
                {
                    MessageBox.Show("LÜTFEN TRANSFER DEĞERİNİ DOĞRU GİRİNİZ!");
                }
         
            }
            else
            {
                MessageBox.Show("Alıcı Bulunamadı");
            }
           
            if (receiverResult > 0 && senderResult > 0)
            {
                MessageBox.Show("Transfer İşlemi Başarılı");
            }
        }
    }

}
