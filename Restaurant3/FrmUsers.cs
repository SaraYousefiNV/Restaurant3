using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using System.Runtime.Remoting.Services;
using Repository;


namespace Restaurant3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        CustomerDBEntitiesEntities1 db = new CustomerDBEntitiesEntities1();        
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerList tbl = new CustomerList();
            tbl.Name = txtName.Text;
            tbl.FamilyName = txtFamily.Text;
            tbl.ID = txtID.Text;
            tbl.Address = txtAddress.Text;
            db.CustomerLists.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            var q = (from f in db.CustomerLists select f).ToList();
            dgv.DataSource = q;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var q = (from f in db.CustomerLists select f).ToList();
            dgv.DataSource = q;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
