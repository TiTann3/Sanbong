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
    public class ChiTietHoaDonDAO
    {
        public static void addChiTietHoaDon(int idHoaDon, int idMatHang, int soLuong, double donGia)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO chitiethoadon(idHoaDon, idMatHang, soLuong, donGia) " +
                       "VALUES (@idHoaDon, @idMatHang, @soLuong, @donGia);";
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                command.Parameters.AddWithValue("@idMatHang", idMatHang);
                command.Parameters.AddWithValue("@soLuong", soLuong);
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

        public static DataSet getAllChiTietHoaDon()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM chitiethoadon";

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

        public static DataSet getAllChiTietHoaDon(int idHoaDon)
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM chitiethoadon WHERE idHoaDon = @idHoaDon";
                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@idHoaDon", idHoaDon);

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

        public static void deleteChiTietHoaDon(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM chitiethoadon WHERE id = @id";
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
        public static void deleteChiTietHoaDonHuySan(int idHoaDon)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM chitiethoadon WHERE idHoaDon = @idHoaDon";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@idHoaDon", idHoaDon);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static void updateChiTietHoaDon(int id, int idHoaDon, int idMatHang, int soLuong, double donGia)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE chitiethoadon SET idHoaDon = @idHoaDon, idMatHang = @idMatHang, " +
                        "soLuong = @soLuong, donGia = @donGia WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                    command.Parameters.AddWithValue("@idMatHang", idMatHang);
                    command.Parameters.AddWithValue("@soLuong", soLuong);
                    command.Parameters.AddWithValue("@donGia", donGia);

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
