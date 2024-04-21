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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnC_
{
    public partial class frmInHoaDon : Form
    {
        InHoaDonBUS bus = new InHoaDonBUS();
        public frmInHoaDon(int idHoaDon)
        {
            InitializeComponent();
            ShowTenKhachHang(idHoaDon);
            ShowIdSanBong(idHoaDon);
            ShowNgayTao(idHoaDon);
            ShowSoGio(idHoaDon);
            ShowDonGia(idHoaDon);
            ShowMatHang(idHoaDon);
            ShowTongCong(idHoaDon);
        }
        private void ShowTenKhachHang(int idHoaDon)
        {
            DataTable dt = bus.getDauHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["tenKhachHang"].ToString());
                lvTenKhachHang.Items.Add(item);
            }
        }
        private void ShowIdSanBong(int idHoaDon)
        {
            DataTable dt = bus.getDauHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["idSanBong"].ToString());
                lvIdSanBong.Items.Add(item);
            }
        }
        private void ShowNgayTao(int idHoaDon)
        {
            DataTable dt = bus.getDauHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ngayHoaDon"].ToString());
                lvNgayTao.Items.Add(item);
            }
        }

        private void ShowSoGio(int idHoaDon)
        {
            DataTable dt = bus.getDauHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["soGioDat"].ToString());
                lvSoGioDat.Items.Add(item);
            }
        }
        private void ShowDonGia(int idHoaDon)
        {
            DataTable dt = bus.getDauHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                decimal donGia = Convert.ToDecimal(row["donGia"]);
                string donGiaFormatted = string.Format("{0:N0}", donGia);
                ListViewItem item = new ListViewItem(donGiaFormatted);
                lvDonGia.Items.Add(item);
            }
        }
        private void ShowMatHang(int idHoaDon)
        {
            DataTable dt = bus.getCuoiHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["tenMatHang"].ToString());
                item.SubItems.Add(row["soLuong"].ToString());
                decimal donGia = Convert.ToDecimal(row["donGia"]);
                string donGiaFormatted = string.Format("{0:N0}", donGia);
                item.SubItems.Add(donGiaFormatted);
                lvMatHang.Items.Add(item);
            }
        }
        private void ShowTongCong(int idHoaDon)
        {
            DataTable dt = bus.getTongDonGia(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                decimal donGia = Convert.ToDecimal(row["tongCong"]);
                string donGiaFormatted = string.Format("{0:N0}", donGia);
                ListViewItem item = new ListViewItem(donGiaFormatted);
                lvTongCong.Items.Add(item);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when printing ! " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
