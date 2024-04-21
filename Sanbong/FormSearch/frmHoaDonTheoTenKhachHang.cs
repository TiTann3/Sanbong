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
using static DoAnC_.FormSearch.frmHoaDonTheoNgayTao;

namespace DoAnC_.FormSearch
{
    public partial class frmHoaDonTheoTenKhachHang : Form
    {
        private TimKiemHoaDonTheoTenKHBUS bus = new TimKiemHoaDonTheoTenKHBUS();
        public frmHoaDonTheoTenKhachHang()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenKhachHang))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowResultForm(2, tenKhachHang);
            }
        }


        private void ShowResultForm(int loaiTimKiem, String tenKhachHang)
        {
            DataTable dt = bus.TimKiemHoaDonTheoTenKH(tenKhachHang);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho tên khách hàng đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmHienThiHoaDonTimKiem resultForm = new frmHienThiHoaDonTimKiem(loaiTimKiem, tenKhachHang);
                resultForm.ShowDialog();
            }

        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
