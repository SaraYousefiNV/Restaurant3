namespace Restaurant3
{
    partial class FrmAdmin
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
            this.dgRestaurant = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDfrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grpRes = new System.Windows.Forms.GroupBox();
            this.grpResDB = new System.Windows.Forms.GroupBox();
            this.ResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurant)).BeginInit();
            this.grpRes.SuspendLayout();
            this.grpResDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRestaurant
            // 
            this.dgRestaurant.AllowUserToAddRows = false;
            this.dgRestaurant.AllowUserToDeleteRows = false;
            this.dgRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestaurant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResName,
            this.OwnerFullName,
            this.OwnerMobile,
            this.OwnerNationalCode,
            this.StartTime,
            this.EndTime,
            this.Address});
            this.dgRestaurant.Location = new System.Drawing.Point(0, 20);
            this.dgRestaurant.Name = "dgRestaurant";
            this.dgRestaurant.ReadOnly = true;
            this.dgRestaurant.Size = new System.Drawing.Size(775, 121);
            this.dgRestaurant.TabIndex = 42;
            this.dgRestaurant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "کد ملی :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(42, 199);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(585, 21);
            this.txtAddress.TabIndex = 40;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "تا :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "از :";
            // 
            // txtDTo
            // 
            this.txtDTo.Location = new System.Drawing.Point(446, 92);
            this.txtDTo.Name = "txtDTo";
            this.txtDTo.Size = new System.Drawing.Size(70, 21);
            this.txtDTo.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(662, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "آدرس :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(662, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "موبایل :";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(446, 163);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(181, 21);
            this.txtNationalCode.TabIndex = 34;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(446, 128);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(181, 21);
            this.txtMobile.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(662, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "ساعت کارکرد :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDfrom
            // 
            this.txtDfrom.Location = new System.Drawing.Point(546, 92);
            this.txtDfrom.Name = "txtDfrom";
            this.txtDfrom.Size = new System.Drawing.Size(70, 21);
            this.txtDfrom.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(643, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "نام مالک رستوران :";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(446, 50);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(181, 21);
            this.txtOwnerName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(669, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "نام رستوران :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 39);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(446, 15);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(181, 21);
            this.txtFullName.TabIndex = 26;
            // 
            // grpRes
            // 
            this.grpRes.Controls.Add(this.txtFullName);
            this.grpRes.Controls.Add(this.btnSave);
            this.grpRes.Controls.Add(this.label8);
            this.grpRes.Controls.Add(this.label1);
            this.grpRes.Controls.Add(this.txtAddress);
            this.grpRes.Controls.Add(this.txtOwnerName);
            this.grpRes.Controls.Add(this.label7);
            this.grpRes.Controls.Add(this.label2);
            this.grpRes.Controls.Add(this.label6);
            this.grpRes.Controls.Add(this.txtDfrom);
            this.grpRes.Controls.Add(this.txtDTo);
            this.grpRes.Controls.Add(this.label3);
            this.grpRes.Controls.Add(this.label5);
            this.grpRes.Controls.Add(this.txtMobile);
            this.grpRes.Controls.Add(this.label4);
            this.grpRes.Controls.Add(this.txtNationalCode);
            this.grpRes.Location = new System.Drawing.Point(12, 6);
            this.grpRes.Name = "grpRes";
            this.grpRes.Size = new System.Drawing.Size(776, 279);
            this.grpRes.TabIndex = 43;
            this.grpRes.TabStop = false;
            this.grpRes.Text = "اطلاعات رستوران";
            this.grpRes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpResDB
            // 
            this.grpResDB.Controls.Add(this.dgRestaurant);
            this.grpResDB.Location = new System.Drawing.Point(12, 291);
            this.grpResDB.Name = "grpResDB";
            this.grpResDB.Size = new System.Drawing.Size(775, 147);
            this.grpResDB.TabIndex = 44;
            this.grpResDB.TabStop = false;
            this.grpResDB.Text = "رستوران ها";
            // 
            // ResName
            // 
            this.ResName.DataPropertyName = "Name";
            this.ResName.HeaderText = "نام رستوران";
            this.ResName.Name = "ResName";
            this.ResName.ReadOnly = true;
            this.ResName.Width = 250;
            // 
            // OwnerFullName
            // 
            this.OwnerFullName.DataPropertyName = "OwnerFullName";
            this.OwnerFullName.HeaderText = "نام مالک رستوران";
            this.OwnerFullName.Name = "OwnerFullName";
            this.OwnerFullName.ReadOnly = true;
            this.OwnerFullName.Width = 150;
            // 
            // OwnerMobile
            // 
            this.OwnerMobile.DataPropertyName = "OwnerMobile";
            this.OwnerMobile.HeaderText = "موبایل مالک رستوران";
            this.OwnerMobile.Name = "OwnerMobile";
            this.OwnerMobile.ReadOnly = true;
            this.OwnerMobile.Visible = false;
            this.OwnerMobile.Width = 150;
            // 
            // OwnerNationalCode
            // 
            this.OwnerNationalCode.DataPropertyName = "OwnerNationalCode";
            this.OwnerNationalCode.HeaderText = "کد ملی مالک رستوران";
            this.OwnerNationalCode.Name = "OwnerNationalCode";
            this.OwnerNationalCode.ReadOnly = true;
            this.OwnerNationalCode.Visible = false;
            this.OwnerNationalCode.Width = 150;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "ساعت شروع کار";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 120;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "ساعت اتمام کار";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 120;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 220;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpResDB);
            this.Controls.Add(this.grpRes);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FrmAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام رستوران";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurant)).EndInit();
            this.grpRes.ResumeLayout(false);
            this.grpRes.PerformLayout();
            this.grpResDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRestaurant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox grpRes;
        private System.Windows.Forms.GroupBox grpResDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}