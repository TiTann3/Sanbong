using DoAnC_.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class MatHangDAO
    {
        public static void addMatHang(string tenMatHang, int idNganhHang, double donGia)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO mathang(tenMatHang, idNganhHang, donGia) VALUES (@tenMatHang, @idNganhHang, @donGia);";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@tenMatHang", tenMatHang);
                command.Parameters.AddWithValue("@idNganhHang", idNganhHang);
                command.Parameters.AddWithValue("@donGia", donGia);

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

        public static DataSet getAllMatHang()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM mathang";

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

        public static void updateMatHang(int id, string tenMatHang, int idNganhHang, double donGia, int soLuong)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE mathang SET tenMatHang = @tenMatHang, idNganhHang = @idNganhHang" +
                        ", donGia = @donGia, soLuong = @soLuong WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@tenMatHang", tenMatHang);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idNganhHang", idNganhHang);
                    command.Parameters.AddWithValue("@donGia", donGia);
                    command.Parameters.AddWithValue("@soLuong", soLuong);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static void updateSoLuongMatHang(int id, int soLuong)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE mathang SET soLuong = @soLuong WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@soLuong", soLuong);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static void deleteMatHang(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM mathang WHERE id = @id";
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

        public static DataSet getMatHangFromIdNganhHang(int idNganhHang)
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM mathang WHERE idNganhHang = @idNganhHang";
                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@idNganhHang", idNganhHang);

                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

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

        public static DataSet getMatHang(int id)
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM mathang WHERE id = @id";
                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

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
    }
}
