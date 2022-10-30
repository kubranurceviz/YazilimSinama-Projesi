
namespace yaz.sın_4
{
    partial class tIslem
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
            this.lblTransferSHA = new System.Windows.Forms.Label();
            this.txbTransferSHA = new System.Windows.Forms.TextBox();
            this.lbltransferRCmiktar = new System.Windows.Forms.Label();
            this.txbTransferRCAmount = new System.Windows.Forms.TextBox();
            this.btnTransferEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransferSHA
            // 
            this.lblTransferSHA.AutoSize = true;
            this.lblTransferSHA.Location = new System.Drawing.Point(68, 44);
            this.lblTransferSHA.Name = "lblTransferSHA";
            this.lblTransferSHA.Size = new System.Drawing.Size(160, 20);
            this.lblTransferSHA.TabIndex = 0;
            this.lblTransferSHA.Text = "Transfer edilecek adres";
            // 
            // txbTransferSHA
            // 
            this.txbTransferSHA.Location = new System.Drawing.Point(68, 80);
            this.txbTransferSHA.Name = "txbTransferSHA";
            this.txbTransferSHA.Size = new System.Drawing.Size(220, 27);
            this.txbTransferSHA.TabIndex = 1;
            this.txbTransferSHA.TextChanged += new System.EventHandler(this.txbTransferSHA_TextChanged);
            // 
            // lbltransferRCmiktar
            // 
            this.lbltransferRCmiktar.AutoSize = true;
            this.lbltransferRCmiktar.Location = new System.Drawing.Point(68, 152);
            this.lbltransferRCmiktar.Name = "lbltransferRCmiktar";
            this.lbltransferRCmiktar.Size = new System.Drawing.Size(89, 20);
            this.lbltransferRCmiktar.TabIndex = 2;
            this.lbltransferRCmiktar.Text = "Coin miktarı";
            this.lbltransferRCmiktar.Click += new System.EventHandler(this.lbltransferRCmiktar_Click);
            // 
            // txbTransferRCAmount
            // 
            this.txbTransferRCAmount.Location = new System.Drawing.Point(68, 184);
            this.txbTransferRCAmount.Name = "txbTransferRCAmount";
            this.txbTransferRCAmount.Size = new System.Drawing.Size(220, 27);
            this.txbTransferRCAmount.TabIndex = 3;
            this.txbTransferRCAmount.TextChanged += new System.EventHandler(this.txbTransferRCAmount_TextChanged);
            // 
            // btnTransferEt
            // 
            this.btnTransferEt.Location = new System.Drawing.Point(68, 235);
            this.btnTransferEt.Name = "btnTransferEt";
            this.btnTransferEt.Size = new System.Drawing.Size(94, 29);
            this.btnTransferEt.TabIndex = 4;
            this.btnTransferEt.Text = "Transfer Et";
            this.btnTransferEt.UseVisualStyleBackColor = true;
            this.btnTransferEt.Click += new System.EventHandler(this.btnTransferEt_Click);
            // 
            // tIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 348);
            this.Controls.Add(this.btnTransferEt);
            this.Controls.Add(this.txbTransferRCAmount);
            this.Controls.Add(this.lbltransferRCmiktar);
            this.Controls.Add(this.txbTransferSHA);
            this.Controls.Add(this.lblTransferSHA);
            this.Name = "tIslem";
            this.Text = "Transfer İşlemleri";
            this.Load += new System.EventHandler(this.tIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferSHA;
        private System.Windows.Forms.TextBox txbTransferSHA;
        private System.Windows.Forms.Label lbltransferRCmiktar;
        private System.Windows.Forms.TextBox txbTransferRCAmount;
        private System.Windows.Forms.Button btnTransferEt;
    }
}