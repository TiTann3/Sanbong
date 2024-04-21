namespace DoAnC_
{
    partial class frmNhapMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapMatHang));
            lvNhapHang = new ListView();
            id = new ColumnHeader();
            idMatHang = new ColumnHeader();
            ngayNhap = new ColumnHeader();
            soLuong = new ColumnHeader();
            tongTien = new ColumnHeader();
            label6 = new Label();
            btnXoa = new Button();
            btnNhap = new Button();
            dtpNgayNhap = new DateTimePicker();
            nudTongTien = new NumericUpDown();
            nudSoLuong = new NumericUpDown();
            cbMatHang = new ComboBox();
            cbNganhHang = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTongTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // lvNhapHang
            // 
            lvNhapHang.BackColor = Color.Turquoise;
            lvNhapHang.BorderStyle = BorderStyle.None;
            lvNhapHang.Columns.AddRange(new ColumnHeader[] { id, idMatHang, ngayNhap, soLuong, tongTien });
            lvNhapHang.Location = new Point(48, 162);
            lvNhapHang.Name = "lvNhapHang";
            lvNhapHang.Size = new Size(480, 276);
            lvNhapHang.TabIndex = 1;
            lvNhapHang.UseCompatibleStateImageBehavior = false;
            lvNhapHang.View = View.Details;
            lvNhapHang.SelectedIndexChanged += lvNhapHang_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 50;
            // 
            // idMatHang
            // 
            idMatHang.Text = "Sản phẩm";
            idMatHang.Width = 150;
            // 
            // ngayNhap
            // 
            ngayNhap.Text = "Ngày nhập";
            ngayNhap.Width = 100;
            // 
            // soLuong
            // 
            soLuong.Text = "Số lượng";
            // 
            // tongTien
            // 
            tongTien.Text = "Tổng tiền";
            tongTien.Width = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(245, 140);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 11;
            label6.Text = "Lịch sử nhập";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PapayaWhip;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.huy;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(302, 90);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(62, 34);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.PapayaWhip;
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.Image = Properties.Resources.them;
            btnNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhap.Location = new Point(222, 90);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(69, 34);
            btnNhap.TabIndex = 22;
            btnNhap.Text = "Nhập";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "";
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(491, 49);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(74, 23);
            dtpNgayNhap.TabIndex = 21;
            // 
            // nudTongTien
            // 
            nudTongTien.BorderStyle = BorderStyle.None;
            nudTongTien.Location = new Point(391, 51);
            nudTongTien.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudTongTien.Name = "nudTongTien";
            nudTongTien.Size = new Size(94, 19);
            nudTongTien.TabIndex = 20;
            // 
            // nudSoLuong
            // 
            nudSoLuong.BorderStyle = BorderStyle.None;
            nudSoLuong.Location = new Point(331, 51);
            nudSoLuong.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(54, 19);
            nudSoLuong.TabIndex = 19;
            // 
            // cbMatHang
            // 
            cbMatHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMatHang.FormattingEnabled = true;
            cbMatHang.Location = new Point(135, 49);
            cbMatHang.Name = "cbMatHang";
            cbMatHang.Size = new Size(185, 23);
            cbMatHang.TabIndex = 18;
            // 
            // cbNganhHang
            // 
            cbNganhHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNganhHang.FormattingEnabled = true;
            cbNganhHang.Location = new Point(29, 49);
            cbNganhHang.Name = "cbNganhHang";
            cbNganhHang.Size = new Size(100, 23);
            cbNganhHang.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(495, 28);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 17;
            label5.Text = "Ngày nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(409, 28);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 16;
            label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(331, 28);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(170, 28);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 14;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 12;
            label1.Text = "Ngành hàng";
            // 
            // frmNhapMatHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(580, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnNhap);
            Controls.Add(dtpNgayNhap);
            Controls.Add(nudTongTien);
            Controls.Add(nudSoLuong);
            Controls.Add(cbMatHang);
            Controls.Add(cbNganhHang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lvNhapHang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNhapMatHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập hàng";
            Load += frmNhapMatHang_Load;
            ((System.ComponentModel.ISupportInitialize)nudTongTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lvNhapHang;
        private Label label6;
        private ColumnHeader id;
        private ColumnHeader idMatHang;
        private ColumnHeader ngayNhap;
        private ColumnHeader soLuong;
        private ColumnHeader tongTien;
        private Button btnXoa;
        private Button btnNhap;
        private DateTimePicker dtpNgayNhap;
        private NumericUpDown nudTongTien;
        private NumericUpDown nudSoLuong;
        private ComboBox cbMatHang;
        private ComboBox cbNganhHang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}