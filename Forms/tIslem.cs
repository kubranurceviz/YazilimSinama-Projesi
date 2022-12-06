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
            this.person = person;
            InitializeComponent();
        }

        private void btnTransferEt_Click(object sender, EventArgs e)
        {
            int senderResult = 0;
            int receiverResult = 0;
            Person receiver = personDB.GetPerson(txbTransferSHA.Text);
            Account account = personDB.GetAccount(txbTransferSHA.Text);
            receiver.account = account;
            person.account.transfer(receiver, double.Parse(txbTransferRCAmount.Text));
            senderResult=personDB.Update(person.account);
            receiverResult=personDB.Update(receiver.account);
            if (receiverResult > 0 && senderResult > 0)
            {
                MessageBox.Show("Transfer İşlemi Başarılı");
            }
        }
    }

}
