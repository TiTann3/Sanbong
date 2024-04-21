namespace DoAnC_.FormSearch
{
    partial class frmMatHangTheoTen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatHangTheoTen));
            txtTenMatHang = new TextBox();
            label1 = new Label();
            btnTimKiem = new Button();
            SuspendLayout();
            // 
            // txtTenMatHang
            // 
            txtTenMatHang.BorderStyle = BorderStyle.None;
            txtTenMatHang.Font = new Font("Segoe UI", 10F);
            txtTenMatHang.Location = new Point(67, 50);
            txtTenMatHang.Name = "txtTenMatHang";
            txtTenMatHang.Size = new Size(185, 18);
            txtTenMatHang.TabIndex = 0;
            txtTenMatHang.KeyPress += txtTenMatHang_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(88, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 1;
            label1.Text = "Nhập Tên Mặt Hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.PapayaWhip;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(116, 85);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmMatHangTheoTen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(324, 131);
            Controls.Add(btnTimKiem);
            Controls.Add(label1);
            Controls.Add(txtTenMatHang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMatHangTheoTen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mặt Hàng Theo Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenMatHang;
        private Label label1;
        private Button btnTimKiem;
    }
}