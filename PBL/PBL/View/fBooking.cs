using PBL.BLL;
using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
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
            cbbFilterBook.SelectedIndex = 0;
            cbbSortBook.SelectedIndex = 0;
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
            cbSearch.SelectedIndex = 0;
            txbSearch.Clear();
            ShowDgvBooking();
        }
        private void RefreshKhachHang()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.Rows.Clear();
            btnDetail.Enabled = false;
            btXoaKH.Enabled = false;
        }
        private void ShowDgvBooking()
        {
            dgvBooking.DataSource = BLL_QLBOOK.Instance.GetAllBook();
            dgvBooking.Columns["KhachHangID"].Visible = false;
            dgvBooking.Columns["NhanVienID"].Visible = false;
            dgvBooking.Columns["BookID"].HeaderText = "Mã Book";
            dgvBooking.Columns["PhongID"].HeaderText = "Phòng";
            dgvBooking.Columns["TenKhachHang"].HeaderText = "Tên khách";
            dgvBooking.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvBooking.Columns["NgayDat"].HeaderText = "Ngày đặt";
            dgvBooking.Columns["NgayCheckIn"].HeaderText = "Ngày check in";
            dgvBooking.Columns["NgayCheckOut"].HeaderText = "Ngày check out";
            dgvBooking.Columns["NgayCheckIn_ThucTe"].HeaderText = "Ngày check in thực tế";
            dgvBooking.Columns["NgayCheckOut_ThucTe"].HeaderText = "Ngày check out thực tế";
            dgvBooking.Columns["ThanhToan"].HeaderText = "Thanh toán";
        }
        private void ShowDGVKhachHang()
        {
            BOOK b = BLL_QLBOOK.Instance.Find(dgvBooking.SelectedRows[0].Cells["BookID"].Value.ToString());
            dgvKhachHang.DataSource = b.KHACHHANGs.ToList();
            dgvKhachHang.Columns["KhachHangID"].Visible = false;
            dgvKhachHang.Columns["BOOKs"].Visible = false;
            dgvKhachHang.Columns["BOOKs1"].Visible = false;
            dgvKhachHang.Columns["Ten"].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvKhachHang.Columns["SDT"].HeaderText = "SĐT";
            dgvKhachHang.Columns["QuocTich"].HeaderText = "Quốc tịch";
            dgvKhachHang.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                if (BLL_QLBOOK.Instance.UpdateDatPhong(b))
                {
                    MessageBox.Show("Đã cập nhật !");
                    RefreshBook();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin !");
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
                if (dgvBooking.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Chỉ được xoá mỗi lần một Book, vui lòng chọn lại !");
                }
                else
                {
                    if (BLL_QLBOOK.Instance.DeleteDatPhong(dgvBooking.SelectedRows[0].Cells["BookID"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xoá đơn đặt phòng !");
                        RefreshBook();
                        RefreshKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng xoá các hoá đơn dịch vụ và hoá đơn liên quan trước khi xoá đơn đặt phòng này !");
                    }
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
            RefreshKhachHang();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                fChiTietKhachHang f = new fChiTietKhachHang(dgvKhachHang.SelectedRows[0].Cells["KhachHangID"].Value.ToString());
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xem chi tiết!");
            }
        }

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDGVKhachHang();

            BOOK book = BLL_QLBOOK.Instance.Find(dgvBooking.SelectedRows[0].Cells["BookID"].Value.ToString());
            txbBookID.Text = book.BookID;
            txbTenNhanVien.Text = book.NHANVIEN.Ten;
            txbPhongID.Text = book.PhongID;
           
            LOAIPHONG lp = BLL_QLLP.Instance.FindLoaiPhongByID(BLL_QLP.Instance.FindPhong(txbPhongID.Text).LoaiPhongID);
            txbLoaiPhong.Text = lp.TenLoaiPhong;
            txbGia.Text = lp.Gia.ToString();
            dtpNgayDat.Value = book.NgayDat;

            if (book.NgayCheckIn != null)
            {
                dtpNgayDen.CustomFormat = "dd/MM/yyyy";
                dtpNgayDen.Value = (DateTime)book.NgayCheckIn;
            }
            else
            {
                dtpNgayDen.CustomFormat = " ";
            }

            if (book.NgayCheckOut != null)
            {
                dtpNgayDi.CustomFormat = "dd/MM/yyyy";
                dtpNgayDi.Value = (DateTime)book.NgayCheckOut;
            }
            else
            {
                dtpNgayDi.CustomFormat = " ";
            }

            if (book.NgayCheckIn_ThucTe != null)
            {
                dtpCheckIn.CustomFormat = "dd/MM/yyyy hh:mm tt";
                dtpCheckIn.Value = (DateTime)book.NgayCheckIn_ThucTe;
            }
            else
            {
                dtpCheckIn.CustomFormat = " ";
            }

            if (book.NgayCheckOut_ThucTe != null)
            {
                dtpCheckOut.CustomFormat = "dd/MM/yyyy hh:mm tt";
                dtpCheckOut.Value = (DateTime)book.NgayCheckOut_ThucTe;
                // không cho cập nhật Book đã thanh toán
                btnUpdate.Enabled = false;
                // ẩn luôn nút xoá khách hàng
                btXoaKH.Enabled = false;
            }
            else
            {
                dtpCheckOut.CustomFormat = " ";
                // enable lại btUpdate
                btnUpdate.Enabled = true;
                btXoaKH.Enabled = true;
            }

            txbThanhToan.Text = book.ThanhToan.ToString();
        }   

        private void dgvBooking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBooking.ClearSelection();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btXoaKH.Enabled = true;
            btnDetail.Enabled = true;
        }
        private List<string> GetDGVKhachHangID()
        {
            List<string> data = new List<string>();
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow r in dgvKhachHang.SelectedRows)
                {
                    data.Add(r.Cells["KhachHangID"].Value.ToString());
                }
            }
            return data;
        }
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            int n = dgvKhachHang.Rows.Count - dgvKhachHang.SelectedRows.Count;
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một khách hàng để xoá !");
            }
            else if (n > 0)
            {
                if (!BLL_QLBOOK.Instance.DeleteKhachHangFromBook(GetDGVKhachHangID(), txbBookID.Text.Trim(), false))
                {
                    MessageBox.Show("Không thể xoá khách hàng đã đặt Book này ra khỏi Book này !");
                }
                ShowDGVKhachHang();
            }
            else
            {
                MessageBox.Show("Không thể xoá khách hàng này ra khỏi danh sách.\n" +
                    "Nếu muốn xoá Book, vui lòng chọn nút xoá bên phần thông tin Book !");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex != -1)
            {
                dgvBooking.DataSource = BLL_QLBOOK.Instance.SearchBook(txbSearch.Text.Trim(), cbSearch.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần tìm kiếm trước !");
            }
        }

        private void dgvKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKhachHang.ClearSelection();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void cbbLocBook_DropDownClosed(object sender, EventArgs e)
        {
            dgvBooking.DataSource = BLL_QLBOOK.Instance.FilterBook(cbbFilterBook.SelectedItem.ToString());
        }
        private List<string> GetAllBookID()
        {
            List<string> data = new List<string>();
            foreach(DataGridViewRow r in dgvBooking.Rows)
            {
                data.Add(r.Cells["BookID"].Value.ToString());
            }
            return data;
        }
        private void cbbSortBook_DropDownClosed(object sender, EventArgs e)
        {
            dgvBooking.DataSource = BLL_QLBOOK.Instance.Sort(cbbSortBook.SelectedItem.ToString(), GetAllBookID());
        }
    }
}
