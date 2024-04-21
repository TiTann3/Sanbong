using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class ThongKeKhachHangDAO
    {
        public DataTable PhanTichThongTinKhachHang()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT c.tenKhachHang, COUNT(*) AS solanmuahang, SUM(a.donGia+b.donGia) AS tongdoanhthu " +
                               "FROM phieudatsan a, chitiethoadon b, hoadon c WHERE a.idHoaDon = c.id AND b.idHoaDon = c.id " +
                               "GROUP BY c.tenKhachHang";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
