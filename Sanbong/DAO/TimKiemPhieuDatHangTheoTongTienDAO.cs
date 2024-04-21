using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnC_.DAO;

namespace DoAnC_.DAO
{
    public class TimKiemPhieuDatHangTheoTongTienDAO
    {
        public DataTable TimKiemPhieuDatHangTheoTongTien(decimal giaTu, decimal giaDen)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT a.id, b.tenMatHang, a.ngayNhap, a.soLuong, a.tongTien " +
                    "FROM phieunhaphang a, mathang b WHERE tongTien BETWEEN @GiaTu AND @GiaDen AND a.idMatHang = b.id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GiaTu", giaTu);
                    command.Parameters.AddWithValue("@GiaDen", giaDen);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
