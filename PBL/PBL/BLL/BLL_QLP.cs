using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;

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

        public List<PHONG> GetAllPhong()
        {
            return new QLKS().PHONGs.ToList();
        }
        public List<PHONG> GetPhong(string s)
        {
            return new QLKS().PHONGs.Where(p => p.PhongID == s).ToList();
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
            phong.LoaiPhongID = p.LoaiPhongID;
            phong.TrangThai = p.TrangThai;
            db.SaveChanges();
        }
        public void DeletePhong(string s)
        {
            QLKS db = new QLKS();
            db.PHONGs.Remove(db.PHONGs.Find(s));
            db.SaveChanges();
        }

    }
}
