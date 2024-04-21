using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class HoaDonDAO
    {
        public static void addHoaDon(DateTime ngayTao, string tenKhachHang, bool daThanhToan)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO hoadon(ngayTao, tenKhachHang, daThanhToan) " +
                       "VALUES (@ngayTao, @tenKhachHang, @daThanhToan);";
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@ngayTao", ngayTao);
                command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                command.Parameters.AddWithValue("@daThanhToan", daThanhToan ? 1 : 0);

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

        public static DataSet getAllHoaDon()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM hoadon";

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

        public static DataSet getHoaDon(int id)
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM hoadon WHERE id = @id";
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

        public static void deleteHoaDon(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM hoadon WHERE id = @id";
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

        public static DataSet getLastHoaDon()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM hoadon ORDER BY ID DESC LIMIT 1";

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

        public static void updateHoaDon(int id, string tenKhachHang, bool daThanhToan)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE hoadon SET tenKhachHang = @tenKhachHang, daThanhToan = @daThanhToan WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                    command.Parameters.AddWithValue("@daThanhToan", daThanhToan ? 1 : 0);

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
