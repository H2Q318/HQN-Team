using System;
using System.Linq;
using System.Windows.Forms;
using PBL.BLL;
using PBL.DAL;
using PBL.View;

namespace PBL
{
    public partial class fBillDetail : Form
    {
        private string HoaDonID;
        public fBillDetail(string hoadonid)
        {
            InitializeComponent();
            HoaDonID = hoadonid;
            GUI();
        }
        private void GUI()
        {
            ShowDGVRoomSupplie();
            ShowDGVService();
            BOOK book = BLL_QLBOOK.Instance.Find(BLL_QLBill.Instance.FindHoaDon(HoaDonID).BookID);
            txbMaHoaDon.Text = HoaDonID;
            txbCustomer.Text = book.KHACHHANG.Ten;
            txbGender.Text = (bool)book.KHACHHANG.GioiTinh ? "Nam" : "Nữ";
            txbSDT.Text = book.KHACHHANG.SDT;
            txbCMND.Text = book.KHACHHANG.CMND;
            txbStaff.Text = book.NHANVIEN.Ten;
            txbNgayDat.Text = book.NgayDat.ToString();
            txbCheckIn.Text = book.NgayCheckIn_ThucTe.ToString();
            txbCheckOut.Text = book.NgayCheckOut_ThucTe.ToString();
            txbRoomCost.Text = book.HOADONs.ToList()[0].TienPhong.ToString();
            txbServicesCost.Text = book.HOADONs.ToList()[0].TienDichVu.ToString();
            txbSuppliesCost.Text = book.HOADONs.ToList()[0].TienVatTu.ToString();
            txbTotal.Text = book.HOADONs.ToList()[0].TongTien.ToString();
        }
        private void ShowDGVRoomSupplie()
        {
            dgvRoomSupplies.DataSource = BLL_QLBill.Instance.BillRoomSupplies(HoaDonID);
            dgvRoomSupplies.Columns["TenVatDung"].HeaderText = "Tên vật dụng";
            dgvRoomSupplies.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvRoomSupplies.Columns["SoLuongHu"].HeaderText = "Số lượng hư";
        }
        private void ShowDGVService()
        {
            dgvService.DataSource = BLL_QLBill.Instance.BillService(HoaDonID);
            dgvService.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvService.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvService.Columns["TongSoLuong"].HeaderText = "Số lượng";
            dgvService.Columns["TongThanhTien"].HeaderText = "Thành tiền";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print f = new Print(HoaDonID);
            f.Show();
        }
    }
}
