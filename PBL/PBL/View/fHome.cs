
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
    public partial class fHome : Form
    {       
        public fHome()
        {
            InitializeComponent();
            

        }

        private void itemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemDoiMatKhau_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword();
            f.ShowDialog();
        }

        private void itemNhanVienVaChucVu_Click(object sender, EventArgs e)
        {
            fStaffManager f = new fStaffManager();
            f.ShowDialog();
        }

        private void itemMenuChinh_Click(object sender, EventArgs e)
        {
            fMenuQuanLy f = new fMenuQuanLy();
            f.ShowDialog();
        }

        private void itemVatTu_Click(object sender, EventArgs e)
        {
            fManageSupplies f = new fManageSupplies();
            f.ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void itemDatPhong_Click(object sender, EventArgs e)
        {
            fBooking f = new fBooking();
            f.ShowDialog();
        }
    }
   
}
