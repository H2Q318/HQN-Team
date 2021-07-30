using PBL.DAL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL.BLL
{
    class BLL_QLKH
    {
        private static BLL_QLKH _instance;
        public static BLL_QLKH Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLKH();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLKH() { }
        public List<KHACHHANG> GetAllKhachHang()
        {
            List<KHACHHANG> data = new QLKS().KHACHHANGs.ToList();
            data.Reverse();
            return data;
        }
        public List<KH_View> GetAlllKhView(List<KHACHHANG> l)
        {
            return l.Select(p => new KH_View()
            {
                KhachHangID = p.KhachHangID,
                Ten = p.Ten,
                GioiTinh=p.GioiTinh,
                CMND=p.CMND,
                SDT=p.SDT,
                QuocTich=p.QuocTich,
                GhiChu=p.GhiChu
            }).ToList();
        }
        public void AddKh(KHACHHANG s)
        {
            if (CheckKHInfo(s) == true)
            {
                try
                {
                    QLKS db = new QLKS();
                    db.KHACHHANGs.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại và CMND hoặc để trống nếu không có !");
            }
            
        }
        public void UpdateKh(KHACHHANG p)
        {   
            if (CheckKHInfo(p) == true)
            {    
                try
                {
                    QLKS db = new QLKS();
                    var kh = db.KHACHHANGs.Find(p.KhachHangID);
                    kh.Ten = p.Ten;
                    kh.SDT = p.SDT;
                    kh.QuocTich = p.QuocTich;
                    kh.GioiTinh = p.GioiTinh;
                    kh.GhiChu = p.GhiChu;
                    kh.CMND = p.CMND;
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại và CMND hoặc để trống nếu không có !");
            }    

        }
        public List<KH_View> FindKhByName(string s)
        {
           
            return new QLKS().KHACHHANGs.Where(p=>p.Ten.Contains(s)).ToList().Select(p => new KH_View()
            {
                KhachHangID = p.KhachHangID,
                Ten = p.Ten,
                GioiTinh = p.GioiTinh,
                CMND = p.CMND,
                SDT = p.SDT,
                QuocTich = p.QuocTich,
                GhiChu = p.GhiChu
            }).ToList();
        }
        public KHACHHANG FindKh(string s)
        {
            return new QLKS().KHACHHANGs.Find(s);
        }
        public List<KHACHHANG> KhachHangDP()
        {
            List<KHACHHANG> t = new List<KHACHHANG>();
            t = new QLKS().BOOKs.Where(p => (p.NgayCheckIn != null) && (p.NgayCheckIn_ThucTe == null)).ToList().Select(p => new KHACHHANG() { KhachHangID = p.KHACHHANG.KhachHangID, Ten = p.KHACHHANG.Ten, CMND = p.KHACHHANG.CMND, SDT = p.KHACHHANG.SDT }).ToList();
            return t;
        }
        public void DeleteKh(List<string> l)
        {
            try
            {
                QLKS db = new QLKS();
                foreach (string s in l)
                {
                    db.KHACHHANGs.Remove(db.KHACHHANGs.Find(s));
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Khách hàng không thể xóa. Vui lòng thử lại!");
            }
        }
        public void Sort(List<KH_View> listKH ,string sort)
        {
            if(sort =="Name")
            {
                Comparison<KH_View> KHcomparison = new Comparison<KH_View>(CompareName);
                listKH.Sort(KHcomparison);
            }
            else
            {
                Comparison<KH_View> KHcomparison = new Comparison<KH_View>(CompareID);
                listKH.Sort(KHcomparison);
            }    
        }
        private static int CompareID(KH_View x, KH_View y)
        {
            return x.KhachHangID.CompareTo(y.KhachHangID);
        }
        private static int CompareName(KH_View x, KH_View y)
        {
            return x.Ten.CompareTo(y.Ten);
        }
        public bool CheckKHInfo(KHACHHANG kh)
        {
            return (
                ((kh.SDT.Length == 0) || (kh.SDT.Length == 10)) 
                && ((kh.CMND.Length == 0) || (kh.CMND.Length == 9))
                );
        }
    }
}
