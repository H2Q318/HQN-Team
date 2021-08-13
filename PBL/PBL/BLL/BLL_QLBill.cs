using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Reporting.WinForms;
using PBL.DAL;

namespace PBL.BLL
{
    class BLL_QLBill
    {
        private static BLL_QLBill _instance;
        public static BLL_QLBill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLBill();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLBill() { }
        public List<HOADON> GetListHoaDon(string bookid = null)
        {
            if (string.IsNullOrEmpty(bookid))
            {
                return new QLKS().HOADONs.ToList();
            }
            return new QLKS().HOADONs.Where(p => p.BookID.Contains(bookid)).ToList();
        }
        public void DeleteHoaDon(List<string> l)
        {
            QLKS db = new QLKS();
            foreach(string s in l)
            {
                db.HOADONs.Remove(db.HOADONs.Find(s));
            }
            db.SaveChanges();
        }
        public HOADON FindHoaDon(string hoadonid)
        {
            return new QLKS().HOADONs.Find(hoadonid);
        }
        public IQueryable<func_XemChiTietHoaDon_DichVu_Result> BillService(string hoadonid)
            /* Trả về danh sách hoá đơn dịch vụ của một hoá đơn trong phần xem chi tiết hoá đơn */
        {
            return new QLKS().func_XemChiTietHoaDon_DichVu(hoadonid);
        }
        public IQueryable<func_XemChiTietHoaDon_VatTu_Result1> BillRoomSupplies(string hoadonid)
        /* Trả về danh sách hoá đơn vật tư của một hoá đơn trong phần xem chi tiết hoá đơn */
        {
            return new QLKS().func_XemChiTietHoaDon_VatTu(hoadonid);
        }
        public List<HOADON> Sort(string s, List<string> l)
        {
            QLKS db = new QLKS();
            List<HOADON> data = new List<HOADON>();
            foreach(string i in l)
            {
                data.Add(db.HOADONs.Find(i));
            }
            switch(s)
            {
                case "Mã book":
                    data = data.OrderByDescending(p => p.BookID).ToList();
                    break;
                case "Tổng tiền phòng":
                    data = data.OrderByDescending(p => p.TienPhong).ToList();
                    break;
                case "Tổng tiền dịch vụ":
                    data = data.OrderByDescending(p => p.TienDichVu).ToList();
                    break;
                case "Tổng tiền vật tư":
                    data = data.OrderByDescending(p => p.TienVatTu).ToList();
                    break;
                case "Tổng tiền":
                    data = data.OrderByDescending(p => p.TongTien).ToList();
                    break;
                case "Ngày thanh toán":
                    data = data.OrderByDescending(p => p.NgayThanhToan).ToList();
                    break;
            }
            return data;
        }

        public decimal[] GetRevenueDataInYear()
        {
            QLKS db = new QLKS();
            decimal[] data = new decimal[12];
            foreach (HOADON item in db.HOADONs.ToList())
            {
                if (item.TongTien != null)
                {
                    data[item.NgayThanhToan.Month - 1] += (decimal)item.TongTien;
                }
                else
                {
                    data[item.NgayThanhToan.Month - 1] += 0;
                }
            }
            return data;
        }

        public decimal[] GetRevenueDataInMonth(int month)
        {
            QLKS db = new QLKS();
            decimal[] data = new decimal[DateTime.DaysInMonth(DateTime.Now.Year, month)];
            foreach (HOADON item in db.HOADONs.ToList())
            {
                if (item.NgayThanhToan.Month == month)
                {
                    if (item.TongTien != null)
                    {
                        data[item.NgayThanhToan.Day - 1] += (decimal)item.TongTien;
                    }
                    else
                    {
                        data[item.NgayThanhToan.Day - 1] += 0;
                    }
                } 
            }
            return data;
        }
        public List<ReportParameter> GetListReportParameters(string hoadonid, string tenks, string diachi, string tongdai, string website)
        {
            HOADON hoadon = FindHoaDon(hoadonid);
            BOOK book = BLL_QLBOOK.Instance.Find(hoadon.BookID);
            int songayo = ((TimeSpan)(book.NgayCheckIn_ThucTe - book.NgayCheckOut_ThucTe)).Days;
            List<ReportParameter> data = new List<ReportParameter> 
            {
                new ReportParameter("pTenKhachSan", tenks),
                new ReportParameter("pDiaChi", diachi),
                new ReportParameter("pTongDai", tongdai),
                new ReportParameter("pWebsite", website),
                new ReportParameter("pTenKhachHang", book.KHACHHANG.Ten),
                new ReportParameter("pGioiTinh", (bool)book.KHACHHANG.GioiTinh ? "Nam" : "Nữ"),
                new ReportParameter("pCMND", book.KHACHHANG.CMND),
                new ReportParameter("pSDT", book.KHACHHANG.SDT),
                new ReportParameter("pMaHoaDon", hoadonid),
                new ReportParameter("pPhong", book.PhongID),
                new ReportParameter("pNgayCheckin", book.NgayCheckIn_ThucTe.ToString()),
                new ReportParameter("pNgayCheckout", book.NgayCheckOut_ThucTe.ToString()),
                new ReportParameter("pTongTienDichVu", hoadon.TienDichVu.ToString()),
                new ReportParameter("pTongTienPhong", hoadon.TienPhong.ToString()),
                new ReportParameter("pTongTienVatTu", hoadon.TienVatTu.ToString()),
                new ReportParameter("pGiaPhong", book.PHONG.LOAIPHONG.Gia.ToString()),
                new ReportParameter("pSoNgayO", songayo != 0 ? songayo.ToString() : "1"),
                new ReportParameter("pTongTien", hoadon.TongTien.ToString())
            };
            return data;
        }
    }
}
