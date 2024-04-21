namespace DoAnC_.FormSearch
{
    partial class frmPhieuNhapHangTheoTongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapHangTheoTongTien));
            label1 = new Label();
            nudGiaTu = new NumericUpDown();
            nudGiaDen = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)nudGiaTu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaDen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(89, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập Khoảng Tiền";
            // 
            // nudGiaTu
            // 
            nudGiaTu.BorderStyle = BorderStyle.None;
            nudGiaTu.Location = new Point(66, 55);
            nudGiaTu.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            nudGiaTu.Name = "nudGiaTu";
            nudGiaTu.Size = new Size(93, 19);
            nudGiaTu.TabIndex = 1;
            // 
            // nudGiaDen
            // 
            nudGiaDen.BorderStyle = BorderStyle.None;
            nudGiaDen.Location = new Point(201, 55);
            nudGiaDen.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            nudGiaDen.Name = "nudGiaDen";
            nudGiaDen.Size = new Size(111, 19);
            nudGiaDen.TabIndex = 2;
            nudGiaDen.KeyPress += nudGiaDen_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Tổng từ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 55);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "đến";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.PapayaWhip;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(115, 93);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmPhieuNhapHangTheoTongTien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(324, 131);
            Controls.Add(btnTimKiem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudGiaDen);
            Controls.Add(nudGiaTu);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPhieuNhapHangTheoTongTien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Phiếu Nhập Hàng Theo Tổng Tiền";
            Load += frmPhieuNhapHangTheoTongTien_Load;
            ((System.ComponentModel.ISupportInitialize)nudGiaTu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaDen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudGiaTu;
        private NumericUpDown nudGiaDen;
        private Label label2;
        private Label label3;
        private Button btnTimKiem;
    }
}