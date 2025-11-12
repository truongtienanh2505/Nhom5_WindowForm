namespace chuongtrinhquanly.BLL;

public class HoaDonBLL
{
    public class HoaDonBLL
    {
        public double TinhTongTien(HoaDon hd)
        {
            double tong = 0;
            foreach (var mon in hd.DanhSachMon)
                tong += mon.ThanhTien;
            hd.TongTien = tong;
            return tong;
        }

        public void CapNhatTrangThaiBan(Ban ban, bool coKhach)
        {
            ban.TrangThai = coKhach;
        }

        public HoaDon TaoHoaDonMoi(int maBan, List<MenuItem> danhSachMon)
        {
            HoaDon hd = new HoaDon
            {
                MaHoaDon = new Random().Next(1000, 9999),
                MaBan = maBan,
                NgayLap = DateTime.Now,
                DanhSachMon = danhSachMon
            };

            hd.TongTien = TinhTongTien(hd);
            return hd;
        }
    }

}
