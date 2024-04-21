namespace DoAnC_.FormThongKe
{
    partial class frmThongKeDatSanBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDatSanBong));
            label1 = new Label();
            lvPhieuDatSan = new ListView();
            id = new ColumnHeader();
            idSan = new ColumnHeader();
            thoiGianBatDau = new ColumnHeader();
            soGioDat = new ColumnHeader();
            thoiGianKetThuc = new ColumnHeader();
            donGia = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(166, 22);
            label1.Name = "label1";
            label1.Size = new Size(305, 28);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ CÁC ĐƠN ĐẶT SÂN";
            // 
            // lvPhieuDatSan
            // 
            lvPhieuDatSan.BackColor = Color.Turquoise;
            lvPhieuDatSan.BorderStyle = BorderStyle.None;
            lvPhieuDatSan.Columns.AddRange(new ColumnHeader[] { id, idSan, thoiGianBatDau, soGioDat, thoiGianKetThuc, donGia });
            lvPhieuDatSan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvPhieuDatSan.Location = new Point(15, 72);
            lvPhieuDatSan.Name = "lvPhieuDatSan";
            lvPhieuDatSan.Size = new Size(590, 251);
            lvPhieuDatSan.TabIndex = 1;
            lvPhieuDatSan.UseCompatibleStateImageBehavior = false;
            lvPhieuDatSan.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 30;
            // 
            // idSan
            // 
            idSan.Text = "ID Sân";
            idSan.TextAlign = HorizontalAlignment.Center;
            idSan.Width = 50;
            // 
            // thoiGianBatDau
            // 
            thoiGianBatDau.Text = "Thời gian đặt";
            thoiGianBatDau.TextAlign = HorizontalAlignment.Center;
            thoiGianBatDau.Width = 150;
            // 
            // soGioDat
            // 
            soGioDat.Text = "Số giờ đặt";
            soGioDat.TextAlign = HorizontalAlignment.Center;
            soGioDat.Width = 80;
            // 
            // thoiGianKetThuc
            // 
            thoiGianKetThuc.Text = "Thời gian kết thúc";
            thoiGianKetThuc.TextAlign = HorizontalAlignment.Center;
            thoiGianKetThuc.Width = 150;
            // 
            // donGia
            // 
            donGia.Text = "Đơn giá";
            donGia.TextAlign = HorizontalAlignment.Center;
            donGia.Width = 120;
            // 
            // frmThongKeDatSanBong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(619, 335);
            Controls.Add(lvPhieuDatSan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongKeDatSanBong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Đơn Đặt Sân";
            Load += frmThongKeDatSanBong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvPhieuDatSan;
        private ColumnHeader id;
        private ColumnHeader idSan;
        private ColumnHeader thoiGianBatDau;
        private ColumnHeader soGioDat;
        private ColumnHeader thoiGianKetThuc;
        private ColumnHeader donGia;
    }
}