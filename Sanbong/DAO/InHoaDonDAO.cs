using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public  class InHoaDonDAO
    {
        public DataTable getDauHoaDon(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT a.tenKhachHang, Date(a.ngayTao) as ngayHoaDon, b.idSanBong, b.soGioDat, b.donGia FROM " +
                        "hoadon a, phieudatsan b WHERE a.id = b.idHoaDon AND a.id = @id";
                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            return dataTable;
        }
        public DataTable getCuoiHoaDon(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT c.tenMatHang, d.soLuong, d.donGia FROM " +
                        "mathang c, chitiethoadon d WHERE c.id = d.idMatHang AND d.idHoaDon = @id ";
                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            return dataTable;
        }
        public DataTable getTongDonGia(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Connect.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT Sum(b.donGia+a.donGia) as tongCong " +
                        "FROM chitiethoadon a, phieudatsan b, hoadon c " +
                        "WHERE a.idHoaDon = c.id AND c.id = b.idHoaDon AND a.id = @id ";
                    MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            return dataTable;
        }
    }
}
