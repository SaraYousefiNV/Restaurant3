using System;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void FrmRes_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmUser FrmUser = new FrmUser();
            FrmUser.Show();

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
