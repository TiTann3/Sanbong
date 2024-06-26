﻿using DoAnC_.BUS;
using DoAnC_.DAO;
using DoAnC_.DTO;
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

namespace DoAnC_
{
    public partial class frmNhapMatHang : Form
    {

        private ArrayList nganhHangList = new ArrayList();
        private ArrayList matHangList = new ArrayList();
        private ArrayList phieuNhapHangList = new ArrayList();
        public frmNhapMatHang()
        {
            InitializeComponent();
        }

        private void lvNhapHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhapHang.SelectedItems.Count > 0)
            {

                btnXoa.Enabled = true;
            }
            else
            {

                btnXoa.Enabled = false;
            }
        }

        private void frmNhapMatHang_Load(object sender, EventArgs e)
        {
            updateNganhHang();
            updateLvPhieuNhapHang();
        }

        void updateLvPhieuNhapHang()
        {
            btnXoa.Enabled = false;

            ArrayList dataList = PhieuNhapHangBUS.getAllPhieuNhapHang();
            lvNhapHang.Items.Clear();
            phieuNhapHangList.Clear();
            //MessageBox.Show("" + dataList.Count);
            foreach (PhieuNhapHang phieuNhap in dataList)
            {
                phieuNhapHangList.Add(phieuNhap);
                MatHang matHang = MatHangBUS.getMatHang(phieuNhap.idMatHang);
                if (matHang != null)
                {
                    string[] row = { phieuNhap.id+"", matHang.tenMatHang, phieuNhap.ngayNhap.ToString(), phieuNhap.soLuong.ToString(),
                    phieuNhap.tongTien.ToString()};
                    var listViewItem = new ListViewItem(row);
                    lvNhapHang.Items.Add(listViewItem);
                }
            }
        }

        void updateNganhHang()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            cbNganhHang.Items.Clear();
            nganhHangList.Clear();
            cbMatHang.Items.Clear();

            foreach (NganhHang nganhHang in dataList)
            {
                nganhHangList.Add(nganhHang);
                cbNganhHang.Items.Add(nganhHang.tenNganhHang);
            }
            if (cbNganhHang.Items.Count > 0)
            {
                cbNganhHang.SelectedItem = cbNganhHang.Items[0];
                loadMatHang(((NganhHang)nganhHangList[cbNganhHang.SelectedIndex]).id);
            }
            else
            {
                cbMatHang.Enabled = false;
            }
            btnXoa.Enabled = false;
        }

        void loadMatHang(int idNganhHang)
        {
            ArrayList dataList = MatHangBUS.getAllMatHangFromNganhHang(idNganhHang);
            cbMatHang.Items.Clear();
            matHangList.Clear();
            cbMatHang.Text = "";

            foreach (MatHang matHang in dataList)
            {
                matHangList.Add(matHang);
                cbMatHang.Items.Add(matHang.tenMatHang);
            }

        }

        private void cbNganhHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNganhHang.Items.Count > 0)
            {
                loadMatHang(((NganhHang)nganhHangList[cbNganhHang.SelectedIndex]).id);
            }
            else
            {
                cbMatHang.Items.Clear();
                matHangList.Clear();
                cbMatHang.Text = "";
            }
        }

        bool matHangNotExist(string tenMatHang)
        {
            bool kt = true;
            foreach (MatHang matHang in matHangList)
            {
                if (matHang.tenMatHang.Equals(tenMatHang))
                {
                    kt = false;
                }
            }
            return kt;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int idMatHang = ((MatHang)matHangList[cbMatHang.SelectedIndex]).id;
            DateTime ngayNhap = dtpNgayNhap.Value;
            int soLuong = (int)nudSoLuong.Value;
            float tongTien = (float)nudTongTien.Value;
            PhieuNhapHang phieuNhap = new PhieuNhapHang(idMatHang, ngayNhap, soLuong, tongTien);
            PhieuNhapHangBUS.addPhieuNhapHang(phieuNhap);
            MatHangDAO.updateSoLuongMatHang(idMatHang, ((MatHang)matHangList[cbMatHang.SelectedIndex]).soLuong + soLuong);
            updateLvPhieuNhapHang();
            loadMatHang(((NganhHang)nganhHangList[cbNganhHang.SelectedIndex]).id);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa phiếu " + lvNhapHang.SelectedItems[0].Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = ((PhieuNhapHang)phieuNhapHangList[lvNhapHang.SelectedIndices[0]]).id;
                if (!PhieuNhapHangBUS.deletePhieuNhapHang(id))
                {
                    MessageBox.Show("Không thể xóa phiếu " + lvNhapHang.SelectedItems[0].Text, "Lỗi khi xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    updateLvPhieuNhapHang();
                    btnXoa.Enabled = false;
                }
            }
        }
    }
}
