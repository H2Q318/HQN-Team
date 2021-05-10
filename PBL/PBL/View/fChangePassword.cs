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
            if (txbOldPassword.TextLength != 0 && txbNewPassword.TextLength != 0 && txbNewPasswordAgain.TextLength != 0)
            {
                if (txbNewPassword.Text.Equals(txbNewPasswordAgain.Text))
                {
                    if (BLL_DangNhap.Instance.CheckPassword(IDNhanVien, txbOldPassword.Text))
                    {
                        BLL_DangNhap.Instance.UpdatePassword(IDNhanVien, txbNewPassword.Text);
                        MessageBox.Show("Doi mat khau thanh cong!");
                    }
                    else
                    {
                        MessageBox.Show("Doi mat khau khong thanh cong! Vui long kiem tra lai");
                    }
                }
                else
                {
                    MessageBox.Show("Mat khau moi khong khop! Vui long kiem tra lai");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
            }
        }
        #endregion
    }
}
