using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;

    public class PhieuNhapHangDAO
    {
        public static void addPhieuNhapHang(int idMatHang, DateTime ngayNhap, int soLuong, double tongTien)
        {
            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
            {
                conn.Open();

                String query = "INSERT INTO phieunhaphang(idMatHang, ngayNhap, soLuong, tongTien) VALUES (@idMatHang, @ngayNhap, @soLuong, @tongTien)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@idMatHang", idMatHang);
                command.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                command.Parameters.AddWithValue("@soLuong", soLuong);
                command.Parameters.AddWithValue("@tongTien", tongTien);

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

        public static DataSet getAllPhieuNhapHang()
        {
            DataSet dataSet;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT * FROM phieunhaphang";

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

        public static void deletePhieuNhapHang(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "DELETE FROM phieunhaphang WHERE id = @id";
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
