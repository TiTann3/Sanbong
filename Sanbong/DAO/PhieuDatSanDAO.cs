using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DoAnC_.DTO;


namespace DoAnC_.DAO
{
    public class PhieuDatSanDAO
    {
        public static void addPhieuDatSan(int idSanBong, DateTime thoiGianBatDau, double soGioDat, DateTime thoiGianKetThuc, double donGia, int idHoaDon)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO phieudatsan(idSanBong, thoiGianBatDau, soGioDat, thoiGianKetThuc, donGia, idHoaDon) " +
                       "VALUES (@idSanBong, @thoiGianBatDau, @soGioDat, @thoiGianKetThuc, @donGia, @idHoaDon)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@idSanBong", idSanBong);
                command.Parameters.AddWithValue("@thoiGianBatDau", thoiGianBatDau);
                command.Parameters.AddWithValue("@soGioDat", soGioDat);
                command.Parameters.AddWithValue("@thoiGianKetThuc", thoiGianKetThuc);
                command.Parameters.AddWithValue("@donGia", donGia);
                command.Parameters.AddWithValue("@idHoaDon", idHoaDon);

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

        public static DataSet getAllPhieuDatSan(int idSanBong)
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM phieudatsan WHERE idSanBong = @idSanBong";

                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@idSanBong", idSanBong);

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

        public static DataSet getAllPhieuDatSan()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM phieudatsan";

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

        public static void deletePhieuDatSan(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM phieudatsan WHERE id = @id";
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

        public static void updatePhieuDatSan(int id, int idSanBong, DateTime thoiGianBatDau, double soGioDat, DateTime thoiGianKetThuc, double donGia, int idHoaDon)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "UPDATE phieudatsan SET idSanBong = @idSanBong, thoiGianBatDau = @thoiGianBatDau, " +
                        "soGioDat = @soGioDat, thoiGianKetThuc = @thoiGianKetThuc, donGia = @donGia, idHoaDon = @idHoaDon WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@thoiGianBatDau", thoiGianBatDau);
                    command.Parameters.AddWithValue("@soGioDat", soGioDat);
                    command.Parameters.AddWithValue("@donGia", donGia);
                    command.Parameters.AddWithValue("@thoiGianKetThuc", thoiGianKetThuc);
                    command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                    command.Parameters.AddWithValue("@idSanBong", idSanBong);

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
