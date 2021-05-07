using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DTO
{
    class VatDungPhong_View
    {
        public string Phong { get; set; }
        public string VatDungID { get; set; }
        public string TenVatDung { get; set; }
        public int SoLuongBanDau { get; set; }
        public int SoLuongHienTai { get; set; }
        public string TrangThai { get; set; }
    }
}
