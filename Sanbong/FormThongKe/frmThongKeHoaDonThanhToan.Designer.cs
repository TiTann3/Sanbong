namespace DoAnC_.FormThongKe
{
    partial class frmThongKeHoaDonThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeHoaDonThanhToan));
            ChartBDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartBDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ChartBDT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartBDC).BeginInit();
            SuspendLayout();
            // 
            // ChartBDT
            // 
            ChartBDT.BackColor = SystemColors.ControlLightLight;
            chartArea1.Name = "ChartArea1";
            ChartBDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartBDT.Legends.Add(legend1);
            ChartBDT.Location = new Point(377, 66);
            ChartBDT.Name = "ChartBDT";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelFormat = "#0.00%";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartBDT.Series.Add(series1);
            ChartBDT.Size = new Size(334, 357);
            ChartBDT.TabIndex = 0;
            // 
            // ChartBDC
            // 
            ChartBDC.BackColor = SystemColors.ControlLightLight;
            chartArea2.Name = "ChartArea1";
            ChartBDC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartBDC.Legends.Add(legend2);
            ChartBDC.Location = new Point(12, 66);
            ChartBDC.Name = "ChartBDC";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Số lần TT";
            series2.Name = "Series1";
            ChartBDC.Series.Add(series2);
            ChartBDC.Size = new Size(359, 357);
            ChartBDC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(199, 18);
            label1.Name = "label1";
            label1.Size = new Size(357, 28);
            label1.TabIndex = 2;
            label1.Text = "THỐNG KÊ HÓA ĐƠN THANH TOÁN";
            // 
            // frmThongKeHoaDonThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(723, 429);
            Controls.Add(label1);
            Controls.Add(ChartBDC);
            Controls.Add(ChartBDT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongKeHoaDonThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Hóa Đơn Thanh Toán";
            Load += frmThongKeHoaDonThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)ChartBDT).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartBDC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDT;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDC;
        private Label label1;
    }
}