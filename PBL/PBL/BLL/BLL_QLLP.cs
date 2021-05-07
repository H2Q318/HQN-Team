using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.DTO;

namespace PBL.BLL
{
    class BLL_QLLP
    {
        private static BLL_QLLP _Instance;
        public static BLL_QLLP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLLP();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_QLLP() { }
        public List <LOAIPHONG> GetListLoaiPhong(string s)
        {
            if (s != null)
            {
                return new QLKS().LOAIPHONGs.Where(lp => lp.TenLoaiPhong == s).ToList();
            }
            return new QLKS().LOAIPHONGs.ToList();
        }
        public LOAIPHONG FindLoaiPhong(string s)
        {
            return new QLKS().LOAIPHONGs.Find(s);
        }
        public void DeleteLoaiPhong(List<string> l)
        {
            QLKS db = new QLKS();
            foreach(string s in l)
            {
                db.LOAIPHONGs.Remove(db.LOAIPHONGs.Find(s));
                db.SaveChanges();
            }
        }
        public void AddLoaiPhong(LOAIPHONG lp)
        {
            QLKS db = new QLKS();
            db.LOAIPHONGs.Add(lp);
            db.SaveChanges();
        }
        public void UpdateLoaiPhong(LOAIPHONG lp)
        {
            QLKS db = new QLKS();
            var lp1 = db.LOAIPHONGs.Find(lp.LoaiPhongID);
            lp1.TenLoaiPhong = lp.TenLoaiPhong;
            lp1.Gia = lp.Gia;
            lp1.SoNguoi = lp.SoNguoi;
            db.SaveChanges();
        }
    }
}
