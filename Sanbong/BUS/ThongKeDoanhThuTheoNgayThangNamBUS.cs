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
    public class ThongKeDoanhThuTheoNgayThangNamBUS
    {
        private ThongKeDoanhThuTheoNgayThangNamDAO dao = new ThongKeDoanhThuTheoNgayThangNamDAO();

        public void VeBieuDoDoanhThuTheoNgay(Chart chart)
        {
            DataTable dataTable = dao.LayDoanhThuTheoNgayThangNam();
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            chart.Series.Add("EX");
            chart.Series["EX"].Color = Color.Red;
            chart.Series["EX"].LegendText = "Đường biểu diễn";
            chart.Series["EX"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chart.Series["Series1"].Points.AddXY(dataTable.Rows[i]["ngay"], dataTable.Rows[i]["doanhthu"]);
                chart.Series["EX"].Points.AddXY(dataTable.Rows[i]["ngay"], dataTable.Rows[i]["doanhthu"]);

            }
        }
    }
}
