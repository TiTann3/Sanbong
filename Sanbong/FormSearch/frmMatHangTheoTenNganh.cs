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
    public partial class frmMatHangTheoTenNganh : Form
    {
        private TimKiemMatHangTheoNganhHangBUS bus = new TimKiemMatHangTheoNganhHangBUS();
        public frmMatHangTheoTenNganh()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenNganhHang = txtTenNganh.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenNganhHang))
            {
                MessageBox.Show("Vui lòng nhập tên ngành hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowResultForm(2, tenNganhHang);
            }
        }
        private void ShowResultForm(int loaiTimKiem, String tenNganhHang)
        {
            DataTable dt = bus.TimKiemMatHangTheoNganhHang(tenNganhHang);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho tên ngành hàng đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmHienThiMatHangTimKiem resultForm = new frmHienThiMatHangTimKiem(loaiTimKiem, tenNganhHang);
                resultForm.ShowDialog();
            }
        }

        private void txtTenNganh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
