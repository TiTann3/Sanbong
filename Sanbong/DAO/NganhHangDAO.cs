using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class NganhHangDAO
    {
        public static void addNganhHang(string ten)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO nganhhang(tenNganhHang) VALUES (@ten)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@ten", ten);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;
                }

                conn.Close();
            }
        }

        public static DataSet getAllNganhHang()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM nganhhang";

                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

                    dataSet = new DataSet();

                    sqlDataAdapter.Fill(dataSet);

                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            return dataSet;
        }

        public static void updateTenNganhHang(int id, String tenNganhHang)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE nganhhang SET tenNganhHang = @tenNganhHang WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@tenNganhHang", tenNganhHang);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static void deleteNganhHang(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM nganhhang WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
