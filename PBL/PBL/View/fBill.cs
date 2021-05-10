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
    public partial class fBill : Form
    {
        private string IDNhanVien;
        public fBill(string username)
        {
            InitializeComponent();
            IDNhanVien = username;
        }
    }
}
