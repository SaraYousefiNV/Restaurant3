using System;

namespace Restaurant3
{
    partial class FrmUser
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.grpUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(492, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 21);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(590, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.NationalCode,
            this.Mobile,
            this.Address});
            this.dgUsers.Location = new System.Drawing.Point(0, 20);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.Size = new System.Drawing.Size(776, 136);
            this.dgUsers.TabIndex = 2;
            this.dgUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.FillWeight = 97.08123F;
            this.FirstName.HeaderText = "نام";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 142;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.FillWeight = 97.08123F;
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 143;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.FillWeight = 97.08123F;
            this.NationalCode.HeaderText = "کد ملی";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            this.NationalCode.Visible = false;
            this.NationalCode.Width = 142;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.FillWeight = 97.08123F;
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Visible = false;
            this.Mobile.Width = 142;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 111.6751F;
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام خانوادگی :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(492, 53);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(181, 21);
            this.txtFamily.TabIndex = 4;
            this.txtFamily.TextChanged += new System.EventHandler(this.txtFamily_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "کد ملی :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(492, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 21);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "موبایل :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(492, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 21);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(688, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "آدرس :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(639, 21);
            this.textBox1.TabIndex = 19;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btnSave);
            this.grpUser.Controls.Add(this.label5);
            this.grpUser.Controls.Add(this.txtName);
            this.grpUser.Controls.Add(this.textBox1);
            this.grpUser.Controls.Add(this.label1);
            this.grpUser.Controls.Add(this.label4);
            this.grpUser.Controls.Add(this.txtFamily);
            this.grpUser.Controls.Add(this.txtAddress);
            this.grpUser.Controls.Add(this.label2);
            this.grpUser.Controls.Add(this.label3);
            this.grpUser.Controls.Add(this.txtID);
            this.grpUser.Location = new System.Drawing.Point(12, 12);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(776, 269);
            this.grpUser.TabIndex = 21;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "اطلاعات کاربر";
            this.grpUser.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgUsers);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 162);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کاربران";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(801, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpUser);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام کاربر";
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}

