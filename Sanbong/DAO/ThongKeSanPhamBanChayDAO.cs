using DoAnC_.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnC_.DAO
{
    public class ThongKeSanPhamBanChayDAO
    {
        public DataTable LayDanhSachSanPhamBanChay()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT m.tenmathang, SUM(ct.soluong) AS tongSoLuong " +
                               "FROM mathang m " +
                               "JOIN chitiethoadon ct ON m.id = ct.idmathang " +
                               "GROUP BY m.tenmathang " +
                               "ORDER BY tongSoLuong DESC " +
                               "LIMIT 3";

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
