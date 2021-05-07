using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    class BLL_QLDV
    {
        private static BLL_QLDV _instance;
        public static BLL_QLDV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLDV();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLDV() { }
        public List<HOADON_DUNG_DICHVU> GetAllHoaDon(string IDBook)
        {
            return new QLKS().HOADON_DUNG_DICHVU.Where(p => p.BookID == IDBook).ToList();
        }
        public List<LOAIDICHVU> GetAllDichVu()
        {
            return new QLKS().LOAIDICHVUs.ToList();
        }
        public void AddDichVu(HOADON_DUNG_DICHVU s)
        {
            QLKS db = new QLKS();
            db.HOADON_DUNG_DICHVU.Add(s);
            db.SaveChanges();
        }
    }
}
