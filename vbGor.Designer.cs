
namespace yaz.sın_4
{
    partial class vbGor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMevcutCmiktari = new System.Windows.Forms.Label();
            this.txbMevcutCmiktari = new System.Windows.Forms.TextBox();
            this.lblMevcutRCmiktari = new System.Windows.Forms.Label();
            this.txbMevcutRCmiktari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMevcutCmiktari
            // 
            this.lblMevcutCmiktari.AutoSize = true;
            this.lblMevcutCmiktari.Location = new System.Drawing.Point(64, 49);
            this.lblMevcutCmiktari.Name = "lblMevcutCmiktari";
            this.lblMevcutCmiktari.Size = new System.Drawing.Size(182, 20);
            this.lblMevcutCmiktari.TabIndex = 1;
            this.lblMevcutCmiktari.Text = "Mevcut Carbon (C) miktarı";
            // 
            // txbMevcutCmiktari
            // 
            this.txbMevcutCmiktari.Location = new System.Drawing.Point(64, 85);
            this.txbMevcutCmiktari.Name = "txbMevcutCmiktari";
            this.txbMevcutCmiktari.Size = new System.Drawing.Size(227, 27);
            this.txbMevcutCmiktari.TabIndex = 2;
            // 
            // lblMevcutRCmiktari
            // 
            this.lblMevcutRCmiktari.AutoSize = true;
            this.lblMevcutRCmiktari.Location = new System.Drawing.Point(64, 168);
            this.lblMevcutRCmiktari.Name = "lblMevcutRCmiktari";
            this.lblMevcutRCmiktari.Size = new System.Drawing.Size(227, 20);
            this.lblMevcutRCmiktari.TabIndex = 3;
            this.lblMevcutRCmiktari.Text = "Mevcut Recycle Coin (RC) miktarı";
            this.lblMevcutRCmiktari.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbMevcutRCmiktari
            // 
            this.txbMevcutRCmiktari.Location = new System.Drawing.Point(64, 203);
            this.txbMevcutRCmiktari.Name = "txbMevcutRCmiktari";
            this.txbMevcutRCmiktari.Size = new System.Drawing.Size(227, 27);
            this.txbMevcutRCmiktari.TabIndex = 4;
            // 
            // vbGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 409);
            this.Controls.Add(this.txbMevcutRCmiktari);
            this.Controls.Add(this.lblMevcutRCmiktari);
            this.Controls.Add(this.txbMevcutCmiktari);
            this.Controls.Add(this.lblMevcutCmiktari);
            this.Name = "vbGor";
            this.Text = "Varlıklar ve Borçları Görüntüleme";
            this.Load += new System.EventHandler(this.vbGor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMevcutCmiktari;
        private System.Windows.Forms.TextBox txbMevcutCmiktari;
        private System.Windows.Forms.Label lblMevcutRCmiktari;
        private System.Windows.Forms.TextBox txbMevcutRCmiktari;
    }
}