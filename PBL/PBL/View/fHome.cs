using PBL.BLL;
using PBL.DAL;
using PBL.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PBL
{
    public partial class fHome : Form
    {
        private string IDBook;
        private string IDPhong;
        private string MaLoaiPhong;
        private string IDNhanVien;
        private string HoaDonID = "-1";
        public fHome(string username)
        {
            IDNhanVien = username;
            InitializeComponent();
            HomeLoad();
        }      
        #region Load
        private void HomeLoad() 
        {
            LoadRoom();
            LoadDataGridView();
            LoadMenudv();
            txbDPMaNV.Text = IDNhanVien;
            txbCIMaNV.Text = IDNhanVien;
            txbMaNvOut.Text = IDNhanVien;
            switch(BLL_QLNV.Instance.GetQuyenHanByNhanVienID(IDNhanVien))
            {
                case 1:
                    itemNhanVienVaChucVu.Enabled = false;
                    itemVatTu.Enabled = false;
                    itemQLTaiKhoan.Enabled = false;
                    menuItemThongKe.Enabled = false;
                    break;
                case 2:
                    itemMenuChinh.Enabled = false;
                    itemBook.Enabled = false;
                    itemVatTu.Enabled = false;
                    ItemHoaDon.Enabled = false;
                    itemQLTaiKhoan.Enabled = false;
                    menuItemThongKe.Enabled = false;
                    DisableButton();
                    break;
                case 3:
                    itemMenuChinh.Enabled = false;
                    itemBook.Enabled = false;
                    itemNhanVienVaChucVu.Enabled = false;
                    itemVatTu.Enabled = false;
                    itemQLTaiKhoan.Enabled = false;
                    DisableButton();
                    break;
                case 4:
                    menuItemThongKe.Enabled = false;
                    itemBook.Enabled = false;
                    itemNhanVienVaChucVu.Enabled = false;
                    ItemHoaDon.Enabled = false;
                    itemQLTaiKhoan.Enabled = false;
                    DisableButton();
                    break;
            }
        } 
        private void LoadRoom() 
        { 
            List<PHONG> listRoom = BLL_QLP.Instance.GetListPhong();
            flpRom.Controls.Clear(); 
            foreach (PHONG item in listRoom) 
            { 
                Button btn = new Button() { Width = 100, Height = 100 };
                string s= (!item.TrangThai) ?"Có người":"Trống";
                btn.Text = item.PhongID + Environment.NewLine + s;
                btn.Click += btn_Click;
                btn.Tag = item;
                if(item.TrangThai) 
                    btn.BackColor = Color.Aqua; 
                else 
                    btn.BackColor = Color.Red; 
                flpRom.Controls.Add(btn); 
            } 
        }
        private void LoadDataGridView()
        {
            dgvCIKhachHang.DataSource = BLL_QLKH.Instance.GetAllKhachHang();
            dgvCIKhachHang.Columns["BOOKs"].Visible = false;
            dgvCIKhachHang.Columns["BOOKs1"].Visible = false;
            dgvCIKhachHang.Columns["KhachHangID"].HeaderText = "Mã khách hàng";
            dgvCIKhachHang.Columns["Ten"].HeaderText = "Tên khách hàng";
            dgvCIKhachHang.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvCIKhachHang.Columns["SDT"].HeaderText = "SĐT";
            dgvCIKhachHang.Columns["QuocTich"].HeaderText = "Quốc tịch";
            dgvCIKhachHang.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgvDPKhachHang.DataSource= BLL_QLKH.Instance.GetAllKhachHang();
            dgvDPKhachHang.Columns["BOOKs"].Visible = false;
            dgvDPKhachHang.Columns["BOOKs1"].Visible = false;
            dgvDPKhachHang.Columns["KhachHangID"].HeaderText = "Mã khách hàng";
            dgvDPKhachHang.Columns["Ten"].HeaderText = "Tên khách hàng";
            dgvDPKhachHang.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDPKhachHang.Columns["SDT"].HeaderText = "SĐT";
            dgvDPKhachHang.Columns["QuocTich"].HeaderText = "Quốc tịch";
            dgvDPKhachHang.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
        private void LoadMenudv()
        {
            List<LOAIDICHVU> listloaidv = BLL_QLDV.Instance.GetAllDichVu();
            cbMenuDv.DataSource = listloaidv;
            cbMenuDv.DisplayMember = "TenDichVu";
        }
        #endregion 
        void ShowBill(String IDPhong)
        {
            lsvBillDichVu.Items.Clear();
            IDBook = BLL.BLL_QLBOOK.Instance.GetIdCheckinByIDRoom(IDPhong);
            List<HOADON_DUNG_DICHVU> listBillDv = BLL_QLDV.Instance.GetAllHoaDon(IDBook);
            float total = 0;
            foreach (HOADON_DUNG_DICHVU item in listBillDv)
            {
                ListViewItem lsvItems = new ListViewItem(item.LOAIDICHVU.TenDichVu.ToString());
                lsvItems.SubItems.Add(item.LOAIDICHVU.DonGia.ToString());
                lsvItems.SubItems.Add(item.SoLuong.ToString());
                lsvItems.SubItems.Add(item.Ngay.ToString());
                lsvItems.SubItems.Add(item.ThanhTien.ToString());
                total += (int)item.ThanhTien;
                lsvBillDichVu.Items.Add(lsvItems);
            }
            txbTotalBill.Text = total.ToString();
           
        }
        #region item_Click
        private void itemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void itemDoiMatKhau_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(IDNhanVien);
            f.ShowDialog();
        }
        private void itemNhanVienVaChucVu_Click(object sender, EventArgs e)
        {
            fStaffManager f = new fStaffManager();
            f.ShowDialog();
        }
        private void itemMenuChinh_Click(object sender, EventArgs e)
        {
            fMenuQuanLy f = new fMenuQuanLy(IDNhanVien);
            f.Send += new fMenuQuanLy.Delegate_fHome(LoadDataGridView);
            f.Send += new fMenuQuanLy.Delegate_fHome(LoadMenudv);
            f.ShowDialog();
        }
        private void itemVatTu_Click(object sender, EventArgs e)
        {
            fManageSupplies f = new fManageSupplies();
            f.ShowDialog();
        }
        private void itemDatPhong_Click(object sender, EventArgs e)
        {
            fBooking f = new fBooking();
            f.ShowDialog();
        }
        private void ItemNhanVien_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(IDNhanVien);
            f.ShowDialog();
        }
        private void ItemThongKe_Click(object sender, EventArgs e)
        {
            fThongKe f = new fThongKe();
            f.ShowDialog();
        }
        private void ItemHoaDon_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon(IDNhanVien);
            f.ShowDialog();
        }
        private void ItemTaiKhoan_Click(object sender, EventArgs e)
        {
            fQLTaiKhoan f = new fQLTaiKhoan();
            f.ShowDialog();
        }
        #endregion
        #region Reset

        private void ResetValuesKhachHang()
        {
            txbKHHoTen.Text = "";
            txbKHCMND.Text = "";
            txbKHQuocTich.Text = "";
            txbKHGhiChu.Text = "";
            txbKHSdt.Text = "";
        }
       
        
        private void ResetDatPhong()
        {
            txbDPMaPhong.Text = "";
            txbDPMaKhach.Text = "";
            dtpDPNgayDen.Value = DateTime.Now;
            dtpDPNgayDi.Value = DateTime.Now;
        }
        private void ResetCheckout()
        {
            txbMaPhongOut.Text = "";
            txbGia.Text = "";
            txbTotalBill.Text = "";
            txbtotalcheckout.Text = "";
            txbVatTu.Text = "";
            txbTotalRoom.Text = "";
        }
        private void ResetCheckin()
        {
            txbCIGhiChu.Text = "";
            txbCIMaKhach.Text = "";
            txbCIMaPhong.Text = "";
            dtbNgayDenThucTe.Value = DateTime.Now;
        }

        #endregion
        #region dgv
        private void dgvCIKhachHang_Click(object sender, EventArgs e)
        {
            txbCIMaKhach.Text = dgvCIKhachHang.CurrentRow.Cells["KhachHangID"].Value.ToString();
        }
        private void dgvDPKhachHang_Click(object sender, EventArgs e)
        {
            txbDPMaKhach.Text = dgvDPKhachHang.CurrentRow.Cells["KhachHangID"].Value.ToString();
        }
        #endregion
        #region Button
        void btn_Click(object sender, EventArgs e)
        {
            IDPhong = ((sender as Button).Tag as PHONG).PhongID;
            MaLoaiPhong = ((sender as Button).Tag as PHONG).LoaiPhongID;
            txbGia.Text = ((sender as Button).Tag as PHONG).LOAIPHONG.Gia.ToString();
            txbCIMaPhong.Text = IDPhong.ToString();
            txbMaPhongOut.Text = IDPhong.ToString();
            txbDPMaPhong.Text = IDPhong.ToString();
            TxbRoom.Text = ((sender as Button).Tag as PHONG).PhongID;
            ShowBill(IDPhong);
            if (IDBook == "-1")
                txbMaBook.Text = "";
            else
            {
                txbMaBook.Text = IDBook;
                dtpNgayDenOut.Value = BLL_QLBOOK.Instance.Find(IDBook).NgayCheckIn_ThucTe.Value;
            }
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            BOOK s = new BOOK()
            {
                KhachHangID = txbDPMaKhach.Text,
                NhanVienID = txbDPMaNV.Text,
                PhongID = txbDPMaPhong.Text,
                NgayCheckIn = dtpDPNgayDen.Value,
                NgayCheckOut=dtpDPNgayDen.Value,
                NgayDat = DateTime.Now
            };
            BLL_QLBOOK.Instance.AddDatPhong(s);
            LoadRoom();
            ResetDatPhong();
        }
        private void btnThemKh_Click(object sender, EventArgs e)
        {
            if (txbKHHoTen.Text.Trim() != "" && txbKHQuocTich.Text.Trim() != "" && txbKHCMND.Text.Trim() != "" && txbKHSdt.Text.Trim() != "")
            {
                KHACHHANG s = new KHACHHANG()
                {
                    Ten = txbKHHoTen.Text.Trim(),
                    GioiTinh = ckbKHGioiTinh.Checked,
                    GhiChu = txbKHGhiChu.Text.Trim(),
                    QuocTich = txbKHQuocTich.Text.Trim(),
                    CMND = txbKHCMND.Text.Trim(),
                    SDT = txbKHSdt.Text.Trim(),
                };
                BLL_QLKH.Instance.AddKh(s);
                LoadDataGridView();
                MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OK);

                ResetValuesKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            BOOK s = new BOOK()
            {
                KhachHangID = txbCIMaKhach.Text,
                NhanVienID = txbCIMaNV.Text,
                PhongID = txbCIMaPhong.Text,
                NgayCheckIn_ThucTe = dtbNgayDenThucTe.Value,
                NgayDat = DateTime.Now
            };
            BLL_QLBOOK.Instance.AddBook(s);
            LoadRoom();
            ResetCheckin();
        }
        private void btnDPReset_Click(object sender, EventArgs e)
        {
            ResetDatPhong();
        }
        private void btnCheckOutReset_Click(object sender, EventArgs e)
        {
            ResetCheckout();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCheckin();
        }
        private void btnThemDv_Click(object sender, EventArgs e)
        {
            if (NbSoLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxbRoom.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần thêm bill", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IDBook == "-1")
            {
                MessageBox.Show("Phòng chưa có khách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string madichvu = (cbMenuDv.SelectedItem as LOAIDICHVU).DichVuID;
            int soluong = (int)NbSoLuong.Value;
            string idBook = IDBook;
            DateTime ngaydat = DtNgayDat.Value;
            HOADON_DUNG_DICHVU them = new HOADON_DUNG_DICHVU()
            {
                DichVuID = madichvu,
                SoLuong = soluong,
                BookID = idBook,
                Ngay = ngaydat,
                NhanVienID = IDNhanVien
            };
            BLL_QLDV.Instance.AddDichVu(them);
            ShowBill(IDPhong);
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (IDBook == "-1")
            {
                MessageBox.Show("Phòng chưa checkin");
                return;
            }
            if(txbMaPhongOut.TextLength==0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần checkout");
                return;
            }    
            HOADON s = BLL_QLBOOK.Instance.Checkout(IDBook, dtpNgayDi.Value);
            HoaDonID = s.HoaDonID;
            txbTotalRoom.Text = s.TongTien.ToString();
            txbVatTu.Text = s.TienVatTu.ToString();
            txbtotalcheckout.Text = s.TienDichVu.ToString();
            LoadRoom();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (HoaDonID == "-1")
            {
                MessageBox.Show("Không có dữ liệu");
            }
            else
            {
                fBillDetail f = new fBillDetail(HoaDonID);
                f.ShowDialog();
                HoaDonID = "-1";
            }
        }

        #endregion
        #region Check
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8));
        }
        private void OnlyCharacter(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsLetter(e.KeyChar) && (e.KeyChar != 8) && (!Char.IsWhiteSpace(e.KeyChar)));
        }
        private void dtpNgayDi_ValueChanged(object sender, EventArgs e)
        {
            if (CheckNgayThang(dtpNgayDenOut.Value, dtpNgayDi.Value))
            {
                MessageBox.Show("Vui lòng nhập lại ngày đi");
                dtpNgayDi.Value = DateTime.Now;
            }
            
        }
        private void dtpDPNgayDi_ValueChanged(object sender, EventArgs e)
        {

            if (CheckNgayThang(dtpDPNgayDen.Value, dtpDPNgayDi.Value))
            {
                MessageBox.Show("Ngày đi không hợp lệ");
                dtpDPNgayDi.Value = DateTime.Now;
            }
          
        }
        private void dtpDPNgayDen_ValueChanged(object sender, EventArgs e)
        {
            if (CheckNgayThang(DateTime.Now, dtpDPNgayDen.Value))
            {
                MessageBox.Show("Ngày đến không hợp lệ");
                dtpDPNgayDen.Value = DateTime.Now;
            }
        }
        private bool CheckNgayThang(DateTime x, DateTime y)
        {
            return DateTime.Compare(x, y) > 0 ? true : false;
        }
        #endregion
        #region Disable Button
        private void DisableButton()
        {
            btnThemKh.Enabled = false;
            btnDatPhong.Enabled = false;
            btnCheckin.Enabled = false;
            btnThemDv.Enabled = false;
            btnCheckOut.Enabled = false;
            btnDetail.Enabled = false;
        }
        #endregion

        private void dgvDPKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDPKhachHang.Columns[e.ColumnIndex].Name == "GioiTinh")
            {
                if (e.Value != null)
                {
                    bool gender = Convert.ToBoolean(e.Value);
                    if (gender)
                    {
                        e.Value = "Nam";
                    }
                    else
                    {
                        e.Value = "Nữ";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvCIKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCIKhachHang.Columns[e.ColumnIndex].Name == "GioiTinh")
            {
                if (e.Value != null)
                {
                    bool gender = Convert.ToBoolean(e.Value);
                    if (gender)
                    {
                        e.Value = "Nam";
                    }
                    else
                    {
                        e.Value = "Nữ";
                    }
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
