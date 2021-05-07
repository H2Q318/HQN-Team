using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.DTO;

namespace PBL
{
    class BLL_QLP
    {
        private static BLL_QLP _Instance;
        public static BLL_QLP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLP();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_QLP() { }

        public List<PHONG> GetListPhong(string s=null)
        {
            if (s == null)
            {
                return new QLKS().PHONGs.ToList();
            }
            return new QLKS().PHONGs.Where(p => p.PhongID == s).ToList();
        }
        public List<Phong_View> GetListPhong_View(List<PHONG> l)
        {
            return l.Select(p => new Phong_View
            {
                PhongID = p.PhongID,
                TenLoaiPhong = p.LOAIPHONG.TenLoaiPhong,
                TrangThai = p.TrangThai
            }).ToList();
        }
        public void AddPhong(PHONG p)
        {
            QLKS db = new QLKS();
            db.PHONGs.Add(p);
            db.SaveChanges();
        }
        public void UpdatePhong(PHONG p)
        {
            QLKS db = new QLKS();
            var phong = db.PHONGs.Find(p.PhongID);
            if (phong != null)
            {
                phong.LoaiPhongID = p.LoaiPhongID;
                phong.TrangThai = p.TrangThai;
                db.SaveChanges();
            }
            
        }
        public PHONG FindPhong(string s)
        {
            return new QLKS().PHONGs.Find(s);
        }
        public void DeletePhong(List <string>  l)
        {
            QLKS db = new QLKS();
            foreach(string s in l)
            {
                db.PHONGs.Remove(db.PHONGs.Find(s));
                db.SaveChanges();
            }
        }
    }
}
