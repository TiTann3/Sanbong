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
    public partial class frmDoiSan : Form
    {
        private ArrayList sanBongList = new ArrayList();
        private SanBong sanBong;
        public frmDoiSan(SanBong sanBong)
        {
            InitializeComponent();
            this.sanBong = sanBong;
        }

        private void updateListViewSan()
        {
            ArrayList dataList = SanBongBUS.getAllSan();
            lvSanBong.Clear();
            sanBongList.Clear();

            foreach (SanBong sanBong in dataList)
            {
                if (!sanBong.dangThue)
                {
                    lvSanBong.Items.Add(sanBong.tenSan, 0);
                    sanBongList.Add(sanBong);
                }
                else
                {

                }
            }

        }

        private void btnDoiSan_Click(object sender, EventArgs e)
        {
            PhieuDatSan phieuDatSan = PhieuDatSanBUS.getLatestPhieuDatSan(sanBong.id);
            SanBong sanBongDoi = (SanBong)sanBongList[lvSanBong.SelectedIndices[0]];
            phieuDatSan.idSanBong = sanBongDoi.id;


            if (!PhieuDatSanBUS.updatePhieuDatSan(phieuDatSan))
            {
                MessageBox.Show("Thất Bại");
            }
            this.Close();
        }

        private void frmDoiSan_Load(object sender, EventArgs e)
        {
            updateListViewSan();
        }
    }
}
