namespace DoAnC_.FormSearch
{
    partial class frmPhieuDatSanTheoDonGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDatSanTheoDonGia));
            label1 = new Label();
            nudGiaTu = new NumericUpDown();
            nudGiaDen = new NumericUpDown();
            btnTimKiem = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudGiaTu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaDen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(76, 18);
            label1.Name = "label1";
            label1.Size = new Size(179, 19);
            label1.TabIndex = 0;
            label1.Text = "Chọn Hoặc Nhập Đơn Giá";
            // 
            // nudGiaTu
            // 
            nudGiaTu.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudGiaTu.Location = new Point(76, 49);
            nudGiaTu.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudGiaTu.Name = "nudGiaTu";
            nudGiaTu.Size = new Size(100, 23);
            nudGiaTu.TabIndex = 1;
            // 
            // nudGiaDen
            // 
            nudGiaDen.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudGiaDen.Location = new Point(208, 49);
            nudGiaDen.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            nudGiaDen.Name = "nudGiaDen";
            nudGiaDen.Size = new Size(100, 23);
            nudGiaDen.TabIndex = 2;
            nudGiaDen.KeyPress += nudGiaDen_KeyPress;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.PapayaWhip;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(121, 89);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Đơn giá từ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 51);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "đến";
            // 
            // frmPhieuDatSanTheoDonGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(324, 131);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnTimKiem);
            Controls.Add(nudGiaDen);
            Controls.Add(nudGiaTu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPhieuDatSanTheoDonGia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Phiếu Đặt Sân Theo Đơn Giá";
            ((System.ComponentModel.ISupportInitialize)nudGiaTu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaDen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudGiaTu;
        private NumericUpDown nudGiaDen;
        private Button btnTimKiem;
        private Label label2;
        private Label label3;
    }
}