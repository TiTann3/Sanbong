namespace DoAnC_.FormSearch
{
    partial class frmMatHangTheoTenNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatHangTheoTenNganh));
            label1 = new Label();
            txtTenNganh = new TextBox();
            btnTimKiem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(84, 20);
            label1.Name = "label1";
            label1.Size = new Size(160, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập Tên Ngành Hàng";
            // 
            // txtTenNganh
            // 
            txtTenNganh.BorderStyle = BorderStyle.None;
            txtTenNganh.Font = new Font("Segoe UI", 10F);
            txtTenNganh.Location = new Point(69, 55);
            txtTenNganh.Name = "txtTenNganh";
            txtTenNganh.Size = new Size(185, 18);
            txtTenNganh.TabIndex = 1;
            txtTenNganh.KeyPress += txtTenNganh_KeyPress;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.PapayaWhip;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(116, 90);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmMatHangTheoTenNganh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(324, 131);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTenNganh);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMatHangTheoTenNganh";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mặt Hàng Theo Tên Ngành";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenNganh;
        private Button btnTimKiem;
    }
}