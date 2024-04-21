namespace DoAnC_.FormThongKe
{
    partial class frmThongKeDoanhThuTheoNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDoanhThuTheoNganh));
            ChartBDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ChartBDT).BeginInit();
            SuspendLayout();
            // 
            // ChartBDT
            // 
            ChartBDT.BackColor = SystemColors.ControlLightLight;
            chartArea1.Name = "ChartArea1";
            ChartBDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartBDT.Legends.Add(legend1);
            ChartBDT.Location = new Point(77, 80);
            ChartBDT.Name = "ChartBDT";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "N0";
            series1.Legend = "Legend1";
            series1.Name = "ChartBDT";
            ChartBDT.Series.Add(series1);
            ChartBDT.Size = new Size(476, 309);
            ChartBDT.TabIndex = 0;
            ChartBDT.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(89, 20);
            label1.Name = "label1";
            label1.Size = new Size(447, 28);
            label1.TabIndex = 1;
            label1.Text = "THỐNG KÊ DOANH THU THEO NGÀNH HÀNG";
            // 
            // frmThongKeDoanhThuTheoNganh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(638, 411);
            Controls.Add(label1);
            Controls.Add(ChartBDT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongKeDoanhThuTheoNganh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Doanh Thu Theo Ngành";
            Load += frmThongKeDoanhThuTheoNganh_Load;
            ((System.ComponentModel.ISupportInitialize)ChartBDT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDT;
        private Label label1;
    }
}