using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<KHACHHANG> GetListKhachHang(string s)
        {
            if (s == null)
            {
                return GetAllKhachHang();
            }
            return new QLKS().KHACHHANGs.Where(p => (p.Ten.Contains(s))).ToList();
        }

        public void AddKh(KHACHHANG s)
        {
            QLKS db = new QLKS();
            db.KHACHHANGs.Add(s);
            db.SaveChanges();
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
    }
}
