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
            personDb = new PersonDataBase();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            int adet = 0;
            try
            {
                adet = int.Parse(txtBoxAdet.Text);
                if (adet > 0)
                {
                    recycleObject.quantityOfRecycleObject = adet;
                    double result = recycleObject.conversionFromCtoRC(recycleObject);
                    lblGeriDonusecekCoin.Text = result.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal değer giriniz!");
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
            if (recycleObject != null)
            {
              
                int adet = 0;
                try
                {
                    adet = int.Parse(txtBoxAdet.Text);
                    if (adet > 0)
                    {
                        int result = recycleObject.carbonAmount * adet;
                        lblCarbonMiktar.Text = result.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen sayısal değer giriniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen dönüştürelecek nesneyi giriniz");
            }
        }

        private void btnGetPerson_Click(object sender, EventArgs e)
        {
            string hashKullanici = textBoxHash.Text;
            if (hashKullanici != "")
            {
                person = personDb.GetPerson(hashKullanici);
                account = personDb.GetAccount(hashKullanici);
                if (person != null && account != null)
                {
                    person.account = account;
                    account.person = person;
                }
                else
                {
                    MessageBox.Show("Yanlış Hash Kodu girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("HASH kODUNU GİRİNİZ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnHesabaAktar_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (account != null)
            {
                try
                {
                    account.recycleCoin = Convert.ToDouble(lblGeriDonusecekCoin.Text);
                    result = personDb.Update(account);
                }
                catch
                {
                    MessageBox.Show("Lütfen atıkları dönüştürün!");
                }

              
            }
            else
            {
                MessageBox.Show("Lütfen aktarılacak hesabı giriniz!");
            }
            if(result > 0)
            {
                MessageBox.Show("Hesaba aktarım başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            textBoxHash.Text = "";
            txtBoxAdet.Text = "";
            lblAtikNesneOzellik.Text = "";
            recycleObject = null;
        }
    }
}
