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

namespace DoAnC_.FormThongKe
{
    public partial class frmThongKeHoaDonThanhToan : Form
    {
        private ThongKeHoaDonThanhToanBUS bus = new ThongKeHoaDonThanhToanBUS();
        public frmThongKeHoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void frmThongKeHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            bus.VeBieuDoCotHoaDonThanhToan(ChartBDC);
            bus.VeBieuDoTronHoaDonThanhToan(ChartBDT);
        }
    }
}
