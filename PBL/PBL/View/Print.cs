using System;
using System.Diagnostics;
using System.Windows.Forms;
using PBL.BLL;

namespace PBL.View
{
    public partial class Print : Form
    {
        private string _hoadonid;
        private string tenks = " ";
        private string diachi = " ";
        private string tongdai = " ";
        private string website = " ";
        public Print(string hoadonid)
        {
            InitializeComponent();
            _hoadonid = hoadonid;
        }

        private void Print_Load(object sender, EventArgs e)
        {

            func_XemChiTietHoaDon_DichVu_ResultBindingSource.DataSource = BLL_QLBill.Instance.BillService(_hoadonid);
            func_XemChiTietHoaDon_VatTu_Result1BindingSource.DataSource = BLL_QLBill.Instance.BillRoomSupplies(_hoadonid);
            rpHoaDon.LocalReport.SetParameters(BLL_QLBill.Instance.GetListReportParameters(_hoadonid, tenks, diachi, tongdai, website));
            this.rpHoaDon.RefreshReport();
        }
    }
}
