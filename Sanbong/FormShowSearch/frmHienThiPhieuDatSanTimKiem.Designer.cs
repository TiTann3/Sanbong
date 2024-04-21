namespace DoAnC_
{
    partial class frmHienThiPhieuDatSanTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHienThiPhieuDatSanTimKiem));
            lvPhieuDatSan = new ListView();
            idSan = new ColumnHeader();
            thoiGianBatDau = new ColumnHeader();
            soGioDat = new ColumnHeader();
            thoiGianKetThuc = new ColumnHeader();
            donGia = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvPhieuDatSan
            // 
            lvPhieuDatSan.BackColor = Color.Turquoise;
            lvPhieuDatSan.BorderStyle = BorderStyle.None;
            lvPhieuDatSan.Columns.AddRange(new ColumnHeader[] { idSan, thoiGianBatDau, soGioDat, thoiGianKetThuc, donGia });
            lvPhieuDatSan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvPhieuDatSan.Location = new Point(12, 93);
            lvPhieuDatSan.Name = "lvPhieuDatSan";
            lvPhieuDatSan.Size = new Size(590, 269);
            lvPhieuDatSan.TabIndex = 0;
            lvPhieuDatSan.UseCompatibleStateImageBehavior = false;
            lvPhieuDatSan.View = View.Details;
            // 
            // idSan
            // 
            idSan.Text = "Id Sân Bóng";
            idSan.Width = 80;
            // 
            // thoiGianBatDau
            // 
            thoiGianBatDau.Text = "Thời Gian Đặt";
            thoiGianBatDau.Width = 160;
            // 
            // soGioDat
            // 
            soGioDat.Text = "Số Giờ Đặt";
            soGioDat.Width = 80;
            // 
            // thoiGianKetThuc
            // 
            thoiGianKetThuc.Text = "Thời Gian Kết Thúc";
            thoiGianKetThuc.Width = 160;
            // 
            // donGia
            // 
            donGia.Text = "Đơn Giá";
            donGia.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(217, 32);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // frmHienThiPhieuDatSanTimKiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(614, 391);
            Controls.Add(label1);
            Controls.Add(lvPhieuDatSan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHienThiPhieuDatSanTimKiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết Quả Tìm Kiếm Phiếu Đặt Sân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPhieuDatSan;
        private ColumnHeader idSan;
        private ColumnHeader thoiGianBatDau;
        private ColumnHeader soGioDat;
        private ColumnHeader thoiGianKetThuc;
        private ColumnHeader donGia;
        private Label label1;
    }
}