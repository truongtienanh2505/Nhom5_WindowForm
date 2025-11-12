using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAL;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.BLL
{
    public class HoaDonBLL
    {
        private readonly HoaDonDAL hoaDonDAL = new HoaDonDAL();
        private readonly ChiTietHoaDonDAL chiTietDAL = new ChiTietHoaDonDAL();
        private readonly BanDAL banDAL = new BanDAL();
        private readonly MonDAL monDAL = new MonDAL();

        public int TaoHoaDonMoi(int maBan, int maNguoiDung)
        {
            HoaDon hd = new HoaDon
            {
                MaBan = maBan,
                MaNguoiDung = maNguoiDung,
                NgayLap = DateTime.Now,
                TongTien = 0,
                TrangThai = "Chưa thanh toán"
            };
            int maHD = hoaDonDAL.TaoHoaDon(hd);
            banDAL.CapNhatTrangThai(maBan, "Có khách");
            return maHD;
        }

        public void ThemMonVaoHoaDon(int maHD, int maMon, int soLuong)
        {
            Mon mon = monDAL.LayMonTheoID(maMon);
            if (mon == null)
                throw new Exception("Không tìm thấy món ăn.");

            chiTietDAL.ThemChiTietHoaDon(maHD, maMon, soLuong, mon.DonGia);
        }

        public decimal TinhTongTien(int maHD)
        {
            List<ChiTietHoaDon> chiTiet = chiTietDAL.LayChiTietHoaDon(maHD);
            decimal tongTien = chiTiet.Sum(x => x.ThanhTien);
            hoaDonDAL.CapNhatTongTien(maHD, tongTien);
            return tongTien;
        }

        public void ThanhToan(int maHD, int maBan)
        {
            decimal tongTien = TinhTongTien(maHD);
            hoaDonDAL.CapNhatTrangThaiHoaDon(maHD, "Đã thanh toán");
            banDAL.CapNhatTrangThai(maBan, "Trống");
        }
    }
}
