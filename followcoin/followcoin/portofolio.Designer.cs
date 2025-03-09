namespace followcoin
{
    partial class portofolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portofolio));
            portofolio_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            total_worth = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)portofolio_chart).BeginInit();
            SuspendLayout();
            // 
            // portofolio_chart
            // 
            chartArea1.Name = "ChartArea1";
            portofolio_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            portofolio_chart.Legends.Add(legend1);
            portofolio_chart.Location = new Point(3, 61);
            portofolio_chart.Name = "portofolio_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Coin";
            portofolio_chart.Series.Add(series1);
            portofolio_chart.Size = new Size(321, 246);
            portofolio_chart.TabIndex = 0;
            portofolio_chart.Text = "chart1";
            portofolio_chart.Click += portofolio_chart_Click;
            // 
            // total_worth
            // 
            total_worth.AllowParentOverrides = false;
            total_worth.AutoEllipsis = false;
            total_worth.CursorType = Cursors.Default;
            total_worth.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_worth.Location = new Point(12, 12);
            total_worth.Name = "total_worth";
            total_worth.RightToLeft = RightToLeft.No;
            total_worth.Size = new Size(106, 37);
            total_worth.TabIndex = 1;
            total_worth.Text = "Total =";
            total_worth.TextAlignment = ContentAlignment.TopLeft;
            total_worth.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // portofolio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 306);
            Controls.Add(total_worth);
            Controls.Add(portofolio_chart);
            Name = "portofolio";
            Text = "portofolio";
            ((System.ComponentModel.ISupportInitialize)portofolio_chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart portofolio_chart;
        private Bunifu.UI.WinForms.BunifuLabel total_worth;
    }
}