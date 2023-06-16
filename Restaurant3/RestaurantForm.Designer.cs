namespace Restaurant3
{
    partial class RestaurantForm
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
            this.dgResList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgResList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResList
            // 
            this.dgResList.AllowUserToAddRows = false;
            this.dgResList.AllowUserToDeleteRows = false;
            this.dgResList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgResList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgResList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgResList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ResName});
            this.dgResList.GridColor = System.Drawing.SystemColors.Control;
            this.dgResList.Location = new System.Drawing.Point(12, 12);
            this.dgResList.MultiSelect = false;
            this.dgResList.Name = "dgResList";
            this.dgResList.ReadOnly = true;
            this.dgResList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgResList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgResList.Size = new System.Drawing.Size(289, 359);
            this.dgResList.TabIndex = 0;
            this.dgResList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResList_CellContentClick);
            this.dgResList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResList_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد رستوران";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ResName
            // 
            this.ResName.DataPropertyName = "FullName";
            this.ResName.HeaderText = "نام رستوران";
            this.ResName.Name = "ResName";
            this.ResName.ReadOnly = true;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 383);
            this.Controls.Add(this.dgResList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رستورانها";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResName;
    }
}