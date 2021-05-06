using PBL.DAL;
using PBL.DTO;
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
            setGUI();
        }

        private void setGUI()
        {
            ShowDgvStaff();
            ShowDgvChucVu();
            SetCBB();
            cbSortNV.SelectedIndex = 0;
            cbSearchNV.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
            cbSortCV.SelectedIndex = 0;
            cbSearchCV.SelectedIndex = 0;
        }

        private void SetCBB()
        {
            cbPosition.Items.AddRange(BLL_QLCV.Instance.GetListCBBChucVu().ToArray());
        }

        #region Code cua Tab Chuc Vu
        private void RefreshCV()
        {
            txbSearchCV.Clear();
            txbChucVu.Clear();
            txbMota.Clear();
            txbQuyenHan.Clear();
            ShowDgvChucVu();
        }

        //Hien thi datagridview chuc vu
        private void ShowDgvChucVu()
        {
            dgvChucVu.DataSource = BLL_QLCV.Instance.GetListChucVu(txbSearchCV.Text);
            dgvChucVu.Columns["ChucVuID"].Visible = false;
            dgvChucVu.Columns["NHANVIENs"].Visible = false;
        }

        //Them chuc vu
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
                    RefreshCV();
                }
                else
                {
                    MessageBox.Show("Them chuc vu that bai! Vui long kiem tra lai thong tin");
                }
            }
            catch
            {
                MessageBox.Show("Vui long nhap day du thong tin chuc vu!");
            }
        }

        //Cap nhat chuc vu
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
                    RefreshCV();
                }
                else
                {
                    MessageBox.Show("Cap nhat chuc vu that bai! Vui long kiem tra lai thong tin");
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon chuc vu va nhap day du thong tin chuc vu!");
            }
        }

        //Xoa chuc vu
        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay chuc vu ID de xoa
                string cvid = dgvChucVu.SelectedRows[0].Cells["ChucVuID"].Value.ToString();
                if (BLL_QLCV.Instance.DeleteChucVu(cvid))
                {
                    MessageBox.Show("Xoa chuc vu thanh cong!");
                    RefreshCV();
                }
                else
                {
                    MessageBox.Show("Chuc vu khong the xoa! Vui long kiem tra lai");
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon chuc vu can xoa!");
            }
        }

        //clear cac thong tin tren textbox
        private void btnClearCV_Click(object sender, EventArgs e)
        {
            RefreshCV();   
        }

        //Tim kiem chuc vu
        private void btnSearchCV_Click(object sender, EventArgs e)
        {
            dgvChucVu.DataSource = BLL_QLCV.Instance.GetListChucVu(txbSearchCV.Text);
        }

        //click row tren datagridview se hien thi len cac textbox va combobox
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbChucVu.Text = dgvChucVu.SelectedRows[0].Cells["TenChucVu"].Value.ToString();
            txbMota.Text = dgvChucVu.SelectedRows[0].Cells["MoTa"].Value.ToString();
            txbQuyenHan.Text = dgvChucVu.SelectedRows[0].Cells["QuyenHan"].Value.ToString();
        }

        //sap xep chuc vu
        private void btnSortCV_Click(object sender, EventArgs e)
        {
            if (cbSortCV.SelectedIndex >= 0)
            {
                //List cac ChucVuID dang hien thi tren datagridview
                List<string> LcvID = new List<string>();
                for (int i = 0; i < dgvChucVu.Rows.Count; i++)
                {
                    LcvID.Add(dgvChucVu.Rows[i].Cells["ChucVuID"].Value.ToString());
                }
                dgvChucVu.DataSource = BLL_QLCV.Instance.GetListChucVuSorted(LcvID, cbSortCV.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui long chon kieu sap xep!");
            }
        }
        #endregion

        #region Code cua Tab Nhan Vien

        private void RefreshNV()
        {
            txbName.Clear();
            cbGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Now;
            txbPhone.Clear();
            txbCMND.Clear();
            txbAddress.Clear();
            cbPosition.SelectedIndex = -1;
            txbNote.Clear();
        }

        //Hien thi datagridview nhan vien
        private void ShowDgvStaff()
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetAllNhanVien();
            dgvStaff.Columns["NhanVienID"].Visible = false;
            dgvStaff.Columns["ChucVuID"].Visible = false;
        }

        //Them nhan vien
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN()
                {
                    Ten = txbName.Text,
                    GioiTinh = (string.Compare(cbGender.SelectedItem.ToString(), "Nam") == 0) ? true : false,
                    NgaySinh = dtpBirthday.Value,
                    CMND = txbCMND.Text,
                    SDT = txbPhone.Text,
                    DiaChi = txbAddress.Text,
                    ChucVuID = ((CBBItem)cbPosition.SelectedItem).Value,
                    GhiChu = txbNote.Text,
                };
                if (BLL_QLNV.Instance.AddNhanVien(nv))
                {
                    MessageBox.Show("Them nhan vien thanh cong!");
                    RefreshNV();
                }
                else
                {
                    MessageBox.Show("Them nhan vien that bai! Vui long kiem tra lai thong tin");
                }
            }
            catch
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
            }
        }

        //Cap nhat nhan vien
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN()
                {
                    NhanVienID = dgvStaff.SelectedRows[0].Cells["NhanVienID"].Value.ToString(),
                    Ten = txbName.Text,
                    GioiTinh = (string.Compare(cbGender.SelectedItem.ToString(), "Nam") == 0) ? true : false,
                    NgaySinh = dtpBirthday.Value,
                    CMND = txbCMND.Text,
                    SDT = txbPhone.Text,
                    DiaChi = txbAddress.Text,
                    ChucVuID = ((CBBItem)cbPosition.SelectedItem).Value,
                    GhiChu = txbNote.Text,
                };
                if (BLL_QLNV.Instance.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Cap nhat thong tin nhan vien thanh cong!");
                    RefreshNV();
                }
                else
                {
                    MessageBox.Show("cap nhat thong tin nhan vien that bai! Vui long kiem tra lai thong tin");
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon nhan vien va nhap day du thong tin!");
            }
        }

        //Xoa nhan vien
        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            try
            {
                string nvid = dgvStaff.SelectedRows[0].Cells["NhanVienID"].Value.ToString();
                if (BLL_QLNV.Instance.DeleteNhanVien(nvid))
                {
                    MessageBox.Show("Xoa nhan vien thanh cong!");
                    RefreshNV();
                }
                else
                {
                    MessageBox.Show("Nhan vien khong the xoa! Vui long kiem tra lai");
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon nhan vien can xoa!");
            }
        }
        #endregion
    }
}
