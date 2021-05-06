using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;
using PBL.DAL;
using PBL.DTO;

namespace PBL
{
    public partial class fMenuQuanLy : Form
    {
        public fMenuQuanLy()
        {
            InitializeComponent();
            GUIPhong();
            GUILoaiPhong();
        }
        // Quản lý phòng
        private void GUIPhong()
        {
            ShowDGVPhong(null);
            foreach(LOAIPHONG i in BLL_QLLP.Instance.GetListLoaiPhong(null))
            {
                cbTenLoaiPhong.Items.Add(new CBBItem
                {
                    Text = i.TenLoaiPhong,
                    Value = i.LoaiPhongID
                });
            }
            cbTenLoaiPhong.SelectedIndex = 0;
            ShowDGVPhong(null);
        }
        private void ShowDGVPhong(string s)
        {
            dgvPhong.DataSource = BLL_QLP.Instance.GetListPhong_View(BLL_QLP.Instance.GetListPhong(s));
        }

        private void btnThemPh_Click(object sender, EventArgs e)
        {
            if (BLL_QLP.Instance.FindPhong(txbMaPhong.Text.Trim()) == null)
            {
                try
                {
                    PHONG p = new PHONG
                    {
                        PhongID = txbMaPhong.Text.Trim(),
                        LoaiPhongID = ((CBBItem)cbTenLoaiPhong.SelectedItem).Value,
                        TrangThai = rbtAvailable.Checked
                    };
                    BLL_QLP.Instance.AddPhong(p);
                    ShowDGVPhong(null);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap day du va dung kieu du lieu cua thong tin !");
                }
            }
            else
            {
                MessageBox.Show("Ma phong da ton tai !");
            }
            
        }

        private void btnSuaPh_Click(object sender, EventArgs e)
        {
            if (BLL_QLP.Instance.FindPhong(txbMaPhong.Text.Trim()) != null)
            {
                try
                {
                    PHONG p = new PHONG
                    {
                        PhongID = txbMaPhong.Text.Trim(),
                        LoaiPhongID = ((CBBItem)cbTenLoaiPhong.SelectedItem).Value,
                        TrangThai = rbtAvailable.Checked
                    };
                    BLL_QLP.Instance.UpdatePhong(p);
                    ShowDGVPhong(null);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap day du va dung kieu du lieu cua thong tin !");
                }
            }
            else
            {
                MessageBox.Show("Ma phong khong ton tai !");
            }
            
        }
        private void btnXoaPh_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count > 0)
            {
                BLL_QLP.Instance.DeletePhong(GetListPhongID());
                ShowDGVPhong(null);
            }
            else
            {
                MessageBox.Show("Chon it nhat mot dong de xoa !");
            }
        }

        private void btnResetPh_Click(object sender, EventArgs e)
        {
            txbMaPhong.Clear();
            cbTenLoaiPhong.SelectedIndex = 0;
        }

        private void btnSearchP_Click(object sender, EventArgs e)
        {
            ShowDGVPhong(txbSeachP.Text);
        }

        private void btnResetSp_Click(object sender, EventArgs e)
        {
            txbSeachP.Clear();
            ShowDGVPhong(null);
        }
        private List <string> GetListPhongID()
        {
            List<string> data = new List<string>();
            foreach(DataGridViewRow r in dgvPhong.SelectedRows)
            {
                data.Add(r.Cells["PhongID"].Value.ToString());
            }
            return data;
        }
        private int cbTenLoaiPhongIndexOf(string s)
        {
            for(int i = 0; i < cbTenLoaiPhong.Items.Count; i++)
            {
                if ((((CBBItem)cbTenLoaiPhong.Items[i]).Value) == s)
                {
                    return i;
                }

            }
            return -1;
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PHONG p = BLL_QLP.Instance.FindPhong(dgvPhong.SelectedRows[0].Cells["PhongID"].Value.ToString());
            txbMaPhong.Text = p.PhongID;
            cbTenLoaiPhong.SelectedIndex = cbTenLoaiPhongIndexOf(p.LoaiPhongID);
            rbtAvailable.Checked = p.TrangThai;
            rbtNotAvailable.Checked = !p.TrangThai;
        }

        private void txbMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8));
        }

        //

        // Quản lý loại phòng
        private void GUILoaiPhong()
        {
            ShowDGVLoaiPhong(null);
        }
        private List <string> GetListLoaiPhongID()
        {
            List<string> data = new List<string>();
            foreach(DataGridViewRow r in dgvLoaiPhong.SelectedRows)
            {
                data.Add(r.Cells["LoaiPhongID"].Value.ToString());
            }
            return data;
        }
        private void ShowDGVLoaiPhong(string s)
        {
            dgvLoaiPhong.DataSource = BLL_QLLP.Instance.GetListLoaiPhong(s);
            dgvLoaiPhong.Columns["LoaiPhongID"].Visible = false;
            dgvLoaiPhong.Columns["PHONGs"].Visible = false;

        }
        private void btnThemLP_Click(object sender, EventArgs e)
        {
            try
            {
                LOAIPHONG lp = new LOAIPHONG
                {
                    TenLoaiPhong = txbTenLoaiPhong.Text,
                    Gia = Convert.ToDecimal(txbGiaLP.Text),
                    SoNguoi = Convert.ToInt32(nUDSoNguoi.Value),
                };
                BLL_QLLP.Instance.AddLoaiPhong(lp);
                ShowDGVLoaiPhong(null);
            }
            catch
            {
                MessageBox.Show("Vui long nhap day du thong tin !");
            }
            
        }

        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            if (BLL_QLLP.Instance.FindLoaiPhong(txbMaLoaiPhong.Text) != null)
            {
                LOAIPHONG lp = new LOAIPHONG
                {
                    LoaiPhongID = txbMaLoaiPhong.Text,
                    TenLoaiPhong = txbTenLoaiPhong.Text,
                    Gia = Convert.ToDecimal(txbGiaLP.Text),
                    SoNguoi = Convert.ToInt32(nUDSoNguoi.Value)
                };
                BLL_QLLP.Instance.UpdateLoaiPhong(lp);
                ShowDGVLoaiPhong(null);
            }
            else
            {
                MessageBox.Show("Ma loai phong khong ton tai, chon duy nhat mot loai phong de sua !");
            }
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.SelectedRows.Count > 0)
            {
                BLL_QLLP.Instance.DeleteLoaiPhong(GetListLoaiPhongID());
            }
            else
            {
                MessageBox.Show("Vui long chon it nhat mot dong de xoa !");
            }
        }

        private void btnResetLP_Click(object sender, EventArgs e)
        {
            txbMaLoaiPhong.Clear();
            txbGia.Clear();
            txbTenLoaiPhong.Clear();
            nUDSoNguoi.Value = 0;
        }

        private void btnSearchLP_Click(object sender, EventArgs e)
        {
            ShowDGVLoaiPhong(txbSeachLp.Text.Trim());
        }

        private void btnResetSLp_Click(object sender, EventArgs e)
        {
            txbSeachLp.Clear();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LOAIPHONG lp = BLL_QLLP.Instance.FindLoaiPhong(dgvLoaiPhong.SelectedRows[0].Cells["LoaiPhongID"].Value.ToString());
            txbMaLoaiPhong.Text = lp.LoaiPhongID;
            txbGiaLP.Text = lp.Gia.ToString();
            txbTenLoaiPhong.Text = lp.TenLoaiPhong;
            nUDSoNguoi.Value = lp.SoNguoi;
        }

        private void txbGiaLP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8));
        }

        //
    }
}
