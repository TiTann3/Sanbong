using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class TimKiemMatHangTheoNganhHangDAO
    {

        public DataTable TimKiemMatHangTheoNganhHang(string tenNganhHang)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT a.id, a.tenMatHang, b.tenNganhHang, a.donGia, a.soLuong " +
                    "FROM mathang a, nganhhang b WHERE b.tenNganhHang LIKE @TenNganhHang AND a.idNganhHang = b.id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenNganhHang", "%"+tenNganhHang+ "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
