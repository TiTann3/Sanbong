using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using DoAnC_.DAO;

namespace DoAnC_.BUS
{
    public class ThongKeKhachHangBUS
    {
        private ThongKeKhachHangDAO dao = new ThongKeKhachHangDAO();

        public void PhanTichThongTinKhachHang(Chart chart)
        {
            DataTable dataTable = dao.PhanTichThongTinKhachHang();
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên khách hàng/Số lần đặt sân";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            chart.Series["Series2"]["DrawingStyle"] = "Cylinder";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chart.Series["Series1"].Points.AddXY(dataTable.Rows[i]["tenKhachHang"], dataTable.Rows[i]["tongdoanhthu"]);
                chart.Series["Series2"].Points.AddXY("", dataTable.Rows[i]["solanmuahang"]);
            }
        }
    }
}
