namespace RestaurantFinal
{
    partial class FrmRestaurantRegister
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtROName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtROId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtROPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(340, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام صاحب رستوران :";
            // 
            // txtROName
            // 
            this.txtROName.Location = new System.Drawing.Point(238, 74);
            this.txtROName.Name = "txtROName";
            this.txtROName.Size = new System.Drawing.Size(240, 22);
            this.txtROName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(239, 214);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "کد ملی صاحب رستوران :";
            // 
            // txtROId
            // 
            this.txtROId.Location = new System.Drawing.Point(238, 102);
            this.txtROId.Name = "txtROId";
            this.txtROId.Size = new System.Drawing.Size(240, 22);
            this.txtROId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "شماره تلفن رستوران دار :";
            // 
            // txtROPhone
            // 
            this.txtROPhone.Location = new System.Drawing.Point(238, 130);
            this.txtROPhone.Name = "txtROPhone";
            this.txtROPhone.Size = new System.Drawing.Size(240, 22);
            this.txtROPhone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "ساعت شروع به کار :";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(239, 158);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(240, 22);
            this.txtStart.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ساعت پایان کار :";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(238, 186);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(240, 22);
            this.txtEnd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "آدرس :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "نام رستوران :";
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(238, 46);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(240, 22);
            this.txtRName.TabIndex = 1;
            this.txtRName.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "نمایش رستوران ها";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRestaurantRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtROPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtROId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtROName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRName);
            this.Controls.Add(this.label8);
            this.Name = "FrmRestaurantRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت رستوران ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtROName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtROId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtROPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.Button button1;
    }
}