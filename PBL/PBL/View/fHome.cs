
using PBL.BLL;
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
    public partial class fHome : Form
    {
        String IDBook;
        String IDPhong;
        String MaLoaiPhong;
        float TotalRoom = 0;
        public fHome()
        {
            InitializeComponent();
            Load();

        }
        #region Load
        private void Load() 
        {
            LoadRoom();
            LoadDataGridView();
        } 
        private void LoadRoom() 
        { 
            List<PHONG> listRoom = BLL_QLP.Instance.GetListPhong();
            flpRom.Controls.Clear(); 
            foreach (PHONG item in listRoom) 
            { Button btn = new Button() { Width = 100, Height = 100 }; 
                btn.Text = item.PhongID + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                if(item.TrangThai) 
                    btn.BackColor = Color.Aqua; 
                else 
                    btn.BackColor = Color.Red; flpRom.Controls.Add(btn); 
            } 
        }
        private void LoadDataGridView()
        {
            dgvCIKhachHang.DataSource = BLL_QLKH.Instance.GetAllKhachHang();
            dgvDPKhachHang.DataSource= BLL_QLKH.Instance.GetAllKhachHang();
        }
        #endregion 
        void btn_Click(object sender, EventArgs e) 
        {
            IDPhong = ((sender as Button).Tag as PHONG).PhongID;
            MaLoaiPhong = ((sender as Button).Tag as PHONG).LoaiPhongID;
            TotalRoom = 0;
            txbGia.Text = ((sender as Button).Tag as PHONG).LOAIPHONG.Gia.ToString();
            TotalRoom += Convert.ToInt32(((sender as Button).Tag as PHONG).LOAIPHONG.Gia);
            txbCIMaPhong.Text = IDPhong.ToString();
            txbMaPhongOut.Text = IDPhong.ToString();
            TxbRoom.Text = ((sender as Button).Tag as PHONG).PhongID;
            ShowBill(IDPhong);
            if (true)
                txbMaKhachOut.Text = "";
           // else
               // txbMaKhachOut.Text = CheckinDAO.Instance.MaKhach.ToString();
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
            TotalRoom += total;
            txbTotalRoom.Text = TotalRoom.ToString();
            txbTotalBill.Text = total.ToString();
            txbtotalcheckout.Text = total.ToString();
        }
        private void itemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemDoiMatKhau_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword();
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

        private void btnCheckin_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void itemDatPhong_Click(object sender, EventArgs e)
        {
            fBooking f = new fBooking();
            f.ShowDialog();
        }

        private void itemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKh_Click(object sender, EventArgs e)
        {
            KHACHHANG s = new KHACHHANG()
            {   Ten=txbKHHoTen.Text.Trim(),
                GioiTinh=ckbKHGioiTinh.Checked,
                GhiChu= txbKHGhiChu.Text.Trim(),
                QuocTich=txbKHQuocTich.Text.Trim(),
                CMND= txbKHCMND.Text.Trim(),
                SDT= MsbKHDienThoai.Text.Trim() ,
                KhachHangID=""
            };
                BLL_QLKH.Instance.AddKh(s);
                LoadDataGridView();
               // MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OK);
            
            ResetValuesKhachHang();
        }
        #region Reset
       
        private void ResetValuesKhachHang()
        {
            txbKHHoTen.Text = "";
            txbKHCMND.Text = "";
            txbKHQuocTich.Text = "";
            txbKHGhiChu.Text = "";
            MsbKHDienThoai.Text = "";
        }
        #endregion
    }

}
