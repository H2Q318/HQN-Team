using System;
using System.Windows.Forms;

namespace PBL
{
    public partial class fChangePassword : Form
    {
        private string IDNhanVien;
        public fChangePassword(string idnhanvien)
        {
            IDNhanVien = idnhanvien;
            InitializeComponent();
        }
        #region Đổi mật khẩu
        private void btnNotUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txbOldPassword.Text == string.Empty || txbNewPassword.Text == string.Empty || txbNewPasswordAgain.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (txbNewPassword.Text.Equals(txbNewPasswordAgain.Text))
            {
                if (BLL_DangNhap.Instance.CheckPassword(IDNhanVien, txbOldPassword.Text))
                {
                    BLL_DangNhap.Instance.UpdatePassword(IDNhanVien, txbNewPassword.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công! Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp! Vui lòng kiểm tra lại");
            }
        }
        #endregion
    }
}
