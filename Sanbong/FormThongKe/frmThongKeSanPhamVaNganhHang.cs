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
    public partial class frmThongKeSanPhamVaNganhHang : Form
    {
        private ThongKeSanPhamVaNganhHangBUS bus = new ThongKeSanPhamVaNganhHangBUS();
        public frmThongKeSanPhamVaNganhHang()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPhamVaNganhHang_Load(object sender, EventArgs e)
        {
            bus.VeBieuDoCotSanPhamTheoNganh(ChartBDC);
            bus.VeBieuDoTronSanPhamTheoNganh(ChartBDT);
        }
    }
}
