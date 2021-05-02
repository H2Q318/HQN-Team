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
    public partial class fChangePassword : Form
    {
        
        public fChangePassword()
        {
            InitializeComponent();
            
        }

        private void btnNotUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearInfor()
        {
            txbOldPassword.Clear();
            txbNewPassword.Clear();
            txbNewPasswordAgain.Clear();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
