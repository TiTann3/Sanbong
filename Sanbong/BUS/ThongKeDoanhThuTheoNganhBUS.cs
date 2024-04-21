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
    public class ThongKeDoanhThuTheoNganhBUS
    {
        private ThongKeDoanhThuTheoNganhDAO dao = new ThongKeDoanhThuTheoNganhDAO();

        public void PhanTichDoanhThuTheoNganh(Chart chart)
        {
            DataTable dataTable = dao.PhanTichDoanhThuTheoNganh();
        
            chart.Series["ChartBDT"].Points.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chart.Series["ChartBDT"].Points.AddXY(dataTable.Rows[i]["tennganhhang"], dataTable.Rows[i]["doanhthu"]);
            }
        }
    }
}
