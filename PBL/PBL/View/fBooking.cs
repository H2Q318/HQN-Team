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
    public partial class fBooking : Form
    {
        
        public fBooking()
        {
            InitializeComponent();
            GUI();
        }

        private void GUI()
        {
            ShowDgvBooking();
            cbSearch.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
        }

        private void RefreshBook()
        {
            txbBookID.Clear();
            txbTenNhanVien.Clear();
            txbPhongID.Clear();
            txbLoaiPhong.Clear();
            txbGia.Clear();
            dtpNgayDat.Value = DateTime.Now;
            dtpNgayDen.Value = DateTime.Now;
            dtpNgayDi.Value = DateTime.Now;
            dtpCheckIn.CustomFormat = " ";
            dtpCheckOut.CustomFormat = " ";
            txbThanhToan.Clear();
            txbMaKH.Clear();
            txbTenKH.Clear();
            cbGioiTinh.SelectedIndex = 0;
            txbCMND.Clear();
            txbSDT.Clear();
            txbQuocTich.Clear();
            txbNote.Clear();
            cbSearch.SelectedIndex = 0;
            txbSearch.Clear();
            ShowDgvBooking();
        }

        private void ShowDgvBooking()
        {
            dgvBooking.DataSource = BLL_QLBOOK.Instance.GetAllBook();
            dgvBooking.Columns["KhachHangID"].Visible = false;
            dgvBooking.Columns["NhanVienID"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTenKH.TextLength != 0 && txbCMND.TextLength != 0 && txbSDT.TextLength != 0 && txbQuocTich.TextLength != 0)
                {
                    BOOK b = new BOOK
                    {
                        BookID = dgvBooking.SelectedRows[0].Cells["BookID"].Value.ToString(),
                        NgayDat = (DateTime)dtpNgayDat.Value,
                        NgayCheckIn = (DateTime)dtpNgayDen.Value,
                        NgayCheckOut = (DateTime)dtpNgayDi.Value,
                        NgayCheckIn_ThucTe = (DateTime)dtpCheckIn.Value,
                        NgayCheckOut_ThucTe = (DateTime)dtpCheckOut.Value
                    };
                    KHACHHANG kh = new KHACHHANG
                    {
                        KhachHangID = txbMaKH.Text,
                        Ten = txbTenKH.Text,
                        GioiTinh = (cbGioiTinh.SelectedIndex == 0) ? true : false,
                        CMND = txbCMND.Text,
                        SDT = txbSDT.Text,
                        QuocTich = txbQuocTich.Text,
                        GhiChu = txbNote.Text
                    };
                    if (BLL_QLBOOK.Instance.UpdateDatPhong(b) && BLL_QLKH.Instance.UpdateKh(kh))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        RefreshBook();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng cần cập nhật!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_QLBOOK.Instance.DeleteDatPhong(dgvBooking.SelectedRows[0].Cells["BookID"].Value.ToString()))
                {
                    MessageBox.Show("Xóa đơn đặt phòng thành công!");
                    RefreshBook();
                }
                else
                {
                    MessageBox.Show("Xóa đơn đặt phòng không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng cần xóa!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshBook();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = dgvBooking.SelectedRows[0];
            txbBookID.Text = data.Cells["BookID"].Value.ToString();
            txbTenNhanVien.Text = data.Cells["TenNhanVien"].Value.ToString();
            txbPhongID.Text = data.Cells["PhongID"].Value.ToString();
           
            LOAIPHONG lp = BLL_QLLP.Instance.FindLoaiPhongByID(BLL_QLP.Instance.FindPhong(txbPhongID.Text).LoaiPhongID);
            txbLoaiPhong.Text = lp.TenLoaiPhong;
            txbGia.Text = lp.Gia.ToString();
            dtpNgayDat.Value = (DateTime)data.Cells["NgayDat"].Value;
            dtpNgayDen.Value = (DateTime)data.Cells["NgayCheckIn"].Value;
            dtpNgayDi.Value = (DateTime)data.Cells["NgayCheckOut"].Value;

            if (data.Cells["NgayCheckIn_ThucTe"].Value != null)
            {
                dtpCheckIn.CustomFormat = "dd/MM/yyyy hh:mm tt";
                dtpCheckIn.Value = (DateTime)data.Cells["NgayCheckIn_ThucTe"].Value;
            }
            else
            {
                dtpCheckIn.CustomFormat = " ";
            }

            if (data.Cells["NgayCheckOut_ThucTe"].Value != null)
            {
                dtpCheckOut.CustomFormat = "dd/MM/yyyy hh:mm tt";
                dtpCheckOut.Value = (DateTime)data.Cells["NgayCheckOut_ThucTe"].Value;
            }
            else
            {
                dtpCheckOut.CustomFormat = " ";
            }

            txbThanhToan.Text = data.Cells["ThanhToan"].Value.ToString();
            txbMaKH.Text = data.Cells["KhachHangID"].Value.ToString();

            KHACHHANG kh = BLL_QLKH.Instance.FindKh(txbMaKH.Text);
            txbTenKH.Text = kh.Ten;
            cbGioiTinh.SelectedIndex = (kh.GioiTinh == true) ? 0 : 1;
            txbCMND.Text = kh.CMND;
            txbSDT.Text = kh.SDT;
            txbQuocTich.Text = kh.QuocTich;
            txbNote.Text = kh.GhiChu;
        }   

        private void dgvBooking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBooking.ClearSelection();
        }
    }
}
