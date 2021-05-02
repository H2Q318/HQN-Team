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
    public partial class fTableManager : Form
    {
       
        public fTableManager()
        {
            InitializeComponent();
          //  customizeDesign();
           
        }
        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void customizeDesign()
        {
            panelPersonalSubMenu.Visible = false;
            panelRoomSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPersonalSubMenu.Visible == true)
                panelPersonalSubMenu.Visible = false;
            if (panelRoomSubMenu.Visible == true)
                panelRoomSubMenu.Visible = false;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            customizeDesign();
        }

        
    }
}
