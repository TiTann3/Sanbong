using DoAnC_.BUS;
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
    public partial class frmQuanLyNganhHang : Form
    {
        private ArrayList nganhHangList = new ArrayList();
        public frmQuanLyNganhHang()
        {
            InitializeComponent();
        }

        private void updateListViewSan()
        {
            ArrayList dataList = NganhHangBUS.getAllNganhHang();
            lvNganhHang.Clear();
            nganhHangList.Clear();

            foreach (NganhHang nganhHang in dataList)
            {
                nganhHangList.Add(nganhHang);
                lvNganhHang.Items.Add(nganhHang.tenNganhHang, 0);
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmQuanLyNganhHang_Load(object sender, EventArgs e)
        {
            updateListViewSan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNganhHang.Text.Length > 0)
            {
                if (kiemTraTrungTen(txtTenNganhHang.Text))
                {
                    if (!BUS.NganhHangBUS.addNganhHang(txtTenNganhHang.Text))
                    {
                        MessageBox.Show("Không thể thêm ngành hàng, vui lòng đổi tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        txtTenNganhHang.Text = "";
                        updateListViewSan();

                    }
                }
                else
                {
                    MessageBox.Show("Không thể thêm ngành hàng, vui lòng đổi tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm ngành hàng, vui lòng nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        bool kiemTraTrungTen(string ten)
        {
            bool kt = true;

            foreach (NganhHang nganhHang in nganhHangList)
            {
                if (nganhHang.tenNganhHang == ten)
                {
                    kt = false;
                    break;
                }
            }

            return kt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = ((NganhHang)nganhHangList[lvNganhHang.SelectedIndices[0]]).id;
            if (txtTenNganhHang.Text != "" && kiemTraTrungTen(txtTenNganhHang.Text))
            {
                if (NganhHangBUS.updateTenNganhHang(id, txtTenNganhHang.Text))
                {
                    updateListViewSan();

                }
                else
                {
                    MessageBox.Show("Không thể sửa tên ngành hàng!" + lvNganhHang.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Không thể sửa tên ngành hàng!" + lvNganhHang.SelectedItems[0].Text, "Lỗi khi sửa tên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lvNganhHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNganhHang.SelectedItems.Count > 0)
            {
                txtTenNganhHang.Text = (lvNganhHang.SelectedItems[0]).Text;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                txtTenNganhHang.Text = "";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa ngành hàng " + lvNganhHang.SelectedItems[0].Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (!NganhHangBUS.deleteNganhHang(((NganhHang)nganhHangList[lvNganhHang.SelectedIndices[0]]).id))
                {
                    MessageBox.Show("Không thể xóa ngành hàng " + lvNganhHang.SelectedItems[0].Text, "Lỗi khi xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    updateListViewSan();
                    txtTenNganhHang.Text = "";
                    btnSua.Enabled = false;
                }
            }
        }

        private void txtTenNganhHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnThem_Click(sender, e);
            }
        }
    }
}
