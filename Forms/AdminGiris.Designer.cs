
namespace yaz.sın_4.Forms
{
    partial class AdminGiris
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(81, 320);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(210, 27);
            this.textBoxSifre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(81, 225);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(210, 27);
            this.textBoxAd.TabIndex = 3;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(220, 432);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(94, 29);
            this.buttonGiris.TabIndex = 6;
            this.buttonGiris.Text = "GirişYap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 540);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAd);
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button buttonGiris;
    }
}