using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class ThongKeDoanhThuTheoNganhDAO
    {
        public DataTable PhanTichDoanhThuTheoNganh()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT nh.tenNganhHang, SUM(ct.donGia*ct.soLuong) AS doanhthu " +
                    "FROM phieudatsan pd, mathang mh, chitiethoadon ct, nganhhang nh " +
                    "WHERE pd.idHoaDon = ct.idHoaDon AND mh.id = ct.idMatHang AND mh.idNganhHang = nh.id " +
                    "GROUP BY nh.tenNganhHang";

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
