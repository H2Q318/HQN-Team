using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
            Timer MyTimer = new Timer
            {
                Interval = 2000
            };
            MyTimer.Tick += new EventHandler(Timer_Tick);
            MyTimer.Start();
        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            GUI();
        }
        private void GUI()
        {
            ShowdgvAccount();
        }
        private void ShowdgvAccount()
        {
            dgvAccount.DataSource = BLL_DangNhap.Instance.GetListAccount_View();
            dgvAccount.Columns["TrangThai"].Visible = false;
        }
        private void ShowDGVLog(string nhanvienid)
        {
            dgvLog.DataSource = BLL_DangNhap.Instance.GetListLichSuDangNhap(nhanvienid);
            dgvLog.Columns["NHANVIEN"].Visible = false;
            dgvLog.Columns["NhanVienID"].Visible = false;
        }

        private void dgvAccount_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)dgvAccount.Rows[e.RowIndex].Cells["TrangThai"].Value == true)
            {
                dgvAccount.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SpringGreen;
            }
        }

        private void dgvAccount_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAccount.ClearSelection();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDGVLog(dgvAccount.SelectedRows[0].Cells["NhanVienID"].Value.ToString());
        }
    }
}
