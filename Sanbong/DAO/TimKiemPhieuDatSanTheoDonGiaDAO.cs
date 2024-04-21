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
    public class TimKiemPhieuDatSanTheoDonGiaDAO
    {

        public DataTable TimKiemPhieuDatSanTheoDonGia(decimal giaTu, decimal giaDen)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT * FROM phieudatsan WHERE dongia BETWEEN @GiaTu AND @GiaDen";

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
