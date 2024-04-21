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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnC_
{
    public partial class frmHienThiHoaDonTimKiem : Form
    {
        private TimKiemHoaDonTheoNgayBUS busNgay = new TimKiemHoaDonTheoNgayBUS();
        private TimKiemHoaDonTheoTenKHBUS busTenKH = new TimKiemHoaDonTheoTenKHBUS();
        private TimKiemHoaDonChuaTTBUS busChuaTT = new TimKiemHoaDonChuaTTBUS();
        public frmHienThiHoaDonTimKiem(int loaiTimKiem, params object[] thamSo)
        {
            InitializeComponent();
            switch (loaiTimKiem)
            {
                case 1:
                    DateTime tuNgay = (DateTime)thamSo[0];
                    DateTime denNgay = (DateTime)thamSo[1];
                    ShowSearchResultTheoNgay(tuNgay, denNgay);
                    break;
                case 2:
                    string tenKhachHang = (string)thamSo[0];
                    ShowSearchResultTheoTen(tenKhachHang);
                    break;
                case 3:
                    ShowSearchResultChuaThanhToan();
                    break;
            }
        }

        private void ShowSearchResultTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = busNgay.TimKiemHoaDonTheoNgay(tuNgay, denNgay);
            lvHoaDon.Items.Clear();
            ShowSearchResult(dt);
        }

        private void ShowSearchResultTheoTen(string tenKhachHang)
        {
            DataTable dt = busTenKH.TimKiemHoaDonTheoTenKH(tenKhachHang);
            lvHoaDon.Items.Clear();
            ShowSearchResult(dt);
        }


        private void ShowSearchResultChuaThanhToan()
        {
            DataTable dt = busChuaTT.TimKiemHoaDonChuaThanhToan();
            lvHoaDon.Items.Clear();
            ShowSearchResult(dt);
        }

        private void ShowSearchResult(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["ngaytao"].ToString());
                item.SubItems.Add(row["tenkhachhang"].ToString());
                lvHoaDon.Items.Add(item);
            }
        }
    }
}
