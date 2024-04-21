namespace DoAnC_
{
    partial class frmQuanLyNganhHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNganhHang));
            label1 = new Label();
            txtTenNganhHang = new TextBox();
            lvNganhHang = new ListView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên ngành hàng";
            // 
            // txtTenNganhHang
            // 
            txtTenNganhHang.BorderStyle = BorderStyle.None;
            txtTenNganhHang.Location = new Point(112, 15);
            txtTenNganhHang.Name = "txtTenNganhHang";
            txtTenNganhHang.Size = new Size(145, 16);
            txtTenNganhHang.TabIndex = 1;
            txtTenNganhHang.KeyPress += txtTenNganhHang_KeyPress;
            // 
            // lvNganhHang
            // 
            lvNganhHang.BackColor = Color.Turquoise;
            lvNganhHang.BorderStyle = BorderStyle.None;
            lvNganhHang.Location = new Point(14, 41);
            lvNganhHang.Name = "lvNganhHang";
            lvNganhHang.Size = new Size(243, 271);
            lvNganhHang.TabIndex = 2;
            lvNganhHang.UseCompatibleStateImageBehavior = false;
            lvNganhHang.SelectedIndexChanged += lvNganhHang_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PapayaWhip;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.them;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(275, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(78, 38);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
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
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(275, 56);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(78, 38);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
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
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(275, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 38);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmQuanLyNganhHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(366, 323);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lvNganhHang);
            Controls.Add(txtTenNganhHang);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmQuanLyNganhHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ngành Hàng";
            Load += frmQuanLyNganhHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenNganhHang;
        private ListView lvNganhHang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}