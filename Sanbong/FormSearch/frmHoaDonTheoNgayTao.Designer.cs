namespace DoAnC_.FormSearch
{
    partial class frmHoaDonTheoNgayTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonTheoNgayTao));
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnTimKiem = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 19);
            label1.TabIndex = 0;
            label1.Text = "Chọn Khoảng Thời Gian Tạo Hóa Đơn";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(63, 50);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(88, 23);
            dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(195, 50);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(88, 23);
            dtpDenNgay.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.PapayaWhip;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(122, 87);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm ";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(157, 52);
            label2.Name = "label2";
            label2.Size = new Size(32, 19);
            label2.TabIndex = 4;
            label2.Text = "đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(33, 52);
            label3.Name = "label3";
            label3.Size = new Size(24, 19);
            label3.TabIndex = 5;
            label3.Text = "Từ";
            // 
            // frmHoaDonTheoNgayTao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(324, 131);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnTimKiem);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHoaDonTheoNgayTao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hóa Đơn Theo Ngày";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnTimKiem;
        private Label label2;
        private Label label3;
    }
}