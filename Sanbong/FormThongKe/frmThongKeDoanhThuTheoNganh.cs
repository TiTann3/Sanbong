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
    public partial class frmThongKeDoanhThuTheoNganh : Form
    {
        private ThongKeDoanhThuTheoNganhBUS bus = new ThongKeDoanhThuTheoNganhBUS();
        public frmThongKeDoanhThuTheoNganh()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThuTheoNganh_Load(object sender, EventArgs e)
        {
            bus.PhanTichDoanhThuTheoNganh(ChartBDT);
        }
    }
}
