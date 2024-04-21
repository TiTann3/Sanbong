using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{     
    public class TimKiemHoaDonTheoTenKHDAO
    {

        public DataTable TimKiemHoaDonTheoTenKH(string tenKhachHang)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT * FROM hoadon WHERE tenKhachHang LIKE @TenKhachHang";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenKhachHang","%" + tenKhachHang + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
