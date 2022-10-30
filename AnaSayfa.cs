using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yaz.sın_4
{
    public partial class KullaniciAnaSayfa : Form
    {
        public KullaniciAnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void transferİişlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void varlılarVeBorçlarıGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
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
            vbGor vb = new vbGor();
            FormGetir(vb, KullaniciAnaSyfPanel);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFormTIslem_Click(object sender, EventArgs e)
        {
            tIslem tIs = new tIslem();
            FormGetir(tIs, KullaniciAnaSyfPanel);
        }
    }
}
