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

namespace DoAnC_
{
    public partial class frmHienThiPhieuNhapHangTimKiem : Form
    {
        TimKiemPhieuDatHangTheoNgayBUS busNgay = new TimKiemPhieuDatHangTheoNgayBUS();
        TimKiemPhieuDatHangTheoTongTienBUS busTongTien = new TimKiemPhieuDatHangTheoTongTienBUS();
        public frmHienThiPhieuNhapHangTimKiem(int loaiTimKiem, params object[] thamSo)
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
                    Decimal giaTu = (Decimal)thamSo[0];
                    Decimal giaDen = (Decimal)thamSo[1];
                    ShowSearchResultTheoTongTien(giaTu, giaDen);
                    break;
            }
        }

        private void ShowSearchResultTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = busNgay.TimKiemPhieuDatHangTheoNgay(tuNgay, denNgay);
            lvPhieuNhapHang.Items.Clear();
            ShowSearchResult(dt);
        }

        private void ShowSearchResultTheoTongTien(Decimal giaTu, Decimal giaDen)
        {
            DataTable dt = busTongTien.TimKiemPhieuDatHangTheoTongTien(giaTu, giaDen);
            lvPhieuNhapHang.Items.Clear();
            ShowSearchResult(dt);
        }

        private void ShowSearchResult(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["tenMatHang"].ToString());
                item.SubItems.Add(row["ngayNhap"].ToString());
                item.SubItems.Add(row["soLuong"].ToString());

                decimal tongTien = Convert.ToDecimal(row["tongTien"]);
                string tongTienFormatted = string.Format("{0:N0}", tongTien);

                item.SubItems.Add(tongTienFormatted);
                lvPhieuNhapHang.Items.Add(item);
            }
        }
    }
}
