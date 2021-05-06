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
    public partial class fStaffManager : Form
    {
        public fStaffManager()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            ShowDgvStaff();
            ShowDgvChucVu();
        }

        private void ShowDgvStaff()
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetAllNhanVien();
            dgvStaff.Columns["NhanVienID"].Visible = false;
            dgvStaff.Columns["ChucVuID"].Visible = false;
        }
        private void ShowDgvChucVu()
        {
            dgvChucVu.DataSource = BLL_QLCV.Instance.GetAllChucVu();
            dgvChucVu.Columns["ChucVuID"].Visible = false;
            dgvChucVu.Columns["NHANVIENs"].Visible = false;
        }

        private void btnAddCV_Click(object sender, EventArgs e)
        {
            try
            {
                CHUCVU cv = new CHUCVU
                {
                    TenChucVu = txbChucVu.Text,
                    MoTa = txbMota.Text,
                    QuyenHan = Convert.ToInt32(txbQuyenHan.Text)
                };
                if (BLL_QLCV.Instance.AddChucVu(cv))
                {
                    MessageBox.Show("Them chuc vu thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them chuc vu that bai! Vui long kiem tra lai thong tin");
                }
                ShowDgvChucVu();
            }
            catch
            {
                MessageBox.Show("Vui long nhap day du thong tin chuc vu!");
            }
        }

        private void btnUpdateCV_Click(object sender, EventArgs e)
        {
            try
            {
                CHUCVU cv = new CHUCVU
                {
                    ChucVuID = dgvChucVu.SelectedRows[0].Cells["ChucVuID"].Value.ToString(),
                    TenChucVu = txbChucVu.Text,
                    MoTa = txbMota.Text,
                    QuyenHan = Convert.ToInt32(txbQuyenHan.Text)
                };
                if (BLL_QLCV.Instance.UpdateChucVu(cv))
                {
                    MessageBox.Show("Cap nhat chuc vu thanh cong!");
                }
                else
                {
                    MessageBox.Show("Cap nhat chuc vu that bai! Vui long kiem tra lai thong tin");
                }
                ShowDgvChucVu();
            }
            catch
            {
                MessageBox.Show("Vui long nhap day du thong tin chuc vu!");
            }
        }

        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
            try
            {
                string cvid = dgvChucVu.SelectedRows[0].Cells["ChucVuID"].Value.ToString();
                if (BLL_QLCV.Instance.DeleteChucVu(cvid))
                {
                    MessageBox.Show("Xoa chuc vu thanh cong!");
                }
                else
                {
                    MessageBox.Show("Chuc vu khong the xoa! Vui long kiem tra lai");
                }
                ShowDgvChucVu();
            }
            catch
            {
                MessageBox.Show("Vui long chon chuc vu can xoa!");
            }
        }

        private void btnClearCV_Click(object sender, EventArgs e)
        {
            txbChucVu.Clear();
            txbMota.Clear();
            txbQuyenHan.Clear();
            ShowDgvChucVu();
        }

        private void btnSearchCV_Click(object sender, EventArgs e)
        {
            dgvChucVu.DataSource = BLL_QLCV.Instance.SearchChucVu(txbSearchCV.Text);
        }
    }
}
