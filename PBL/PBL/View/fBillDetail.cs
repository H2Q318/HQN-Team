using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;
using PBL.DAL;

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
            dgvRoomSupplies.DataSource = BLL_QLBill.Instance.BillRoomSupplies(HoaDonID);
            dgvService.DataSource = BLL_QLBill.Instance.BillService(HoaDonID);
            BOOK book = BLL_QLBOOK.Instance.Find(BLL_QLBill.Instance.FindHoaDon(HoaDonID).BookID);
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
