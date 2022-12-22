
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
            this.lblMevcutRCmiktari = new System.Windows.Forms.Label();
            this.txbMevcutRCmiktari = new System.Windows.Forms.TextBox();
            this.labelİism = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMevcutRCmiktari
            // 
            this.lblMevcutRCmiktari.AutoSize = true;
            this.lblMevcutRCmiktari.Location = new System.Drawing.Point(64, 168);
            this.lblMevcutRCmiktari.Name = "lblMevcutRCmiktari";
            this.lblMevcutRCmiktari.Size = new System.Drawing.Size(227, 20);
            this.lblMevcutRCmiktari.TabIndex = 3;
            this.lblMevcutRCmiktari.Text = "Mevcut Recycle Coin (RC) miktarı";
            // 
            // txbMevcutRCmiktari
            // 
            this.txbMevcutRCmiktari.Location = new System.Drawing.Point(64, 203);
            this.txbMevcutRCmiktari.Name = "txbMevcutRCmiktari";
            this.txbMevcutRCmiktari.Size = new System.Drawing.Size(227, 27);
            this.txbMevcutRCmiktari.TabIndex = 4;
            // 
            // labelİism
            // 
            this.labelİism.AutoSize = true;
            this.labelİism.Location = new System.Drawing.Point(64, 33);
            this.labelİism.Name = "labelİism";
            this.labelİism.Size = new System.Drawing.Size(50, 20);
            this.labelİism.TabIndex = 5;
            this.labelİism.Text = "label1";
            // 
            // vbGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 350);
            this.Controls.Add(this.labelİism);
            this.Controls.Add(this.txbMevcutRCmiktari);
            this.Controls.Add(this.lblMevcutRCmiktari);
            this.Name = "vbGor";
            this.Text = "Varlıklar ve Borçları Görüntüleme";
            this.Load += new System.EventHandler(this.vbGor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMevcutRCmiktari;
        private System.Windows.Forms.TextBox txbMevcutRCmiktari;
        private System.Windows.Forms.Label labelİism;
    }
}