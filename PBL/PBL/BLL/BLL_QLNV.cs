using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class BLL_QLNV
    {
        private static BLL_QLNV _instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLNV();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLNV() { }

        public List<NHANVIEN> GetAllNhanVien()
        {
            return new QLKS().NHANVIENs.ToList();
        }

        public bool AddNhanVien(NHANVIEN nv)
        {
            return false;
        }
    }
}
