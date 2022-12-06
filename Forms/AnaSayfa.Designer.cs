
namespace yaz.sın_4
{
    partial class KullaniciAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFormVbGor = new System.Windows.Forms.Button();
            this.btnFormTIslem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.KullaniciAnaSyfPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormVbGor
            // 
            this.btnFormVbGor.Location = new System.Drawing.Point(0, 40);
            this.btnFormVbGor.Name = "btnFormVbGor";
            this.btnFormVbGor.Size = new System.Drawing.Size(259, 37);
            this.btnFormVbGor.TabIndex = 3;
            this.btnFormVbGor.Text = "Varlılar ve Borçları Görüntüleme";
            this.btnFormVbGor.UseVisualStyleBackColor = true;
            this.btnFormVbGor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFormTIslem
            // 
            this.btnFormTIslem.Location = new System.Drawing.Point(255, 40);
            this.btnFormTIslem.Name = "btnFormTIslem";
            this.btnFormTIslem.Size = new System.Drawing.Size(259, 37);
            this.btnFormTIslem.TabIndex = 4;
            this.btnFormTIslem.Text = "Transfer İşlemleri";
            this.btnFormTIslem.UseVisualStyleBackColor = true;
            this.btnFormTIslem.Click += new System.EventHandler(this.btnFormTIslem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIslemler);
            this.panel1.Controls.Add(this.btnFormTIslem);
            this.panel1.Controls.Add(this.btnFormVbGor);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 75);
            this.panel1.TabIndex = 5;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.ForeColor = System.Drawing.Color.Black;
            this.lblIslemler.Location = new System.Drawing.Point(19, 17);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(61, 20);
            this.lblIslemler.TabIndex = 6;
            this.lblIslemler.Text = "İşlemler";
            // 
            // KullaniciAnaSyfPanel
            // 
            this.KullaniciAnaSyfPanel.BackColor = System.Drawing.SystemColors.Control;
            this.KullaniciAnaSyfPanel.Location = new System.Drawing.Point(3, 75);
            this.KullaniciAnaSyfPanel.Name = "KullaniciAnaSyfPanel";
            this.KullaniciAnaSyfPanel.Size = new System.Drawing.Size(515, 372);
            this.KullaniciAnaSyfPanel.TabIndex = 6;

            // 
            // KullaniciAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 443);
            this.Controls.Add(this.KullaniciAnaSyfPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "KullaniciAnaSayfa";
            this.Text = "Ana Sayfa";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormVbGor;
        private System.Windows.Forms.Button btnFormTIslem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.FlowLayoutPanel KullaniciAnaSyfPanel;
    }
}

