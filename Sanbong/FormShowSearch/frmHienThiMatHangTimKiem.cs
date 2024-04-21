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

namespace DoAnC_
{
    public partial class frmHienThiMatHangTimKiem : Form
    {
        TimKiemMatHangTheoTenBUS busTen = new TimKiemMatHangTheoTenBUS();
        TimKiemMatHangTheoNganhHangBUS busNganh = new TimKiemMatHangTheoNganhHangBUS();
        public frmHienThiMatHangTimKiem(int loaiTimKiem, params object[] thamSo)
        {
            InitializeComponent();
            switch (loaiTimKiem)
            {
                case 1:
                    string tenMatHang = (string)thamSo[0];
                    ShowSearchResultTheoTen(tenMatHang);
                    break;
                case 2:
                    string tenNganhHang = (string)thamSo[0];
                    ShowSearchResultTheoNganhHang(tenNganhHang);
                    break;
            }
        }

        private void ShowSearchResultTheoTen(string tenMatHang)
        {
            DataTable dt = busTen.TimKiemMatHangTheoTen(tenMatHang);
            lvMatHang.Items.Clear();
            ShowSearchResult(dt);
        }
        private void ShowSearchResultTheoNganhHang(string tenNganhHang)
        {
            DataTable dt = busNganh.TimKiemMatHangTheoNganhHang(tenNganhHang);
            lvMatHang.Items.Clear();
            ShowSearchResult(dt);
        }

        private void ShowSearchResult(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["tenMatHang"].ToString());
                item.SubItems.Add(row["tenNganhHang"].ToString());

                decimal donGia = Convert.ToDecimal(row["donGia"]);
                string donGiaFormatted = string.Format("{0:N0}", donGia);

                item.SubItems.Add(donGiaFormatted);
                item.SubItems.Add(row["soLuong"].ToString());
                lvMatHang.Items.Add(item);
            }
        }
    }
}
