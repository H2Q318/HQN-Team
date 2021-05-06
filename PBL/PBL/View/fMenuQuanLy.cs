using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.DTO;

namespace PBL
{
    public partial class fMenuQuanLy : Form
    {
        public fMenuQuanLy()
        {
            InitializeComponent();
        }
        private void GUI()
        {
            ShowDGVPhong();
        }
        private void ShowDGVPhong()
        {
            dgvPhong.DataSource = BLL_QLP.Instance.GetAllPhong();
        }
        private void btnSeachBill_Click(object sender, EventArgs e)
        {

        }

        private void BtnResetSBill_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPh_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG p = new PHONG
                {
                    LoaiPhongID = ((CBBItem)cbTenLoaiPhong.SelectedItem).Value,
                    TrangThai = rbtAvailable.Checked
                };
                BLL_QLP.Instance.AddPhong(p);
                ShowDGVPhong();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui long nhap day du va dung kieu du lieu cua thong tin !");
            }
            
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
