using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DTO
{
    class BillDV_View
    {
        public int ID { get; set; }
        public string BookID { get; set; }
        public string TenNhanVien { get; set; }
        public string TenDichVu { get; set; }
        public System.DateTime Ngay { get; set; }
        public int SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    }
}
