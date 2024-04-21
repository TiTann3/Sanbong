namespace DoAnC_
{
    partial class frmInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHoaDon));
            label1 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lvNgayTao = new ListView();
            lvTenKhachHang = new ListView();
            lvIdSanBong = new ListView();
            lvDonGia = new ListView();
            lvSoGioDat = new ListView();
            lvMatHang = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvTongCong = new ListView();
            label7 = new Label();
            btnIn = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(224, 31);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(69, 85);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(69, 126);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày tạo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(454, 85);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Id sân bóng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(454, 127);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Số giờ đặt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(69, 165);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Đơn giá";
            // 
            // lvNgayTao
            // 
            lvNgayTao.BorderStyle = BorderStyle.None;
            lvNgayTao.Location = new Point(165, 126);
            lvNgayTao.Name = "lvNgayTao";
            lvNgayTao.Size = new Size(142, 15);
            lvNgayTao.TabIndex = 6;
            lvNgayTao.UseCompatibleStateImageBehavior = false;
            lvNgayTao.View = View.List;
            // 
            // lvTenKhachHang
            // 
            lvTenKhachHang.BorderStyle = BorderStyle.None;
            lvTenKhachHang.Location = new Point(165, 86);
            lvTenKhachHang.Name = "lvTenKhachHang";
            lvTenKhachHang.Size = new Size(142, 15);
            lvTenKhachHang.TabIndex = 7;
            lvTenKhachHang.UseCompatibleStateImageBehavior = false;
            lvTenKhachHang.View = View.List;
            // 
            // lvIdSanBong
            // 
            lvIdSanBong.BorderStyle = BorderStyle.None;
            lvIdSanBong.Location = new Point(534, 86);
            lvIdSanBong.Name = "lvIdSanBong";
            lvIdSanBong.Size = new Size(30, 15);
            lvIdSanBong.TabIndex = 8;
            lvIdSanBong.UseCompatibleStateImageBehavior = false;
            lvIdSanBong.View = View.List;
            // 
            // lvDonGia
            // 
            lvDonGia.BorderStyle = BorderStyle.None;
            lvDonGia.Location = new Point(165, 165);
            lvDonGia.Name = "lvDonGia";
            lvDonGia.Size = new Size(142, 15);
            lvDonGia.TabIndex = 9;
            lvDonGia.UseCompatibleStateImageBehavior = false;
            lvDonGia.View = View.List;
            // 
            // lvSoGioDat
            // 
            lvSoGioDat.BorderStyle = BorderStyle.None;
            lvSoGioDat.Location = new Point(534, 126);
            lvSoGioDat.Name = "lvSoGioDat";
            lvSoGioDat.Size = new Size(30, 15);
            lvSoGioDat.TabIndex = 10;
            lvSoGioDat.UseCompatibleStateImageBehavior = false;
            lvSoGioDat.View = View.List;
            // 
            // lvMatHang
            // 
            lvMatHang.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvMatHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvMatHang.Location = new Point(69, 205);
            lvMatHang.Name = "lvMatHang";
            lvMatHang.Size = new Size(495, 136);
            lvMatHang.TabIndex = 11;
            lvMatHang.UseCompatibleStateImageBehavior = false;
            lvMatHang.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên mặt hàng";
            columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // lvTongCong
            // 
            lvTongCong.BorderStyle = BorderStyle.None;
            lvTongCong.Location = new Point(409, 356);
            lvTongCong.Name = "lvTongCong";
            lvTongCong.Size = new Size(111, 15);
            lvTongCong.TabIndex = 13;
            lvTongCong.UseCompatibleStateImageBehavior = false;
            lvTongCong.View = View.List;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label7.Location = new Point(326, 356);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Tổng cộng: ";
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.PapayaWhip;
            btnIn.FlatAppearance.BorderSize = 0;
            btnIn.FlatStyle = FlatStyle.Flat;
            btnIn.Location = new Point(317, 390);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(80, 30);
            btnIn.TabIndex = 14;
            btnIn.Text = "In Hóa Đơn";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(526, 356);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 15;
            label8.Text = "VNĐ";
            // 
            // frmInHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(694, 431);
            Controls.Add(label8);
            Controls.Add(btnIn);
            Controls.Add(lvTongCong);
            Controls.Add(label7);
            Controls.Add(lvMatHang);
            Controls.Add(lvSoGioDat);
            Controls.Add(lvDonGia);
            Controls.Add(lvIdSanBong);
            Controls.Add(lvTenKhachHang);
            Controls.Add(lvNgayTao);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In Hóa Đơn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView lvNgayTao;
        private ListView lvTenKhachHang;
        private ListView lvIdSanBong;
        private ListView lvDonGia;
        private ListView lvSoGioDat;
        private ListView lvMatHang;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lvTongCong;
        private Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnIn;
        private Label label8;
    }
}