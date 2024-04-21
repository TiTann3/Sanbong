namespace DoAnC_
{
    partial class frmHienThiPhieuNhapHangTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHienThiPhieuNhapHangTimKiem));
            lvPhieuNhapHang = new ListView();
            id = new ColumnHeader();
            tenMatHang = new ColumnHeader();
            ngayNhap = new ColumnHeader();
            soLuong = new ColumnHeader();
            tongTien = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvPhieuNhapHang
            // 
            lvPhieuNhapHang.BackColor = Color.Turquoise;
            lvPhieuNhapHang.BorderStyle = BorderStyle.None;
            lvPhieuNhapHang.Columns.AddRange(new ColumnHeader[] { id, tenMatHang, ngayNhap, soLuong, tongTien });
            lvPhieuNhapHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvPhieuNhapHang.Location = new Point(12, 85);
            lvPhieuNhapHang.Name = "lvPhieuNhapHang";
            lvPhieuNhapHang.Size = new Size(585, 296);
            lvPhieuNhapHang.TabIndex = 0;
            lvPhieuNhapHang.UseCompatibleStateImageBehavior = false;
            lvPhieuNhapHang.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 40;
            // 
            // tenMatHang
            // 
            tenMatHang.Text = "Tên Mặt Hàng";
            tenMatHang.Width = 200;
            // 
            // ngayNhap
            // 
            ngayNhap.Text = "Ngày Nhập Hàng";
            ngayNhap.Width = 140;
            // 
            // soLuong
            // 
            soLuong.Text = "Số Lượng";
            soLuong.Width = 80;
            // 
            // tongTien
            // 
            tongTien.Text = "Tổng Tiền";
            tongTien.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(215, 30);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // frmHienThiPhieuNhapHangTimKiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(614, 391);
            Controls.Add(label1);
            Controls.Add(lvPhieuNhapHang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHienThiPhieuNhapHangTimKiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết Quả Tìm Kiếm Phiếu Nhập Hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPhieuNhapHang;
        private ColumnHeader id;
        private ColumnHeader tenMatHang;
        private ColumnHeader ngayNhap;
        private ColumnHeader soLuong;
        private ColumnHeader tongTien;
        private Label label1;
    }
}