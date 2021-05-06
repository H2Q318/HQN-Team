using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;

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
        public List <LOAIPHONG> GetAllLoaiPhong()
        {
            return new QLKS().LOAIPHONGs.ToList();
        }
    }
}
