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
    public class ThongKeSanPhamBanChayBUS
    {
        private ThongKeSanPhamBanChayDAO dao = new ThongKeSanPhamBanChayDAO();

        public void LayDanhSachSanPhamBanChay(Chart chart)
        {
            DataTable dt = dao.LayDanhSachSanPhamBanChay();
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên mặt hàng";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Tổng số lượng";
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart.Series["Series1"].Points.AddXY(dt.Rows[i]["tenMatHang"], dt.Rows[i]["TongSoLuong"]);
            }
        }
    }
}
