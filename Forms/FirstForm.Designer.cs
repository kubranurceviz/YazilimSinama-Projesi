
namespace yaz.sın_4.Forms
{
    partial class FirstForm
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(101, 79);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(339, 418);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(445, 79);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(339, 418);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 578);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button btnUser;
    }
}