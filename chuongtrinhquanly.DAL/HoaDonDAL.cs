using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyQuanCafe.Models;

namespace chuongtrinhquanly.DAL;

public class HoaDonDAL
{
    public class HoaDonDAL
    {
        public class BanDAL
        {
            public void CapNhatTrangThai(int maBan, string trangThai)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Ban SET TrangThai = @TrangThai WHERE MaBan = @MaBan";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@MaBan", maBan);
                    cmd.ExecuteNonQuery();
                }
            }

            public List<Ban> LayDanhSachBan()
            {
                List<Ban> list = new List<Ban>();
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT MaBan, TenBan, TrangThai FROM Ban";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Ban
                        {
                            MaBan = (int)reader["MaBan"],
                            TenBan = reader["TenBan"].ToString(),
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                }
                return list;
            }
        }

        public class HoaDonDAL
        {
            public int TaoHoaDon(HoaDon hd)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO HoaDon (MaBan, MaNguoiDung, NgayLap, TongTien, TrangThai)
                               OUTPUT INSERTED.MaHD
                               VALUES (@MaBan, @MaNguoiDung, @NgayLap, @TongTien, @TrangThai)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaBan", hd.MaBan);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", hd.MaNguoiDung);
                    cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                    cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
                    cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                    return (int)cmd.ExecuteScalar();
                }
            }

            public void CapNhatTongTien(int maHD, decimal tongTien)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE HoaDon SET TongTien = @TongTien WHERE MaHD = @MaHD";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.ExecuteNonQuery();
                }
            }

            public void CapNhatTrangThaiHoaDon(int maHD, string trangThai)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE HoaDon SET TrangThai = @TrangThai WHERE MaHD = @MaHD";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public class ChiTietHoaDonDAL
        {
            public void ThemChiTietHoaDon(int maHD, int maMon, int soLuong, decimal donGia)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong, DonGia)
                               VALUES (@MaHD, @MaMon, @SoLuong, @DonGia)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.ExecuteNonQuery();
                }
            }

            public List<ChiTietHoaDon> LayChiTietHoaDon(int maHD)
            {
                List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM ChiTietHoaDon WHERE MaHD = @MaHD";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ChiTietHoaDon
                        {
                            MaCTHD = (int)reader["MaCTHD"],
                            MaHD = (int)reader["MaHD"],
                            MaMon = (int)reader["MaMon"],
                            SoLuong = (int)reader["SoLuong"],
                            DonGia = (decimal)reader["DonGia"]
                        });
                    }
                }
                return list;
            }
        }

        public class MonDAL
        {
            public Mon LayMonTheoID(int maMon)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Mon WHERE MaMon = @MaMon";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Mon
                        {
                            MaMon = (int)reader["MaMon"],
                            TenMon = reader["TenMon"].ToString(),
                            DonGia = (decimal)reader["DonGia"],
                            MaLoai = (int)reader["MaLoai"]
                        };
                    }
                }
                return null;
            }
        }
    }
}
