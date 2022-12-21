using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yaz.sın_4
{
    public partial class OperatorAtikKaydi : Form
    {
        RecycleObjectDataBase recycleDb = new RecycleObjectDataBase();
        List<RecycleObject> recycleObjects;
        RecycleObject recycleObject;
        PersonDataBase personDb;
        Person person;
        Account account;

        public OperatorAtikKaydi()
        {
            InitializeComponent();
            recycleObjects = recycleDb.GetAllRecycleObject();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(txtBoxAdet.Text);
            if (adet < 0){
                double result = recycleObject.conversionFromCtoRC(recycleObject) * adet;
                lblGeriDonusecekCoin.Text = result.ToString();
            }
        }

        private void OperatorAtikKaydi_Load(object sender, EventArgs e)
        {
            foreach(RecycleObject recycle in recycleObjects) {

                comboBoxAtikNesne.Items.Add(recycle);
            }
        }

        private void comboBoxAtikNesne_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecycleObject r = (RecycleObject) comboBoxAtikNesne.SelectedItem;
            recycleObject = recycleDb.GetRecycleObjectById(r.ID);
            lblAtikNesneOzellik.Text = recycleObject.ToString();
        }

        private void txtBoxAdet_TextChanged(object sender, EventArgs e)
        {
            lblCarbonMiktar.Text = recycleObject.carbonAmount.ToString();
        }

        private void btnGetPerson_Click(object sender, EventArgs e)
        {
            string hashKullanici = textBoxHash.Text;
            if (hashKullanici != "")
            {
                person = personDb.GetPerson(hashKullanici);
                account = personDb.GetAccount(hashKullanici);

                person.account = account;
                account.person = person;
                   
            }
            else
            {
                MessageBox.Show("HASH kODUNU GİRİNİZ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnHesabaAktar_Click(object sender, EventArgs e)
        {
            account.recycleCoin = Convert.ToDouble(lblGeriDonusecekCoin.Text);
             int result= personDb.Update(account);
            if(result > 0)
            {
                MessageBox.Show("Hesaba aktarım başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
