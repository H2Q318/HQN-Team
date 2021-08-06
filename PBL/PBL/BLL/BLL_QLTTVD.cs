using System.Collections.Generic;
using System.Linq;
using PBL.DAL;

namespace PBL.BLL
{
    class BLL_QLTTVD
    {
        private static BLL_QLTTVD _instance;
        public static BLL_QLTTVD Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLTTVD();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLTTVD() { }
        public List<TRANGTHAIVATDUNG> GetListTrangThaiVatDung()
        {
            return new QLKS().TRANGTHAIVATDUNGs.ToList();
        }
    }
}
