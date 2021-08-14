using System;
using System.Configuration;
using System.Windows.Forms;
using PBL.BLL;

namespace PBL.View
{
    public partial class Print : Form
    {
        private string _hoadonid;
        private string tenks = ConfigurationManager.AppSettings.Get("TenKhachSan");
        private string diachi = ConfigurationManager.AppSettings.Get("DiaChi");
        private string lienhe = ConfigurationManager.AppSettings.Get("LienHe");
        private string website = ConfigurationManager.AppSettings.Get("Website");
        public Print(string hoadonid)
        {
            InitializeComponent();
            _hoadonid = hoadonid;
        }

        private void Print_Load(object sender, EventArgs e)
        {

            func_XemChiTietHoaDon_DichVu_ResultBindingSource.DataSource = BLL_QLBill.Instance.BillService(_hoadonid);
            func_XemChiTietHoaDon_VatTu_Result1BindingSource.DataSource = BLL_QLBill.Instance.BillRoomSupplies(_hoadonid);
            rpHoaDon.LocalReport.SetParameters(BLL_QLBill.Instance.GetListReportParameters(_hoadonid, tenks, diachi, lienhe, website));
            this.rpHoaDon.RefreshReport();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            HotelInfoSetting f = new HotelInfoSetting();
            f.Show();
        }
    }
}
