using DoAnC_.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnC_.FormThongKe
{
    public partial class frmThongKeKhachHang : Form
    {
        private ThongKeKhachHangBUS bus = new ThongKeKhachHangBUS();
        public frmThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            bus.PhanTichThongTinKhachHang(ChartBDC);
        }
    }
}
