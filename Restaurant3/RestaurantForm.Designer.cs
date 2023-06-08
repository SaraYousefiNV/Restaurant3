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
            this.factorsButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // factorsButton
            // 
            this.factorsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorsButton.Location = new System.Drawing.Point(63, 115);
            this.factorsButton.Margin = new System.Windows.Forms.Padding(2);
            this.factorsButton.Name = "factorsButton";
            this.factorsButton.Size = new System.Drawing.Size(190, 105);
            this.factorsButton.TabIndex = 3;
            this.factorsButton.Text = "فاکتورها";
            this.factorsButton.UseVisualStyleBackColor = true;
            this.factorsButton.Click += new System.EventHandler(this.factorsButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(339, 115);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(190, 105);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "وارد کردن و ویرایش منو";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.factorsButton);
            this.Controls.Add(this.menuButton);
            this.Name = "RestaurantForm";
            this.Text = "RestaurantForm";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button factorsButton;
        private System.Windows.Forms.Button menuButton;
    }
}