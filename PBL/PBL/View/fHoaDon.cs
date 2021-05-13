using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PBL.BLL;

namespace PBL.View
{
    public partial class fHoaDon : Form
    {
        private string NhanVienID;
        public fHoaDon(string nhanvienid)
        {
            InitializeComponent();
            NhanVienID = nhanvienid;
            GUI();
        }
        private void GUI()
        {
            ShowDGVHoaDon();
            cbbSort.Items.AddRange(new string[] {"Mã book", "Tổng tiền phòng","Tổng tiền dịch vụ", 
                                                 "Tổng tiền vật tư", "Tổng tiền", "Ngày thanh toán"});
        }
        private void ShowDGVHoaDon(string bookid = null)
        {
            dgvHoaDon.DataSource = BLL_QLBill.Instance.GetListHoaDon(bookid);
            dgvHoaDon.Columns["BOOK"].Visible = false;
            dgvHoaDon.Columns["HoaDonID"].Visible = false;
        }
        private void lbReset_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDGVHoaDon(txbSearch.Text);
        }
        private List<string> GetListDGVHoaDonID()
        {
            List<string> data = new List<string>();
            foreach(DataGridViewRow r in dgvHoaDon.SelectedRows)
            {
                data.Add(r.Cells["HoaDonID"].Value.ToString());
            }
            return data;
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                BLL_QLBill.Instance.DeleteHoaDon(GetListDGVHoaDonID());
            }
            else
            {
                MessageBox.Show("Chọn ít nhất một dòng để xoá !");
            }
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 1)
            {
                fBillDetail f = new fBillDetail(dgvHoaDon.SelectedRows[0].Cells["HoaDonID"].Value.ToString());
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn duy nhất một dòng để xem.");
            }
                
        }
        private List<string> GetAllHoaDonID()
        {
            List<string> data = new List<string>();
            foreach(DataGridViewRow r in dgvHoaDon.Rows)
            {
                data.Add(r.Cells["HoaDonID"].Value.ToString());
            }
            return data;
        }

        private void cbbSort_DropDownClosed(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex != -1)
            {    
                dgvHoaDon.DataSource = BLL_QLBill.Instance.Sort(cbbSort.SelectedItem.ToString(), GetAllHoaDonID());
                dgvHoaDon.Columns["BOOK"].Visible = false;
                dgvHoaDon.Columns["HoaDonID"].Visible = false;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbbSort.SelectedIndex = -1;
            ShowDGVHoaDon();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDGVHoaDon(txbSearch.Text);
        }
    }
}
