using System;
using System.Configuration;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class HotelInfoSetting : Form
    {
        public HotelInfoSetting()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            lbThongBao.Visible = false;
            tbTenKhachSan.Text = ConfigurationManager.AppSettings.Get("TenKhachSan");
            tbDiaChi.Text = ConfigurationManager.AppSettings.Get("DiaChi");
            tbLienHe.Text = ConfigurationManager.AppSettings.Get("LienHe");
            tbWebsite.Text = ConfigurationManager.AppSettings.Get("Website");
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings.Set("TenKhachSan", tbTenKhachSan.Text);
            ConfigurationManager.AppSettings.Set("DiaChi", tbDiaChi.Text);
            ConfigurationManager.AppSettings.Set("LienHe", tbLienHe.Text);
            ConfigurationManager.AppSettings.Set("Website", tbWebsite.Text);
            lbThongBao.Visible = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
