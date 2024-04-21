namespace DoAnC_.FormThongKe
{
    partial class frmThongKeSanPhamVaNganhHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeSanPhamVaNganhHang));
            ChartBDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartBDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ChartBDC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartBDT).BeginInit();
            SuspendLayout();
            // 
            // ChartBDC
            // 
            chartArea1.Name = "ChartArea1";
            ChartBDC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartBDC.Legends.Add(legend1);
            ChartBDC.Location = new Point(12, 98);
            ChartBDC.Name = "ChartBDC";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng SP";
            series1.Name = "Series1";
            ChartBDC.Series.Add(series1);
            ChartBDC.Size = new Size(385, 303);
            ChartBDC.TabIndex = 0;
            ChartBDC.Text = "chart1";
            // 
            // ChartBDT
            // 
            chartArea2.Name = "ChartArea1";
            ChartBDT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartBDT.Legends.Add(legend2);
            ChartBDT.Location = new Point(403, 98);
            ChartBDT.Name = "ChartBDT";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#0.00%";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ChartBDT.Series.Add(series2);
            ChartBDT.Size = new Size(331, 303);
            ChartBDT.TabIndex = 1;
            ChartBDT.Text = "chart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(162, 37);
            label1.Name = "label1";
            label1.Size = new Size(405, 28);
            label1.TabIndex = 2;
            label1.Text = "THỐNG KÊ SẢN PHẨM VÀ NGÀNH HÀNG";
            // 
            // frmThongKeSanPhamVaNganhHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(746, 413);
            Controls.Add(label1);
            Controls.Add(ChartBDT);
            Controls.Add(ChartBDC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongKeSanPhamVaNganhHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Sản Phẩm Và Ngành Hàng";
            Load += frmThongKeSanPhamVaNganhHang_Load;
            ((System.ComponentModel.ISupportInitialize)ChartBDC).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartBDT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDC;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDT;
        private Label label1;
    }
}