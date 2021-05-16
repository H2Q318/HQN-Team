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
    public partial class fChiTietKhachHang : Form
    {
        private string IDKhachHang { get; set; }
        public fChiTietKhachHang(string khachHangId)
        {
            InitializeComponent();
            IDKhachHang = khachHangId;
            GUI();
        }
        private void GUI()
        {
            KHACHHANG kh = BLL_QLKH.Instance.FindKh(IDKhachHang);
            txbMaKH.Text = IDKhachHang;
            txbTenKH.Text = kh.Ten;
            cbGioiTinh.SelectedIndex = (kh.GioiTinh == true) ? 0 : 1;
            txbCMND.Text = kh.CMND;
            txbSDT.Text = kh.SDT;
            txbQuocTich.Text = kh.QuocTich;
            txbNote.Text = kh.GhiChu;
        }
    }
}
