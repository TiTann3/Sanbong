namespace DoAnC_.FormThongKe
{
    partial class frmThongKeKhachHang
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeKhachHang));
            ChartBDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ChartBDC).BeginInit();
            SuspendLayout();
            // 
            // ChartBDC
            // 
            chartArea1.Name = "ChartArea1";
            ChartBDC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartBDC.Legends.Add(legend1);
            ChartBDC.Location = new Point(16, 86);
            ChartBDC.Name = "ChartBDC";
            ChartBDC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelFormat = "N0";
            series1.Legend = "Legend1";
            series1.LegendText = "Doanh thu";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Số lần mua hàng";
            series2.Name = "Series2";
            ChartBDC.Series.Add(series1);
            ChartBDC.Series.Add(series2);
            ChartBDC.Size = new Size(680, 342);
            ChartBDC.TabIndex = 0;
            ChartBDC.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(238, 32);
            label1.Name = "label1";
            label1.Size = new Size(254, 28);
            label1.TabIndex = 1;
            label1.Text = "THỐNG KÊ KHÁCH HÀNG";
            // 
            // frmThongKeKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(708, 440);
            Controls.Add(label1);
            Controls.Add(ChartBDC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongKeKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Khách Hàng";
            Load += frmThongKeKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)ChartBDC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDC;
        private Label label1;
    }
}