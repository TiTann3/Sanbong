using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class SanBongDAO
    {
        public static void addSan(String ten)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO sanbong(tenSan) VALUES (@tenSan)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@tenSan", ten);

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

        public static DataSet getAllSan()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM sanbong";

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

        public static void deleteSan(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM sanbong WHERE id = @id";
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

        public static void updateTenSan(int id, String tenSan)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE sanbong SET tenSan = @tenSan WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@tenSan", tenSan);
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
