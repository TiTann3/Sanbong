using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DoAnC_.BUS;
using DoAnC_.DAO;
using DoAnC_.DTO;
using DTO;
using DoAnC_.FormSearch;
using DoAnC_.FormThongKe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnC_
{
    public partial class frmMain : Form
    {
        private bool isAdmin;
        private ArrayList sanBongList = new ArrayList();
        private ArrayList nganhHangList = new ArrayList();
        private ArrayList matHangList = new ArrayList();
        private ArrayList phieuDatSanList = new ArrayList();
        private ArrayList chiTietHoaDonList = new ArrayList();
        private ArrayList matHangChoList = new ArrayList();
        public frmMain(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            if (!isAdmin)
            {
                menu.Enabled = false;
                btnThemSan.Enabled = false;
                btnSuaSan.Enabled = false;
                btnXoaSan.Enabled = false;
                txtTenSan.Enabled = false;
                btnThemNganhHang.Enabled = false;
                btnQuanLyMatHang.Enabled = false;
                statusBarAddText("Chào mừng User ...");
            }
            else
            {
                statusBarAddText("Chào mừng Admin ...");
            }
        }

        private void btnThemSan_Click(object sender, EventArgs e)
        {
            if (txtTenSan.Text.Length > 0)
            {
                if (!BUS.SanBongBUS.addSan(txtTenSan.Text))
                {
                    MessageBox.Show("Không thể thêm sân, vui lòng đổi tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi thêm sân !");
                }
                else
                {
                    txtTenSan.Text = "";
                    updateListViewSan();
                    statusBarAddText("Đã thêm sân thành công !");
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm sân, vui lòng nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusBarAddText("Lỗi khi thêm sân !");
            }
        }

        void statusBarAddText(String text)
        {
            statusBar.Items[0].Text = text;
        }

        private void updateListViewSan()
        {
            ArrayList dataList = SanBongBUS.getAllSan();
            lvSanBong.Clear();
            sanBongList.Clear();

            foreach (SanBong sanBong in dataList)
            {
                sanBongList.Add(sanBong);
                if (sanBong.dangThue)
                {
                    lvSanBong.Items.Add(sanBong.tenSan, 1);
                }
                else
                {
                    lvSanBong.Items.Add(sanBong.tenSan, 0);
                }
            }
            btnSuaSan.Enabled = false;
            btnXoaSan.Enabled = false;
            tabTinhTien.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lvSanBong.Sorting = SortOrder.None;
            updateListViewSan();
            updateComboBoxNganhHang();
        }

        private void txtTenSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnThemSan_Click(sender, e);
            }
        }

        private void lvSanBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanBong.SelectedItems.Count > 0)
            {
                txtTenSan.Text = (lvSanBong.SelectedItems[0]).Text;
                if (!isAdmin)
                {
                    btnSuaSan.Enabled = false;
                    btnXoaSan.Enabled = false;
                }
                else
                {
                    btnSuaSan.Enabled = true;
                    btnXoaSan.Enabled = true;
                }
                tabTinhTien.Enabled = true;

                SanBong sanBong = ((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]);
                if (sanBong.dangThue)
                {
                    PhieuDatSan phieuDatSan = PhieuDatSanBUS.getLatestPhieuDatSan(sanBong.id);
                    txtTenKhachHang.Text = HoaDonBUS.getHoaDon(phieuDatSan.idHoaDon).tenKhachHang;
                    dtpGioVao.Value = phieuDatSan.thoiGianBatDau;
                    nudSoGio.Value = (decimal)phieuDatSan.soGioDat * 60;
                    dtpGioRa.Value = phieuDatSan.thoiGianBatDau.AddMinutes((double)phieuDatSan.soGioDat * 60);
                    btnDatSan.Enabled = false;
                    loadLvChiTietHoaDon(phieuDatSan.idHoaDon);
                    btnDoiSan.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnHuySan.Enabled = true;
                    HoaDon hoaDon = HoaDonBUS.getHoaDon(phieuDatSan.idHoaDon);
                    if (hoaDon.daThanhToan)
                    {
                        btnThanhToan.Enabled = false;
                        btnDoiSan.Enabled = false;
                        btnCapNhat.Enabled = false;
                        btnHuySan.Enabled = false;
                        gbMatHangTinhTien.Enabled = false;
                        lblThanhToan.Text = "ĐÃ THANH TOÁN";
                    }
                    else
                    {
                        btnThanhToan.Enabled = true;
                        lblThanhToan.Text = "CHƯA THANH TOÁN";
                        btnDoiSan.Enabled = true;
                        btnCapNhat.Enabled = true;
                        gbMatHangTinhTien.Enabled = true;
                    }
                }
                else
                {
                    btnDatSan.Enabled = true;
                    matHangChoList.Clear();
                    btnDoiSan.Enabled = false;
                    btnCapNhat.Enabled = false;
                    btnHuySan.Enabled = false;
                    btnThanhToan.Enabled = false;


                    gbMatHangTinhTien.Enabled = true;
                }
                txtTenSanTT.Text = sanBong.tenSan;

            }
            else
            {
                txtTenSan.Text = "";
                btnSuaSan.Enabled = false;
                btnXoaSan.Enabled = false;
                tabTinhTien.Enabled = false;
                txtTenSanTT.Text = "";
                txtTenKhachHang.Text = "";
                nudSoGio.Value = 0;
                dtpGioVao.Value = DateTime.Now;
                dtpGioRa.Value = DateTime.Now;
                txtTienSan.Text = "";
                txtTienHang.Text = "";
                nudGiamGia.Value = 0;
                lvChiTietHoaDon.Items.Clear();
                btnDoiSan.Enabled = false;
                lblThanhToan.Text = "CHƯA THANH TOÁN";
            }
            loadTinhTien(GetDtpGioVao());
        }

        void loadLvChiTietHoaDon(int idHoaDon)
        {
            chiTietHoaDonList = ChiTietHoaDonBUS.getAllChiTietHoaDon(idHoaDon);
            lvChiTietHoaDon.Items.Clear();
            matHangChoList.Clear();
            foreach (ChiTietHoaDon chiTietHoaDon in chiTietHoaDonList)
            {
                MatHang matHang = MatHangBUS.getMatHang(chiTietHoaDon.idMatHang);
                string[] row = { matHang.tenMatHang, chiTietHoaDon.soLuong.ToString(), chiTietHoaDon.donGia.ToString() };
                ListViewItem viewItem = new ListViewItem(row);
                lvChiTietHoaDon.Items.Add(viewItem);
                matHangChoList.Add(new MatHang(matHang.id, matHang.tenMatHang, matHang.idNganhHang, (int)chiTietHoaDon.donGia,
                    chiTietHoaDon.soLuong));
            }
        }

        private void btnXoaSan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sân " + lvSanBong.SelectedItems[0].Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (!SanBongBUS.deleteSan(((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]).id))
                {
                    MessageBox.Show("Không thể xóa sân " + lvSanBong.SelectedItems[0].Text, "Lỗi khi xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi xóa sân !");
                }
                else
                {
                    updateListViewSan();
                    txtTenSan.Text = "";
                    statusBarAddText("Đã xóa sân thành công !");
                    btnSuaSan.Enabled = false;
                    btnXoaSan.Enabled = false;
                    tabTinhTien.Enabled = false;
                }
            }
        }

        private void btnFormLoad_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            statusBarAddText("Dữ liệu đã được cập nhật !");
        }

        bool kiemTraTrungTen(string ten)
        {
            bool kt = true;

            foreach (SanBong sanBong in sanBongList)
            {
                if (sanBong.tenSan == ten)
                {
                    kt = false;
                    break;
                }
            }

            return kt;
        }

        private void btnSuaSan_Click(object sender, EventArgs e)
        {
            int id = ((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]).id;
            if (txtTenSan.Text != "" && kiemTraTrungTen(txtTenSan.Text))
            {
                if (SanBongBUS.updateTenSan(id, txtTenSan.Text))
                {
                    updateListViewSan();
                    statusBarAddText("Đã sửa tên sân thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể sửa tên sân!" + lvSanBong.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi sửa tên sân !");
                }
            }
            else
            {
                MessageBox.Show("Không thể sửa tên sân!" + lvSanBong.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusBarAddText("Lỗi khi sửa tên sân !");
            }
        }

        void updateComboBoxNganhHang()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            cbNhom.Items.Clear();
            nganhHangList.Clear();

            foreach (NganhHang nganhHang in dataList)
            {
                nganhHangList.Add(nganhHang);
                cbNhom.Items.Add(nganhHang.tenNganhHang);
            }
            if (cbNhom.Items.Count > 0)
            {
                cbNhom.SelectedItem = cbNhom.Items[0];
                loadMatHang(((NganhHang)nganhHangList[0]).id);
            }

        }

        private void btnThemNganhHang_Click(object sender, EventArgs e)
        {
            frmQuanLyNganhHang nhapHang = new frmQuanLyNganhHang();
            nhapHang.ShowDialog();
            updateComboBoxNganhHang();
        }

        void loadMatHang(int idNganhHang)
        {
            ArrayList dataList = MatHangBUS.getAllMatHangFromNganhHang(idNganhHang);
            lvMatHang.Items.Clear();
            matHangList.Clear();

            foreach (MatHang matHang in dataList)
            {
                matHangList.Add(matHang);
                string[] row = { matHang.tenMatHang, matHang.soLuong.ToString(), matHang.donGia.ToString() };
                ListViewItem viewItem = new ListViewItem(row);
                lvMatHang.Items.Add(viewItem);
            }
            btnThemHang.Enabled = false;
        }

        private void lvMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMatHang.SelectedItems.Count > 0)
            {
                txtMatHangTinhTien.Text = lvMatHang.SelectedItems[0].Text;
                nudSoLuongTinhTien.Maximum = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong;
                if (nudSoLuongTinhTien.Maximum > 0)
                {
                    nudSoLuongTinhTien.Value = 1;
                }
                txtDonGiaTinhTien.Text = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).donGia.ToString();
                loadTinhTien(GetDtpGioVao());

                btnThemHang.Enabled = true;
            }
            else
            {
                btnThemHang.Enabled = false;
            }
        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMatHang(((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id);
        }

        private void nudSoLuongTinhTien_KeyUp(object sender, KeyEventArgs e)
        {
            if (nudSoLuongTinhTien.Value > nudSoLuongTinhTien.Maximum)
            {
                MessageBox.Show("Vượt quá số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuongTinhTien.Value = nudSoLuongTinhTien.Maximum;

            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapMatHang nhapMatHang = new frmNhapMatHang();
            nhapMatHang.ShowDialog();
            loadMatHang(((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id);
        }

        private void btnQuanLyMatHang_Click(object sender, EventArgs e)
        {
            frmQuanLyMatHang fQuanLyMatHang = new frmQuanLyMatHang();
            fQuanLyMatHang.ShowDialog();
            loadMatHang(((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id);
        }

        int kiemTraMatHang(MatHang matHang)
        {
            //-1 khi khong ton tai mat hang nao truoc
            int pos = -1;

            for (int i = 0; i < matHangChoList.Count; i++)
            {
                if (((MatHang)matHangChoList[i]).id == matHang.id)
                {
                    pos = i;
                    return pos;
                }
            }

            return pos;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            MatHang matHang = (MatHang)matHangList[lvMatHang.SelectedIndices[0]];
            int pos = kiemTraMatHang(matHang);
            if (pos == -1)
            {
                matHangChoList.Insert(0, new MatHang(matHang.id, matHang.tenMatHang, matHang.idNganhHang, matHang.donGia,
                    Convert.ToInt32(nudSoLuongTinhTien.Value)));
                string[] row = { matHang.tenMatHang, nudSoLuongTinhTien.Value.ToString(), matHang.donGia.ToString() };
                ListViewItem viewItem = new ListViewItem(row);
                lvChiTietHoaDon.Items.Add(viewItem);
            }
            else
            {
                MatHang matHang1 = (MatHang)matHangChoList[pos];
                ((MatHang)matHangChoList[pos]).soLuong = matHang1.soLuong + Convert.ToInt32(nudSoLuongTinhTien.Value);
                lvChiTietHoaDon.Items.Clear();
                foreach (MatHang matHang2 in matHangChoList)
                {
                    string[] row = { matHang2.tenMatHang, matHang2.soLuong.ToString(), matHang2.donGia.ToString() };
                    ListViewItem viewItem = new ListViewItem(row);
                    lvChiTietHoaDon.Items.Add(viewItem);
                }
            }

            lvMatHang.SelectedItems[0].SubItems[1].Text = (Convert.ToInt32(lvMatHang.SelectedItems[0].SubItems[1].Text) -
                (int)nudSoLuongTinhTien.Value).ToString();
            ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong += -(int)nudSoLuongTinhTien.Value;

            int id = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).id;
            int idNganhHang = ((NganhHang)nganhHangList[cbNhom.SelectedIndex]).id;
            double donGia = Convert.ToSingle(txtDonGiaTinhTien.Text);
            MatHangBUS.updateMatHang(new MatHang(id, txtMatHangTinhTien.Text, idNganhHang, donGia, ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong));
            nudSoLuongTinhTien.Maximum = ((MatHang)matHangList[lvMatHang.SelectedIndices[0]]).soLuong;
            loadTinhTien(GetDtpGioVao());
        }

        private void nudSoGio_ValueChanged(object sender, EventArgs e)
        {
            dtpGioRa.Value = dtpGioVao.Value.AddMinutes((double)nudSoGio.Value);
            loadTinhTien(GetDtpGioVao());
            if (nudSoGio.Value == 0)
            {
                txtTienSan.Text = "";
            }
        }

        private DateTimePicker GetDtpGioVao()
        {
            return dtpGioVao;
        }

        void loadTinhTien(DateTimePicker dtpGioVao)
        {
            if (lvSanBong.SelectedItems.Count > 0)
            {
                double donGia;

                TimeSpan gioVao = dtpGioVao.Value.TimeOfDay; // Lấy giờ vào từ DateTimePicker

                // Xác định giá tiền theo khung giờ
                if (gioVao >= TimeSpan.FromHours(6) && gioVao < TimeSpan.FromHours(16))
                {
                    donGia = 200000;
                }
                else if (gioVao >= TimeSpan.FromHours(16) && gioVao < TimeSpan.FromHours(20))
                {
                    donGia = 240000;
                }
                else if (gioVao >= TimeSpan.FromHours(20) && gioVao < TimeSpan.FromHours(22))
                {
                    donGia = 260000;
                }
                else
                {
                    donGia = 280000;
                }

                double tienSan = donGia * ((double)nudSoGio.Value / 60);
                txtTienSan.Text = tienSan.ToString();
                double tienHang = 0;
                foreach (MatHang matHang in matHangChoList)
                {
                    tienHang += matHang.donGia * matHang.soLuong;
                }
                txtTienHang.Text = tienHang.ToString();
                double giamGia = (double)nudGiamGia.Value;
                double tongTien = (double)(tienSan + tienHang) * (100 - giamGia) / 100;
                txtThanhToan.Text = tongTien.ToString();
                double khachDua = (double)nudKhachDua.Value;
                if (khachDua > 0)
                {

                    txtTienThoi.Text = (khachDua - tongTien).ToString();
                }
            }
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nudSoGio.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số phút đặt sân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nudKhachDua.Value == 0 || nudKhachDua.Value < Convert.ToInt32(txtThanhToan.Text))
            {
                MessageBox.Show("Tiền khách đưa không đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TimeSpan gioVao = dtpGioVao.Value.TimeOfDay;
            HoaDonBUS.addHoaDon(new HoaDon(0, DateTime.Now, txtTenKhachHang.Text, false));
            HoaDon hoaDon = HoaDonBUS.getLastHoaDon();
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];

            double donGia;


            if (gioVao >= TimeSpan.FromHours(6) && gioVao < TimeSpan.FromHours(16))
            {
                donGia = 200000;
            }
            else if (gioVao >= TimeSpan.FromHours(16) && gioVao < TimeSpan.FromHours(20))
            {
                donGia = 240000;
            }
            else if (gioVao >= TimeSpan.FromHours(20) && gioVao < TimeSpan.FromHours(22))
            {
                donGia = 260000;
            }
            else
            {
                donGia = 280000;
            }
            DateTime gioRa = dtpGioRa.Value;
            double tienSan = donGia * ((double)nudSoGio.Value / 60);
            PhieuDatSanBUS.addPhieuDatSan(new PhieuDatSan(0, sanBong.id, dtpGioVao.Value, (double)nudSoGio.Value / 60,
                gioRa, tienSan, hoaDon.id));
            updateListViewSan();
            if (lvChiTietHoaDon.Items.Count > 0)
            {
                foreach (MatHang matHang in matHangChoList)
                {
                    ChiTietHoaDonBUS.addChiTietHoaDon(new ChiTietHoaDon(0, hoaDon.id, matHang.id, matHang.soLuong,
                        matHang.donGia));
                }
            }
            btnDatSan.Enabled = false;
        }

        private void lvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChiTietHoaDon.SelectedItems.Count > 0)
            {
                btnXoaHang.Enabled = true;
            }
            else
            {
                btnXoaHang.Enabled = false;
            }
        }

        private void nudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            loadTinhTien(dtpGioVao);
        }

        private void nudKhachDua_ValueChanged(object sender, EventArgs e)
        {
            loadTinhTien(dtpGioVao);
        }

        private void nudKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                loadTinhTien(dtpGioVao);
            }
        }

        int matHangInChiTietHoaDon(MatHang matHang)
        {
            int pos = -1;
            for (int i = 0; i < chiTietHoaDonList.Count; i++)
            {
                if (((ChiTietHoaDon)chiTietHoaDonList[i]).idMatHang == matHang.id)
                {
                    pos = i;
                    return pos;
                }
            }
            return pos;
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            if (lvChiTietHoaDon.SelectedIndices.Count > 0)
            {
                MatHang matHang = (MatHang)matHangChoList[lvChiTietHoaDon.SelectedIndices[0]];
                int pos = matHangInChiTietHoaDon(matHang);

                if (pos != -1)
                {
                    ChiTietHoaDon chiTietHoaDon = (ChiTietHoaDon)chiTietHoaDonList[pos];
                    ChiTietHoaDonBUS.deleteChiTietHoaDon(chiTietHoaDon.id);

                    chiTietHoaDonList.RemoveAt(pos);
                }
                matHangChoList.RemoveAt(lvChiTietHoaDon.SelectedIndices[0]);
                lvChiTietHoaDon.Items.RemoveAt(lvChiTietHoaDon.SelectedIndices[0]);
                double tienHang = 0;
                foreach (MatHang mathang in matHangChoList)
                {
                    tienHang += mathang.donGia * mathang.soLuong;
                }
                txtTienHang.Text = tienHang.ToString();

                for (int i = 0; i < matHangList.Count; i++)
                {
                    if (matHang.id == ((MatHang)matHangList[i]).id)
                    {
                        ((MatHang)matHangList[i]).soLuong += matHang.soLuong;
                        lvMatHang.Items[i].SubItems[1].Text = ((MatHang)matHangList[i]).soLuong.ToString();
                        MatHangBUS.updateMatHang((MatHang)matHangList[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDoiSan_Click(object sender, EventArgs e)
        {
            frmDoiSan fDoiSan = new frmDoiSan((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]);
            fDoiSan.ShowDialog();
            frmMain_Load(sender, e);
        }

        int kiemTraChiTietHoaDon(int idMatHang)
        {

            for (int i = 0; i < chiTietHoaDonList.Count; i++)
            {
                if (((ChiTietHoaDon)chiTietHoaDonList[i]).idMatHang == idMatHang)
                {

                    return i;
                }
            }

            return -1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            PhieuDatSan phieuDatSanBong = PhieuDatSanBUS.getLatestPhieuDatSan(sanBong.id);
            HoaDon hoaDon = HoaDonBUS.getHoaDon(phieuDatSanBong.idHoaDon);
            int pos;
            foreach (MatHang matHang in matHangChoList)
            {
                pos = kiemTraChiTietHoaDon(matHang.id);
                if (pos == -1)
                {
                    ChiTietHoaDonBUS.addChiTietHoaDon(new ChiTietHoaDon(0, hoaDon.id, matHang.id, matHang.soLuong, matHang.donGia));
                }
                else
                {
                    ((ChiTietHoaDon)chiTietHoaDonList[pos]).soLuong = matHang.soLuong;
                    ChiTietHoaDonBUS.updateChiTietHoaDon((ChiTietHoaDon)chiTietHoaDonList[pos]);
                }
            }
            hoaDon.tenKhachHang = txtTenKhachHang.Text;
            HoaDonBUS.updateHoaDon(hoaDon);
            phieuDatSanBong.thoiGianBatDau = dtpGioVao.Value;
            phieuDatSanBong.soGioDat = (double)nudSoGio.Value / 60;

            PhieuDatSanBUS.updatePhieuDatSan(phieuDatSanBong);
        }

        private void btnHuySan_Click(object sender, EventArgs e)
        {
            if (lvChiTietHoaDon.Items.Count > 0)
            {
                MessageBox.Show("Hãy xóa hàng trước khi hủy sân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
                PhieuDatSan phieuDatSanBong = PhieuDatSanBUS.getLatestPhieuDatSan(sanBong.id);

                if (HoaDonBUS.deleteHoaDon(phieuDatSanBong.idHoaDon) && PhieuDatSanBUS.deletePhieuDatSan(phieuDatSanBong.id))
                {
                    statusBarAddText("Hủy sân thành công");
                    txtTenKhachHang.Text = "";
                    nudSoGio.Value = 0;
                    txtTienSan.Text = "";
                    txtTienHang.Text = "";
                    nudGiamGia.Value = 0;
                    txtThanhToan.Text = "";
                    txtTienThoi.Text = "";
                    nudKhachDua.Value = 0;
                    updateListViewSan();
                }
                else
                {
                    MessageBox.Show("Không thể hủy sân!" + lvSanBong.SelectedItems[0].Text, "Lỗi khi hủy sân",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusBarAddText("Lỗi khi hủy sân !");
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            SanBong sanBong = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            PhieuDatSan phieuDatSanBong = PhieuDatSanBUS.getLatestPhieuDatSan(sanBong.id);
            HoaDon hoaDon = HoaDonBUS.getHoaDon(phieuDatSanBong.idHoaDon);
            hoaDon.daThanhToan = true;
            HoaDonBUS.updateHoaDon(hoaDon);
            lblThanhToan.Text = "ĐÃ THANH TOÁN";
            btnThanhToan.Enabled = false;
        }

        private void theoNgàyTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoNgayTao hoaDonTheoNgayTao = new frmHoaDonTheoNgayTao();
            hoaDonTheoNgayTao.ShowDialog();
        }

        private TimKiemHoaDonChuaTTBUS bus = new TimKiemHoaDonChuaTTBUS();
        private void chưaThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = bus.TimKiemHoaDonChuaThanhToan();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả cho các hóa đơn chưa thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ShowResultForm(3);
            }
        }
        private void ShowResultForm(int loaiTimKiem)
        {
            frmHienThiHoaDonTimKiem resultForm = new frmHienThiHoaDonTimKiem(loaiTimKiem);
            resultForm.ShowDialog();
        }

        private void theoTênKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoTenKhachHang hoaDonTheoTenKhachHang = new frmHoaDonTheoTenKhachHang();
            hoaDonTheoTenKhachHang.ShowDialog();
        }

        private void theoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHangTheoTen matHangTheoTen = new frmMatHangTheoTen();
            matHangTheoTen.ShowDialog();
        }

        private void theoNgànhHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHangTheoTenNganh matHangTheoNganh = new frmMatHangTheoTenNganh();
            matHangTheoNganh.ShowDialog();
        }

        private void theoThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDatSanTheoNgay phieuDatSanTheoNgay = new frmPhieuDatSanTheoNgay();
            phieuDatSanTheoNgay.ShowDialog();
        }

        private void theoTổngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDatSanTheoDonGia phieuDatSanTheoDonGia = new frmPhieuDatSanTheoDonGia();
            phieuDatSanTheoDonGia.ShowDialog();
        }

        private void theoNgàyNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhapHangTheoNgay phieuNhapHangTheoNgay = new frmPhieuNhapHangTheoNgay();
            phieuNhapHangTheoNgay.ShowDialog();
        }

        private void theoĐơnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhapHangTheoTongTien phieuNhapHangTheoTongTien = new frmPhieuNhapHangTheoTongTien();
            phieuNhapHangTheoTongTien.ShowDialog();
        }

        private void thốngKêDoanhThuTheoNgàyThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThuTheoNgayThangNam thongKeDoanhThuTheoNgayThangNam = new frmThongKeDoanhThuTheoNgayThangNam();
            thongKeDoanhThuTheoNgayThangNam.ShowDialog();
        }

        private void thốngKêSảnPhẩmBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeSanPhamBanChay thongKeSanPhamBanChay = new frmThongKeSanPhamBanChay();
            thongKeSanPhamBanChay.ShowDialog();
        }

        private void thốngKêDoanhThuTheoNgànhHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThuTheoNganh thongKeDoanhThuTheoNganh = new frmThongKeDoanhThuTheoNganh();
            thongKeDoanhThuTheoNganh.ShowDialog();
        }

        private void thốngKêĐặtSânBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeDatSanBong datSanBong = new frmThongKeDatSanBong();
            datSanBong.ShowDialog();
        }

        private void phânTíchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang khachHang = new frmThongKeKhachHang();
            khachHang.ShowDialog();
        }

        private void tổngQuanVềSảnPhẩmVàNgànhHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeSanPhamVaNganhHang sanPhamVaNganhHang = new frmThongKeSanPhamVaNganhHang();
            sanPhamVaNganhHang.ShowDialog();
        }

        private void thốngKêCácHóaĐơnChưaThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeHoaDonThanhToan hoaDonThanhToan = new frmThongKeHoaDonThanhToan();
            hoaDonThanhToan.ShowDialog();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            SanBong sanBong = ((SanBong)sanBongList[lvSanBong.SelectedIndices[0]]);
            PhieuDatSan phieuDatSan = PhieuDatSanBUS.getLatestPhieuDatSan(sanBong.id);
            int idHoaDon = phieuDatSan.idHoaDon;
            frmInHoaDon inHoaDon = new frmInHoaDon(idHoaDon);
            inHoaDon.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }
    }
}
