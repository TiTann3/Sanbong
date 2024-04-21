using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnC_.DAO;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnC_.BUS
{
    internal class ThongKeHoaDonThanhToanBUS
    {
        private ThongKeHoaDonThanhToanDAO dao = new ThongKeHoaDonThanhToanDAO();

        public void VeBieuDoCotHoaDonThanhToan(Chart chart)
        {
            DataTable dataTable = dao.DuLieuBDC();
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Tình trạng hóa đơn";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lần";
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int thanhToan = Convert.ToInt32(dataTable.Rows[i]["daThanhToan"]);
                int soLanThanhToan = Convert.ToInt32(dataTable.Rows[i]["solanthanhtoan"]);
                String daThanhToan = "";
                if (thanhToan == 0)
                {
                    daThanhToan = "Chưa Thanh Toán";
                }
                else
                {
                    daThanhToan = "Đã Thanh Toán";
                }
                chart.Series["Series1"].Points.AddXY(daThanhToan, soLanThanhToan);
            }
        }

        public void VeBieuDoTronHoaDonThanhToan(Chart chart)
        {
            DataTable dataTable = dao.DuLieuBDT();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int thanhToan = Convert.ToInt32(dataTable.Rows[i]["daThanhToan"]);
                int soLanThanhToan = Convert.ToInt32(dataTable.Rows[i]["solanthanhtoan"]);
                String daThanhToan="";
                if(thanhToan == 0)
                {
                    daThanhToan = "Chưa Thanh Toán";
                } else
                {
                    daThanhToan = "Đã Thanh Toán";
                }
                chart.Series["Series1"].Points.AddXY(daThanhToan, (double)soLanThanhToan/100);
            }
        }
    }
}
