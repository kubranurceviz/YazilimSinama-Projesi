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
        Account a;
        Person _sender;
        Person reciever;
        public tIslem()
        {
            a = new Account(_sender);
            _sender = new Person();
            reciever = new Person();
            InitializeComponent();
        }

        private void lbltransferRCmiktar_Click(object sender, EventArgs e)
        {

        }

        private void tIslem_Load(object sender, EventArgs e)
        {

        }

        private void txbTransferSHA_TextChanged(object sender, EventArgs e)
        {
            reciever.hash= txbTransferSHA.Text;
        }

        private void txbTransferRCAmount_TextChanged(object sender, EventArgs e)
        {


           
        }

        private void btnTransferEt_Click(object sender, EventArgs e)
        {

            //Account a = new Account(_sender);//kurucu

            _sender.account = a; //loginde kullanılacak
            a.transfer(reciever, Convert.ToDouble(txbTransferRCAmount.Text));
        }
    }

}
