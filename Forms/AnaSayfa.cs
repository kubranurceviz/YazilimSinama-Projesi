using System;
using System.Windows.Forms;

namespace yaz.sın_4
{
    public partial class KullaniciAnaSayfa : Form
    {
        Person person;
        public KullaniciAnaSayfa(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

         void FormGetir(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);
            form.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            vbGor vb = new vbGor(person);
            FormGetir(vb, KullaniciAnaSyfPanel);
        }


        private void btnFormTIslem_Click(object sender, EventArgs e)
        {
            tIslem tIs = new tIslem(person);
            FormGetir(tIs, KullaniciAnaSyfPanel);
        }
    }
}
