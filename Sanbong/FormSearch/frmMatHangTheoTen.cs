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
    public partial class frmMatHangTheoTen : Form
    {
        private TimKiemMatHangTheoTenBUS bus = new TimKiemMatHangTheoTenBUS();
        public frmMatHangTheoTen()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenMatHang = txtTenMatHang.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenMatHang))
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowResultForm(1, tenMatHang);
            }
        }
        private void ShowResultForm(int loaiTimKiem, String tenMatHang)
        {
            DataTable dt = bus.TimKiemMatHangTheoTen(tenMatHang);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho tên mặt hàng đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmHienThiMatHangTimKiem resultForm = new frmHienThiMatHangTimKiem(loaiTimKiem, tenMatHang);
                resultForm.ShowDialog();
            }
        }

        private void txtTenMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
