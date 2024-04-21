namespace DoAnC_
{
    partial class frmHienThiHoaDonTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHienThiHoaDonTimKiem));
            lvHoaDon = new ListView();
            id = new ColumnHeader();
            ngaytao = new ColumnHeader();
            tenkhachhang = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvHoaDon
            // 
            lvHoaDon.BackColor = Color.Turquoise;
            lvHoaDon.BorderStyle = BorderStyle.None;
            lvHoaDon.Columns.AddRange(new ColumnHeader[] { id, ngaytao, tenkhachhang });
            lvHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvHoaDon.Location = new Point(58, 118);
            lvHoaDon.Name = "lvHoaDon";
            lvHoaDon.Size = new Size(493, 214);
            lvHoaDon.TabIndex = 0;
            lvHoaDon.UseCompatibleStateImageBehavior = false;
            lvHoaDon.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // ngaytao
            // 
            ngaytao.Text = "Ngày Tạo";
            ngaytao.Width = 180;
            // 
            // tenkhachhang
            // 
            tenkhachhang.Text = "Tên Khách Hàng";
            tenkhachhang.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(216, 46);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // frmHienThiHoaDonTimKiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(614, 391);
            Controls.Add(label1);
            Controls.Add(lvHoaDon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHienThiHoaDonTimKiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết Quả Tìm Kiếm Hóa Đơn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvHoaDon;
        private ColumnHeader id;
        private ColumnHeader ngaytao;
        private ColumnHeader tenkhachhang;
        private Label label1;
    }
}