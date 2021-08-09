using PBL.DAL;
using PBL.DTO;
using System;
using System.Collections.Generic;
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
        private void RefreshGUINhanVien()
        {
            cbPosition.Items.Clear();
            cbPosition.ResetText(); 
            cbPosition.Items.AddRange(BLL_QLCV.Instance.GetListCBBChucVu().ToArray());
            ShowDgvStaff();
        }
        private void SetCBB()
        {
            cbPosition.Items.AddRange(BLL_QLCV.Instance.GetListCBBChucVu().ToArray());
        }

        #region Quản lý chức vụ
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
            dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên chức vụ";
            dgvChucVu.Columns["MoTa"].HeaderText = "Mô tả";
            dgvChucVu.Columns["QuyenHan"].HeaderText = "Quyền hạn";
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
                    MessageBox.Show("Thêm chức vụ thành công!");
                    RefreshCV();
                    RefreshGUINhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm chức vụ không thành công! Vui lòng kiểm tra lại thông tin");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        //Cap nhat chuc vu
        private void btnUpdateCV_Click(object sender, EventArgs e)
        {
            try
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
                        MessageBox.Show("Cập nhật chức vụ thành công!");
                        RefreshCV();
                        RefreshGUINhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chức vụ không thành công! Vui lòng kiểm tra lại thông tin");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần cập nhật!");
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
                    MessageBox.Show("Xóa chức vụ thành công!");
                    RefreshCV();
                    RefreshGUINhanVien();
                }
                else
                {
                    MessageBox.Show("Chức vụ không thể xóa! Vui lòng kiểm tra lại");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa!");
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

        //click tren datagridview se hien thi len cac textbox va combobox
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CHUCVU chucVu = BLL_QLCV.Instance.GetChucVuByID(dgvChucVu.SelectedRows[0].Cells["ChucVuID"].Value.ToString());
            txbChucVu.Text = chucVu.TenChucVu;
            txbMota.Text = chucVu.MoTa;
            txbQuyenHan.Text = chucVu.QuyenHan.ToString();
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
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp!");
            }
        }

        //khong mac dinh chon dong dau tien trong datagridview chuc vu
        private void dgvChucVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvChucVu.ClearSelection();
        }
        #endregion

        #region Quản lý nhân viên

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
            dgvStaff.Columns["ChucVuID"].Visible = false;
            dgvStaff.Columns["Ten"].HeaderText = "Tên";
            dgvStaff.Columns["NhanVienID"].HeaderText = "Mã nhân viên";
            dgvStaff.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvStaff.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvStaff.Columns["SDT"].HeaderText = "SĐT";
            dgvStaff.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvStaff.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvStaff.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        //Them nhan vien
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txbName.TextLength != 0 && txbPhone.TextLength != 0 && txbPhone.TextLength != 0 && txbAddress.TextLength != 0)
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
                    MessageBox.Show("Thêm nhân viên thành công!");
                    RefreshNV();
                    ShowDgvStaff();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công! Vui lòng kiểm tra lại thông tin");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        //Cap nhat nhan vien
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbName.TextLength != 0 && txbPhone.TextLength != 0 && txbPhone.TextLength != 0 && txbAddress.TextLength != 0)
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
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                        RefreshNV();
                        ShowDgvStaff();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin không thành công! Vui lòng kiểm tra lại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!");
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
                    MessageBox.Show("Xóa nhân viên thành công!");
                    RefreshNV();
                    ShowDgvStaff();
                }
                else
                {
                    MessageBox.Show("Nhân viên không thể xóa! Vui lòng kiểm tra lại");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
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
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!");
            }
        }

        //click row tren datagridview se hien thi len cac textbox va combobox
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NHANVIEN nhanVien = BLL_QLNV.Instance.GetNhanVienByID(dgvStaff.SelectedRows[0].Cells["NhanVienID"].Value.ToString());
            txbName.Text = nhanVien.Ten;
            cbGender.SelectedIndex = (bool)nhanVien.GioiTinh.Value ? 0 : 1;
            dtpBirthday.Value = (DateTime)nhanVien.NgaySinh;
            txbPhone.Text = nhanVien.SDT;
            txbCMND.Text = nhanVien.CMND;
            txbAddress.Text = nhanVien.DiaChi;
            cbPosition.Text = nhanVien.CHUCVU.TenChucVu;
            txbNote.Text = nhanVien.GhiChu;
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
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp!");
            }
        }

        //Khong mac dinh chon dong dau tien trong datagridview nhan vien
        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStaff.ClearSelection();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_DangNhap.Instance.UpdatePassword(dgvStaff.SelectedRows[0].Cells["NhanVienID"].Value.ToString()))
                {
                    MessageBox.Show("Khôi phục mật khẩu thành công! Mật khẩu mới là 1");
                }
                else
                {
                    MessageBox.Show("Khôi phục mật khẩu không thành công! Vui lòng thử lại");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần khôi phục mật khẩu!");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string nhanvienid = dgvStaff.SelectedRows[0].Cells["NhanVienID"].Value.ToString();
                if (BLL_QLNV.Instance.GetQuyenHanByNhanVienID(nhanvienid) != -1)
                {
                    if (BLL_DangNhap.Instance.AddAccount(nhanvienid))
                    {
                        MessageBox.Show("Tạo tài khoản thành công!/n Tài khoản được tạo với mật khẩu mặc định là 1");
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản không thành công! Vui lòng thử lại");
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên này không thể tạo tài khoản!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần tạo tài khoản!");
            }
        }

        #endregion

        private void JustNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
