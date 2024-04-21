using DoAnC_.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class TimKiemMatHangTheoTenDAO
    {

        public DataTable TimKiemMatHangTheoTen(string tenMatHang)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT a.id, a.tenMatHang, b.tenNganhHang, a.donGia, a.soLuong " +
                    "FROM mathang a, nganhhang b WHERE a.tenMatHang LIKE @TenMatHang AND a.idNganhHang = b.id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenMatHang", "%"+tenMatHang+ "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
