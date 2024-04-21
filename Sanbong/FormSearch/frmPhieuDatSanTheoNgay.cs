using DoAnC_.BUS;
using DoAnC_.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_.FormSearch
{
    public partial class frmPhieuDatSanTheoNgay : Form
    {
        TimKiemPhieuDatSanTheoNgayBUS bus = new TimKiemPhieuDatSanTheoNgayBUS();
        public frmPhieuDatSanTheoNgay()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            ShowResultForm(1, tuNgay, denNgay);
        }

        private void ShowResultForm(int loaiTimKiem, DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = bus.TimKiemPhieuDatSanTheoThoiGian(tuNgay, denNgay);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho ngày tìm kiếm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmHienThiPhieuDatSanTimKiem phieuDatSanTimKiem = new frmHienThiPhieuDatSanTimKiem(loaiTimKiem, tuNgay, denNgay);
                phieuDatSanTimKiem.ShowDialog();
            }
        }
    }
}
