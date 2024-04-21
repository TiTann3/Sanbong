namespace DoAnC_.FormThongKe
{
    partial class frmThongKeSanPhamBanChay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeSanPhamBanChay));
            label1 = new Label();
            ChartBDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ChartBDC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(141, 28);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 1;
            label1.Text = "TOP 3 SẢN PHẨM BÁN CHẠY";
            // 
            // ChartBDC
            // 
            chartArea1.Name = "ChartArea1";
            ChartBDC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartBDC.Legends.Add(legend1);
            ChartBDC.Location = new Point(12, 77);
            ChartBDC.Name = "ChartBDC";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartBDC.Series.Add(series1);
            ChartBDC.Size = new Size(550, 339);
            ChartBDC.TabIndex = 2;
            ChartBDC.Text = "chart1";
            // 
            // frmThongKeSanPhamBanChay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(574, 428);
            Controls.Add(ChartBDC);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongKeSanPhamBanChay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Sản Phẩm Bán Chạy";
            Load += frmThongKeSanPhamBanChay_Load;
            ((System.ComponentModel.ISupportInitialize)ChartBDC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDC;
    }
}