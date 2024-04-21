namespace DoAnC_
{
    partial class frmQuanLyMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMatHang));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbNganhHang = new ComboBox();
            txtTen = new TextBox();
            nudDonGia = new NumericUpDown();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lvMatHang = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Ngành hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(225, 23);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(370, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá";
            // 
            // cbNganhHang
            // 
            cbNganhHang.FormattingEnabled = true;
            cbNganhHang.Location = new Point(12, 43);
            cbNganhHang.Name = "cbNganhHang";
            cbNganhHang.Size = new Size(130, 23);
            cbNganhHang.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(148, 43);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(183, 23);
            txtTen.TabIndex = 4;
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(337, 44);
            nudDonGia.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(120, 23);
            nudDonGia.TabIndex = 5;
            nudDonGia.TextAlign = HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PapayaWhip;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.them;
            btnThem.ImageAlign = ContentAlignment.TopCenter;
            btnThem.Location = new Point(107, 82);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(58, 49);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.BottomCenter;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.PapayaWhip;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.edit1;
            btnSua.ImageAlign = ContentAlignment.TopCenter;
            btnSua.Location = new Point(195, 82);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(58, 49);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.BottomCenter;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PapayaWhip;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.huy;
            btnXoa.ImageAlign = ContentAlignment.TopCenter;
            btnXoa.Location = new Point(281, 82);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(58, 49);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // lvMatHang
            // 
            lvMatHang.BackColor = Color.Turquoise;
            lvMatHang.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvMatHang.Location = new Point(12, 137);
            lvMatHang.Name = "lvMatHang";
            lvMatHang.Size = new Size(436, 204);
            lvMatHang.TabIndex = 9;
            lvMatHang.UseCompatibleStateImageBehavior = false;
            lvMatHang.View = View.Details;
            lvMatHang.SelectedIndexChanged += lvMatHang_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 140;
            // 
            // frmQuanLyMatHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(460, 353);
            Controls.Add(lvMatHang);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(nudDonGia);
            Controls.Add(txtTen);
            Controls.Add(cbNganhHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmQuanLyMatHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += frmQuanLyMatHang_Load;
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbNganhHang;
        private TextBox txtTen;
        private NumericUpDown nudDonGia;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private ListView lvMatHang;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}