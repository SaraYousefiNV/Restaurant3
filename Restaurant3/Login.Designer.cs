namespace Restaurant3
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gpSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.gpSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "رمز عبور :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 21);
            this.txtPassword.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام کاربری :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(92, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 21);
            this.txtUser.TabIndex = 6;
            // 
            // gpSignIn
            // 
            this.gpSignIn.Controls.Add(this.btnSignIn);
            this.gpSignIn.Controls.Add(this.txtPassword);
            this.gpSignIn.Controls.Add(this.label2);
            this.gpSignIn.Controls.Add(this.txtUser);
            this.gpSignIn.Controls.Add(this.label1);
            this.gpSignIn.Location = new System.Drawing.Point(12, 12);
            this.gpSignIn.Name = "gpSignIn";
            this.gpSignIn.Size = new System.Drawing.Size(367, 182);
            this.gpSignIn.TabIndex = 10;
            this.gpSignIn.TabStop = false;
            this.gpSignIn.Text = "ورود کاربر";
            this.gpSignIn.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(198, 122);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "ورود";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 207);
            this.Controls.Add(this.gpSignIn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gpSignIn.ResumeLayout(false);
            this.gpSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox gpSignIn;
        private System.Windows.Forms.Button btnSignIn;
    }
}