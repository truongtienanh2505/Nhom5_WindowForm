namespace chuongtrinhquanly.Models;

public class Class1
{
    public class MenuItem
    {
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien => SoLuong * DonGia;
    }

    public class Ban
    {
        public int MaBan { get; set; }
        public string TenBan { get; set; }
        public bool TrangThai { get; set; } // true = có khách, false = trống
    }

    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaBan { get; set; }
        public DateTime NgayLap { get; set; }
        public List<MenuItem> DanhSachMon { get; set; } = new List<MenuItem>();
        public double TongTien { get; set; }
        public bool DaThanhToan { get; set; } = false;
    }

}
