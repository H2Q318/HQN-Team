using PBL.DAL;
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
    public partial class fAccount : Form
    {
        private string IDNhanVien;
        public fAccount(string username)
        {
            InitializeComponent();
            IDNhanVien = username;
            SetGUI();
        }
        
        private void SetGUI()
        {
            NV_View nv = new NV_View(BLL_QLNV.Instance.GetNhanVienByID(IDNhanVien));
            txbID.Text = nv.NhanVienID;
            txbName.Text = nv.Ten;
            cbGender.SelectedIndex = (nv.GioiTinh == true) ? 0 : 1;
            dtpBirthday.Value = nv.NgaySinh;
            txbPhone.Text = nv.SDT;
            txbCMND.Text = nv.CMND;
            txbAddress.Text = nv.DiaChi;
            txbPosition.Text = nv.TenChucVu;
            txbNote.Text = nv.GhiChu;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbName.TextLength != 0 && txbPhone.TextLength != 0 && txbCMND.TextLength != 0 && txbAddress.TextLength != 0)
            {
                NHANVIEN nv = new NHANVIEN
                {
                    NhanVienID = txbID.Text,
                    Ten = txbName.Text,
                    GioiTinh = (string.Compare(cbGender.SelectedItem.ToString(), "Nam") == 0) ? true : false,
                    NgaySinh = dtpBirthday.Value,
                    SDT = txbPhone.Text,
                    CMND = txbCMND.Text,
                    DiaChi = txbAddress.Text,
                    ChucVuID = BLL_QLNV.Instance.GetNhanVienByID(IDNhanVien).ChucVuID,
                    GhiChu = txbNote.Text
                };
                if (BLL_QLNV.Instance.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                } 
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công! Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cá nhân!");
            }
        }

        private void JustNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
