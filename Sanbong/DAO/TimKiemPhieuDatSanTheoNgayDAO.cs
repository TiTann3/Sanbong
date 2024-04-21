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
    public class TimKiemPhieuDatSanTheoNgayDAO
    {

        public DataTable TimKiemPhieuDatSanTheoThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT * FROM phieudatsan WHERE thoiGianBatDau BETWEEN @TuNgay AND @DenNgay";

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
