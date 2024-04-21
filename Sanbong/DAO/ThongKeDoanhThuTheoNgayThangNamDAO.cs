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
    public class ThongKeDoanhThuTheoNgayThangNamDAO
    {
        public DataTable LayDoanhThuTheoNgayThangNam()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT DATE(a.thoiGianBatDau) AS ngay, SUM(a.donGia + b.donGia) AS doanhthu " +
                    "FROM phieudatsan a JOIN chitiethoadon b ON a.idHoaDon = b.idHoaDon " +
                    "GROUP BY DATE(a.thoiGianBatDau)";

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
