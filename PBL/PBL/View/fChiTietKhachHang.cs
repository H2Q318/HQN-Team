using PBL.BLL;
using PBL.DAL;
using System.Windows.Forms;

namespace PBL
{
    public partial class fChiTietKhachHang : Form
    {
        private string KhachHangID { get; set; }
        public fChiTietKhachHang(string id)
        {
            InitializeComponent();
            KhachHangID = id;
            GUI();
        }
        private void GUI()
        {
            KHACHHANG kh = BLL_QLKH.Instance.FindKh(KhachHangID);
            txbMaKH.Text = kh.KhachHangID;
            txbTenKH.Text = kh.Ten;
            txbGender.Text = (bool)kh.GioiTinh ? "Nam" : "Nữ";
            txbCMND.Text = kh.CMND;
            txbSDT.Text = kh.SDT;
            txbQuocTich.Text = kh.QuocTich;
            txbNote.Text = kh.GhiChu;
        }
    }
}
