using PBL.DAL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return new QLKS().KHACHHANGs.ToList();
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
            try
            {
                QLKS db = new QLKS();
                db.KHACHHANGs.Add(s);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
            }
        }
        public void UpdateKh(KHACHHANG p)
        {
        
            QLKS db = new QLKS();
            var kh = db.KHACHHANGs.Find(p.KhachHangID);
            if (kh != null)
            {
                kh.Ten = p.Ten;
                kh.SDT = p.SDT;
                kh.QuocTich = p.QuocTich;
                kh.GioiTinh = p.GioiTinh;
                kh.GhiChu = p.GhiChu;
                kh.CMND = p.CMND;
                db.SaveChanges();
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
            QLKS db = new QLKS();
            foreach (string s in l)
            {
                db.KHACHHANGs.Remove(db.KHACHHANGs.Find(s));
                db.SaveChanges();
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
    }
}
