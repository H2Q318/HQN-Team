using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBL
{
    public partial class fLogin : Form
    {
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void refreshLogin()
        {
            txbUserName.Clear();
            txbPassword.Clear();
            lbTB.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLL_DangNhap.Instance.CheckLogin(txbUserName.Text, txbPassword.Text))
            {
                fHome f = new fHome(txbUserName.Text);
                this.Hide();
                f.ShowDialog();
                BLL_DangNhap.Instance.SetStatusAccount(txbUserName.Text, false);
                refreshLogin();
                this.Show();
            }
            else
            {
                lbTB.Visible = true;
                txbPassword.Clear();
            }
}
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
