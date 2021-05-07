using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class DTO_DichVu
    {

        public static bool Compare_TenDichVu(object o1, object o2)
        {
            if (string.Compare(((LOAIDICHVU)o1).TenDichVu, ((LOAIDICHVU)o2).TenDichVu) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool Compare_Gia(object o1, object o2)
        {
            if (((LOAIDICHVU)o1).DonGia > ((LOAIDICHVU)o2).DonGia)
            {
                return true;
            }
            return false;
        }
    }
}
