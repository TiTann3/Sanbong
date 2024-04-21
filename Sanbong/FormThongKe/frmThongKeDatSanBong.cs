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

namespace DoAnC_.FormThongKe
{
    public partial class frmThongKeDatSanBong : Form
    {
        private ThongKeDatSanBongBUS bus = new ThongKeDatSanBongBUS();
        public frmThongKeDatSanBong()
        {
            InitializeComponent();
        }

        private void frmThongKeDatSanBong_Load(object sender, EventArgs e)
        {
            DataTable dt = bus.LayDanhSachDonDatSanBong();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["idSanBong"].ToString());
                item.SubItems.Add(row["thoiGianBatDau"].ToString());
                item.SubItems.Add(row["soGioDat"].ToString());
                item.SubItems.Add(row["thoiGianKetThuc"].ToString());
                item.SubItems.Add(row["donGia"].ToString());
                lvPhieuDatSan.Items.Add(item);
            }
        }
    }
}
