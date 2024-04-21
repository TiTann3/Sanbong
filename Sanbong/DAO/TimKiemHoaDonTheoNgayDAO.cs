
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{    
    public class TimKiemHoaDonTheoNgayDAO
    {
        public DataTable TimKiemHoaDonTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT * FROM hoadon WHERE ngayTao >= @TuNgay AND ngayTao <= @DenNgay";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
