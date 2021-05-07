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
            dgvChucVu.Rows[0].Selected = false;
            dgvChucVu.Columns["ChucVuID"].Visible = false;
            dgvChucVu.Columns["NHANVIENs"].Visible = false;
        }

        //Them chuc vu
        private void btnAddCV_Click(object sender, EventArgs e)
        {
            if (txbChucVu.TextLength != 0 && txbQuyenHan.TextLength != 0)
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
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin !");
            }
        }

        //Cap nhat chuc vu
        private void btnUpdateCV_Click(object sender, EventArgs e)
        {
            if (txbChucVu.TextLength != 0 && txbQuyenHan.TextLength != 0)
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
            else
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

        //khong mac dinh chon dong dau tien trong datagridview chuc vu
        private void dgvChucVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvChucVu.ClearSelection();
        }
        #endregion

        #region Code cua Tab Nhan Vien

        private void RefreshNV()
        {
            txbName.Clear();
            dtpBirthday.Value = DateTime.Now;
            txbPhone.Clear();
            txbCMND.Clear();
            txbAddress.Clear();
            txbNote.Clear();
            txbSearchNV.Clear();
            ShowDgvStaff();
        }

        //Hien thi datagridview nhan vien
        private void ShowDgvStaff()
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetAllNhanVien();
            dgvStaff.ClearSelection();
            dgvStaff.Columns["NhanVienID"].Visible = false;
            dgvStaff.Columns["ChucVuID"].Visible = false;
        }

        //Them nhan vien
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txbName.TextLength != 0 && txbPhone.TextLength != 0 && txbCMND.TextLength != 0 && txbAddress.TextLength != 0)
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
                    ShowDgvStaff();
                }
                else
                {
                    MessageBox.Show("Them nhan vien that bai! Vui long kiem tra lai thong tin");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
            }
        }

        //Cap nhat nhan vien
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if (txbName.TextLength != 0 && txbPhone.TextLength != 0 && txbCMND.TextLength != 0 && txbAddress.TextLength != 0)
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
                    ShowDgvStaff();
                }
                else
                {
                    MessageBox.Show("cap nhat thong tin nhan vien that bai! Vui long kiem tra lai thong tin");
                }
            }
            else
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
                    ShowDgvStaff();
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

        //Search nhan vien
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStaff.DataSource = BLL_QLNV.Instance.GetListNhanVien(txbSearchNV.Text, cbSearchNV.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Vui long chon loai tim kiem!");
            }
        }

        //click row tren datagridview se hien thi len cac textbox va combobox
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedrow = dgvStaff.SelectedRows[0];
            txbName.Text = selectedrow.Cells["Ten"].Value.ToString();
            cbGender.SelectedIndex = ((bool)selectedrow.Cells["GioiTinh"].Value) ? 0 : 1;
            dtpBirthday.Value = (DateTime)selectedrow.Cells["NgaySinh"].Value;
            txbPhone.Text = selectedrow.Cells["SDT"].Value.ToString();
            txbCMND.Text = selectedrow.Cells["CMND"].Value.ToString();
            txbAddress.Text = selectedrow.Cells["DiaChi"].Value.ToString();
            cbPosition.Text = selectedrow.Cells["TenChucVu"].Value.ToString();
            txbNote.Text = selectedrow.Cells["GhiChu"].Value.ToString();
        }

        private void btnClearNV_Click(object sender, EventArgs e)
        {
            RefreshNV();
        }

        private void btnSortNV_Click(object sender, EventArgs e)
        {
            if (cbSortNV.SelectedIndex >= 0)
            {
                //Lay list cac NhanVienID dang hien thi tren datagridview
                List<string> LnvID = new List<string>();
                for (int i = 0; i < dgvStaff.Rows.Count; i++)
                {
                    LnvID.Add(dgvStaff.Rows[i].Cells["NhanVienID"].Value.ToString());
                }
                dgvStaff.DataSource = BLL_QLNV.Instance.GetListNhanVienSorted(LnvID, cbSortNV.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui long chon kieu sap xep!");
            }
        }

        //Khong mac dinh chon dong dau tien trong datagridview nhan vien
        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStaff.ClearSelection();
        }
        #endregion

    }
}
