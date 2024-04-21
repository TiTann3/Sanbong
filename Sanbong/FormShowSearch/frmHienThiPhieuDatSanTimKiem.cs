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
    public partial class frmHienThiPhieuDatSanTimKiem : Form
    {
        TimKiemPhieuDatSanTheoNgayBUS busNgay = new TimKiemPhieuDatSanTheoNgayBUS();
        TimKiemPhieuDatSanTheoDonGiaBUS busDonGia = new TimKiemPhieuDatSanTheoDonGiaBUS();
        public frmHienThiPhieuDatSanTimKiem(int loaiTimKiem, params object[] thamSo)
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
                    ShowSearchResultTheoDonGia(giaTu, giaDen);
                    break;
            }

        }

        private void ShowSearchResultTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = busNgay.TimKiemPhieuDatSanTheoThoiGian(tuNgay, denNgay);
            lvPhieuDatSan.Items.Clear();
            ShowSearchResult(dt);
        }
        private void ShowSearchResultTheoDonGia(Decimal giaTu, Decimal giaDen)
        {
            DataTable dt = busDonGia.TimKiemPhieuDatSanTheoDonGia(giaTu, giaDen);
            lvPhieuDatSan.Items.Clear();
            ShowSearchResult(dt);
        }

        private void ShowSearchResult(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["idSanBong"].ToString());
                item.SubItems.Add(row["thoiGianBatDau"].ToString());
                item.SubItems.Add(row["soGioDat"].ToString());
                item.SubItems.Add(row["thoiGianKetThuc"].ToString());

                decimal donGia = Convert.ToDecimal(row["donGia"]);
                string donGiaFormatted = string.Format("{0:N0}", donGia);

                item.SubItems.Add(donGiaFormatted);
                lvPhieuDatSan.Items.Add(item);
            }
        }
    }
}
