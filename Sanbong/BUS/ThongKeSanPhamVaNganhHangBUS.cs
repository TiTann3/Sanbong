using DoAnC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnC_.BUS
{
    public class ThongKeSanPhamVaNganhHangBUS
    {
        private ThongKeSanPhamVaNganhHangDAO dao = new ThongKeSanPhamVaNganhHangDAO();

        public void VeBieuDoCotSanPhamTheoNganh(Chart chart)
        {
            DataTable dt = dao.LayDuLieuSanPhamVaNganhHang();
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên ngành hàng";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart.Series["Series1"].Points.AddXY(dt.Rows[i]["TenNganhHang"], dt.Rows[i]["SoLuongSanPham"]);
            }
        }
        public void VeBieuDoTronSanPhamTheoNganh(Chart chart)
        {
            DataTable dt = dao.LayPhanTramSanPhamVaNganhHang();
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên ngành hàng";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Phần Trăm";
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String tenNganhHang = dt.Rows[i]["TenNganhHang"].ToString();
                double phanTram = Convert.ToDouble(dt.Rows[i]["PhanTramSanPham"]);
                chart.Series["Series1"].Points.AddXY(tenNganhHang, phanTram/100);
            }
        }
    }
}