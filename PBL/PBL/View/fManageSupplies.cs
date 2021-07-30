using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PBL.BLL;
using PBL.DAL;
using PBL.DTO;

namespace PBL
{
    public partial class fManageSupplies : Form
    {
        public fManageSupplies()
        {
            InitializeComponent();
            GUIVatDungPhong();
        }
        #region Quản lý vật dụng phòng
        private void GUIVatDungPhong()
        {
            foreach(PHONG p in BLL_QLP.Instance.GetListPhong(null))
            {
                cbPhongID.Items.Add(p.PhongID);
            }
            foreach(LOAIVATDUNG i in BLL_QLVD.Instance.GetListLoaiVatDung(null))
            {
                cbTenVatTu.Items.Add(new CBBItem { Text = i.TenVatDung, Value = i.VatDungID });
            }
            foreach(TRANGTHAIVATDUNG i in BLL_QLTTVD.Instance.GetListTrangThaiVatDung())
            {
                cbTrangThai.Items.Add(i.TrangThaiVatDungID);
            }
            cbPhongID.SelectedIndex = 0;
            cbTenVatTu.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            ShowDGVVatDungPhong(null);
        }
        private void ShowDGVVatDungPhong(string s)
        {
            dgvVatDungPhong.DataSource = BLL_QLVDP.Instance.GetListVatDungPhong_View(BLL_QLVDP.Instance.GetListVatDungPhong(s));
            dgvVatDungPhong.Columns["VatDungID"].Visible = false;
            dgvVatDungPhong.Columns["Phong"].HeaderText = "Phòng";
            dgvVatDungPhong.Columns["TenVatDung"].HeaderText = "Tên vật dụng";
            dgvVatDungPhong.Columns["SoLuongBanDau"].HeaderText = "Số lượng ban đầu";
            dgvVatDungPhong.Columns["SoLuongHienTai"].HeaderText = "Số lượng hiện tại";
            dgvVatDungPhong.Columns["TrangThai"].HeaderText = "Trạng thái";
        }
        private List<DTO.Keys> GetListVatDungPhongID()
        {
            List<DTO.Keys> data = new List<DTO.Keys>();
            foreach(DataGridViewRow r in dgvVatDungPhong.SelectedRows)
            {
                data.Add(new DTO.Keys
                {
                    key1 = r.Cells["Phong"].Value.ToString(),
                    key2 = r.Cells["VatDungID"].Value.ToString(),
                });
            }
            return data;
        }
        private void btnThemVt_Click(object sender, EventArgs e)
        {
            if (BLL_QLVDP.Instance.FindVatDungPhong(new DTO.Keys
            {
                key1 = cbPhongID.SelectedItem.ToString(),
                key2 = ((CBBItem)cbTenVatTu.SelectedItem).Value
            }) != null)
            {
                MessageBox.Show("Đã tồn tại vật dụng này trong phòng !");
            }
            else
            {
                try
                {
                    VATDUNGPHONG vdp = new VATDUNGPHONG
                    {
                        PhongID = cbPhongID.SelectedItem.ToString(),
                        VatDungID = ((CBBItem)cbTenVatTu.SelectedItem).Value,
                        SoLuongBanDau = Convert.ToInt32(nUDSLBanDau.Value),
                        SoLuongHienTai = Convert.ToInt32(nUDSLHienTai.Value),
                        TrangThaiVatDungID = cbTrangThai.SelectedItem.ToString()
                    };
                    BLL_QLVDP.Instance.AddVatDungPhong(vdp);
                    ShowDGVVatDungPhong(null);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin và kiểu dữ liệu !");
                }
            }
        }

        private void BtnSuaVt_Click(object sender, EventArgs e)
        {
            if (BLL_QLVDP.Instance.FindVatDungPhong(new DTO.Keys
            {
                key1 = cbPhongID.SelectedItem.ToString(),
                key2 = ((CBBItem)cbTenVatTu.SelectedItem).Value
            }) == null)
            {
                MessageBox.Show("Vật dụng này không tồn tại trong phòng để cập nhật !");
            }
            else
            {
                try
                {
                    VATDUNGPHONG vdp = new VATDUNGPHONG
                    {
                        PhongID = cbPhongID.SelectedItem.ToString(),
                        VatDungID = ((CBBItem)cbTenVatTu.SelectedItem).Value,
                        SoLuongBanDau = Convert.ToInt32(nUDSLBanDau.Value),
                        SoLuongHienTai = Convert.ToInt32(nUDSLHienTai.Value),
                        TrangThaiVatDungID = cbTrangThai.SelectedItem.ToString()
                    };
                    BLL_QLVDP.Instance.UpdateVatDungPhong(vdp);
                    ShowDGVVatDungPhong(null);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin và kiểu dữ liệu !");
                }
            }
        }

        private void BtnXoaVt_Click(object sender, EventArgs e)
        {
            BLL_QLVDP.Instance.DeleteVatDungPhong(GetListVatDungPhongID());
            ShowDGVVatDungPhong(null);
        }

        private void btnResetVt_Click(object sender, EventArgs e)
        {
            cbPhongID.SelectedIndex = 0;
            cbTenVatTu.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            nUDSLBanDau.Value = 0;
            nUDSLHienTai.Value = 0;
        }

        private void BtnSeachPhong_Click(object sender, EventArgs e)
        {
            ShowDGVVatDungPhong(txbSeachPhong.Text.Trim());
        }

        private void btnResetSPhong_Click(object sender, EventArgs e)
        {
            txbSeachPhong.Clear();
            ShowDGVVatDungPhong(null);
        }
        private int cbTenVatTuIndexOf(string s)
        {
            for(int i = 0; i < cbTenVatTu.Items.Count; i++)
            {
                if (((CBBItem)cbTenVatTu.Items[i]).Value == s)
                {
                    return i;
                }
            }
            return -1;
        }
        private void dgvVatDungPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VATDUNGPHONG vdp = BLL_QLVDP.Instance.FindVatDungPhong(new DTO.Keys
            {
                key1 = dgvVatDungPhong.SelectedRows[0].Cells["Phong"].Value.ToString(),
                key2 = dgvVatDungPhong.SelectedRows[0].Cells["VatDungID"].Value.ToString()
            });
            cbPhongID.SelectedIndex = cbPhongID.Items.IndexOf(vdp.PhongID);
            cbTenVatTu.SelectedIndex = cbTenVatTuIndexOf(vdp.VatDungID);
            nUDSLBanDau.Value = vdp.SoLuongBanDau;
            nUDSLHienTai.Value = vdp.SoLuongHienTai;
            cbTrangThai.SelectedIndex = cbTrangThai.Items.IndexOf(vdp.TrangThaiVatDungID);
        }
        #endregion
    }
}
