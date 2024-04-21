namespace DoAnC_
{
    partial class frmHienThiMatHangTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHienThiMatHangTimKiem));
            label1 = new Label();
            lvMatHang = new ListView();
            id = new ColumnHeader();
            tenMatHang = new ColumnHeader();
            tenNganhHang = new ColumnHeader();
            donGia = new ColumnHeader();
            soLuong = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(214, 40);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // lvMatHang
            // 
            lvMatHang.BackColor = Color.Turquoise;
            lvMatHang.BorderStyle = BorderStyle.None;
            lvMatHang.Columns.AddRange(new ColumnHeader[] { id, tenMatHang, tenNganhHang, donGia, soLuong });
            lvMatHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvMatHang.Location = new Point(39, 96);
            lvMatHang.Name = "lvMatHang";
            lvMatHang.Size = new Size(533, 269);
            lvMatHang.TabIndex = 1;
            lvMatHang.UseCompatibleStateImageBehavior = false;
            lvMatHang.View = View.Details;
            // 
            // id
            // 
            id.Text = "Id";
            id.Width = 30;
            // 
            // tenMatHang
            // 
            tenMatHang.Text = "Tên Mặt Hàng";
            tenMatHang.Width = 160;
            // 
            // tenNganhHang
            // 
            tenNganhHang.Text = "Tên Ngành Hàng";
            tenNganhHang.Width = 160;
            // 
            // donGia
            // 
            donGia.Text = "Đơn Giá";
            donGia.Width = 100;
            // 
            // soLuong
            // 
            soLuong.Text = "Số Lượng";
            soLuong.Width = 70;
            // 
            // frmHienThiMatHangTimKiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(614, 391);
            Controls.Add(lvMatHang);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHienThiMatHangTimKiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết Quả Tìm Kiếm Mặt Hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvMatHang;
        private ColumnHeader id;
        private ColumnHeader tenMatHang;
        private ColumnHeader tenNganhHang;
        private ColumnHeader donGia;
        private ColumnHeader soLuong;
    }
}