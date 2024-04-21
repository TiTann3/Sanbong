using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnC_.DAO
{
    public class ThongKeSanPhamVaNganhHangDAO
    {
        public DataTable LayDuLieuSanPhamVaNganhHang()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT SUM(mh.soLuong) AS SoLuongSanPham, nh.tenNganhHang AS TenNganhHang " +
                    "FROM mathang mh JOIN nganhhang nh ON mh.idNganhHang = nh.id GROUP BY mh.idNganhHang";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public DataTable LayPhanTramSanPhamVaNganhHang()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(Connect.connectionString()))
            {
                string query = "SELECT nh.tenNganhHang AS TenNganhHang, (SUM(mh.soLuong) / (SELECT SUM(soLuong) FROM mathang)) * 100 AS PhanTramSanPham " +
                    "FROM mathang mh JOIN nganhhang nh ON mh.idNganhHang = nh.id GROUP BY mh.idNganhHang";

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
