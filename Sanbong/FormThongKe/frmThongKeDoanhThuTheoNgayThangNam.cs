using DoAnC_.BUS;
using DoAnC_.DAO;
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
    public partial class frmThongKeDoanhThuTheoNgayThangNam : Form
    {
        private ThongKeDoanhThuTheoNgayThangNamBUS bus = new ThongKeDoanhThuTheoNgayThangNamBUS();
        public frmThongKeDoanhThuTheoNgayThangNam()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThuTheoNgayThangNam_Load(object sender, EventArgs e)
        {
            bus.VeBieuDoDoanhThuTheoNgay(ChartBDC);

        }
    }
}
