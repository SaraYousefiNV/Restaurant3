using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class FrmRes : Form
    {
        public FrmRes()
        {
            InitializeComponent();
        }
        
        private void FrmRes_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain FrmMain = new FrmMain();
            FrmMain.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

        }
    }
}
