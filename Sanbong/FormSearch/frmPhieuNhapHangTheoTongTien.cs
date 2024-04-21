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

namespace DoAnC_.FormSearch
{
    public partial class frmPhieuNhapHangTheoTongTien : Form
    {
        TimKiemPhieuDatHangTheoTongTienBUS bus = new TimKiemPhieuDatHangTheoTongTienBUS();
        public frmPhieuNhapHangTheoTongTien()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Decimal giaTu = nudGiaTu.Value;
            Decimal giaDen = nudGiaDen.Value;
            ShowResultForm(2, giaTu, giaDen);
        }

        private void ShowResultForm(int loaiTimKiem, Decimal giaTu, Decimal giaDen)
        {
            DataTable dt = bus.TimKiemPhieuDatHangTheoTongTien(giaTu, giaDen);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho tổng tiền đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmHienThiPhieuNhapHangTimKiem phieuNhapHangTimKiem = new frmHienThiPhieuNhapHangTimKiem(loaiTimKiem, giaTu, giaDen);
                phieuNhapHangTimKiem.ShowDialog();
            }
        }

        private void nudGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void frmPhieuNhapHangTheoTongTien_Load(object sender, EventArgs e)
        {

        }
    }
}
