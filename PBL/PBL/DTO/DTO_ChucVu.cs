using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class DTO_ChucVu
    {
        public static bool Compare_TenChucVu(object o1, object o2)
        {
            if (string.Compare(((CHUCVU)o1).TenChucVu, ((CHUCVU)o2).TenChucVu) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool Compare_QuyenHan(object o1, object o2)
        {
            if (((CHUCVU)o1).QuyenHan > ((CHUCVU)o2).QuyenHan)
            {
                return true;
            }
            return false;
        }
    }
}
