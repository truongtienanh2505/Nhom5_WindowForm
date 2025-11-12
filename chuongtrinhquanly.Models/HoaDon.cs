using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuongtrinhquanly.Models;

public class Class1
{
    public class Ban
    {
        public int MaBan { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; }
    }

    public class HoaDon
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaBan { get; set; }
        public int MaNguoiDung { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }

    public class ChiTietHoaDon
    {
        public int MaCTHD { get; set; }
        public int MaHD { get; set; }
        public int MaMon { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }

    public class Mon
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public decimal DonGia { get; set; }
        public int MaLoai { get; set; }
    }

    public class NguoiDung
    {
        public int MaNguoiDung { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
    }
}