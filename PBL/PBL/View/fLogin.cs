using System;
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
            if (txbUserName.Text == string.Empty || txbPassword.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            }
            else if (BLL_DangNhap.Instance.CheckPassword(txbUserName.Text, txbPassword.Text))
            {
                if (!BLL_DangNhap.Instance.isLogin(txbUserName.Text))
                {
                    fHome f = new fHome(txbUserName.Text);
                    this.Hide();
                    BLL_DangNhap.Instance.SetStatusAccount(txbUserName.Text, true);
                    f.ShowDialog();
                    BLL_DangNhap.Instance.SetStatusAccount(txbUserName.Text, false);
                    refreshLogin();
                    this.Show();
                }
                else
                {
                    lbTB.Text = "Tài khoản đã có người đăng nhập";
                    lbTB.Visible = true;
                    txbPassword.Clear();
                }
            }
            else
            {
                lbTB.Text = "Sai tài khoản hoặc mật khẩu";
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
