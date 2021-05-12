
using PBL.BLL;
using PBL.DAL;
using PBL.View;
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
            Load();
        }
        
        #region Load
        private void Load() 
        {
            LoadRoom();
            LoadDataGridView();
            LoadMenudv();
            txbDPMaNV.Text = IDNhanVien;
            txbCIMaNV.Text = IDNhanVien;
            txbMaNvOut.Text = IDNhanVien;
        } 
        private void LoadRoom() 
        { 
            List<PHONG> listRoom = BLL_QLP.Instance.GetListPhong();
            flpRom.Controls.Clear(); 
            foreach (PHONG item in listRoom) 
            { 
                Button btn = new Button() { Width = 100, Height = 100 }; 
                btn.Text = item.PhongID + Environment.NewLine + item.TrangThai;
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
            dgvDPKhachHang.DataSource= BLL_QLKH.Instance.GetAllKhachHang();
        }
        void LoadMenudv()
        {
            List<LOAIDICHVU> listloaidv = BLL_QLDV.Instance.GetAllDichVu();
            cbMenuDv.DataSource = listloaidv;
            cbMenuDv.DisplayMember = "TenDichVu";
        }
        #endregion 
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
            fMenuQuanLy f = new fMenuQuanLy();
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

        private void dgvCIKhachHang_Click(object sender, EventArgs e)
        {
            txbCIMaKhach.Text = dgvCIKhachHang.CurrentRow.Cells["KhachHangID"].Value.ToString();
        }

        private void dgvDPKhachHang_Click(object sender, EventArgs e)
        {
            txbDPMaKhach.Text = dgvDPKhachHang.CurrentRow.Cells["KhachHangID"].Value.ToString();
        }
        #region Button
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
            KHACHHANG s = new KHACHHANG()
            {
                Ten = txbKHHoTen.Text.Trim(),
                GioiTinh = ckbKHGioiTinh.Checked,
                GhiChu = txbKHGhiChu.Text.Trim(),
                QuocTich = txbKHQuocTich.Text.Trim(),
                CMND = txbKHCMND.Text.Trim(),
                SDT = txbKHSdt.Text.Trim(),
                // KhachHangID=""
            };
            BLL_QLKH.Instance.AddKh(s);
            LoadDataGridView();
            MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OK);

            ResetValuesKhachHang();

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

        #endregion

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
            //txbGia.Text = s.TienPhong.ToString();
            //Chỉ hiển thị giá phòng, không hiển thị tổng tiền phòng.
            txbTotalRoom.Text = s.TongTien.ToString();
            txbVatTu.Text = s.TienVatTu.ToString();
            txbtotalcheckout.Text = s.TienDichVu.ToString();
            LoadRoom();
        }

        private void itemTaiKhoan_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(IDNhanVien);
            f.ShowDialog();
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
            }
        }

        private void menuItemThongKe_Click(object sender, EventArgs e)
        {
            fThongKe f = new fThongKe();
            f.ShowDialog();
        }

        private void ItemHoaDon_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon(IDNhanVien);
            f.ShowDialog();
        }
    }

}
