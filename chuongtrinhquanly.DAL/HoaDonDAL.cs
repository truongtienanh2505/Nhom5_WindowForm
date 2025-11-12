namespace chuongtrinhquanly.DAL;

public class HoaDonDAL
{
    public class HoaDonDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyCafe;Integrated Security=True";

        public void LuuHoaDon(HoaDon hd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO HoaDon (MaBan, NgayLap, TongTien, DaThanhToan) VALUES (@MaBan, @NgayLap, @TongTien, @DaThanhToan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", hd.MaBan);
                cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
                cmd.Parameters.AddWithValue("@DaThanhToan", hd.DaThanhToan);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
