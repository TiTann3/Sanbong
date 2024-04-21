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
    public partial class frmPhieuDatSanTheoDonGia : Form
    {
        TimKiemPhieuDatSanTheoDonGiaBUS bus = new TimKiemPhieuDatSanTheoDonGiaBUS();
        public frmPhieuDatSanTheoDonGia()
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
            DataTable dt = bus.TimKiemPhieuDatSanTheoDonGia(giaTu, giaDen);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho đơn giá tìm kiếm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmHienThiPhieuDatSanTimKiem hienThiPhieuDatSanTimKiem = new frmHienThiPhieuDatSanTimKiem(loaiTimKiem, giaTu, giaDen);
                hienThiPhieuDatSanTimKiem.ShowDialog();
            }
        }

        private void nudGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
