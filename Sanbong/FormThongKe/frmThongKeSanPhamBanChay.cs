using DoAnC_.BUS;
using DoAnC_.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_.FormThongKe
{
    public partial class frmThongKeSanPhamBanChay : Form
    {
        private ThongKeSanPhamBanChayBUS bus = new ThongKeSanPhamBanChayBUS();
        public frmThongKeSanPhamBanChay()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPhamBanChay_Load(object sender, EventArgs e)
        {
            bus.LayDanhSachSanPhamBanChay(ChartBDC);
        }
    }
}
