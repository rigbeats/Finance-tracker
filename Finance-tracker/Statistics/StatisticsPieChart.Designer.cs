namespace Finance_tracker.Statistics
{
    partial class StatisticsPieChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartStatistics.Legends.Add(legend1);
            this.pieChartStatistics.Location = new System.Drawing.Point(0, 3);
            this.pieChartStatistics.Name = "pieChartStatistics";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "Series1";
            this.pieChartStatistics.Series.Add(series1);
            this.pieChartStatistics.Size = new System.Drawing.Size(400, 300);
            this.pieChartStatistics.TabIndex = 0;
            this.pieChartStatistics.Text = "chart1";
            this.pieChartStatistics.Click += new System.EventHandler(this.pieChartStatistics_Click);
            // 
            // StatisticsPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pieChartStatistics);
            this.Name = "StatisticsPieChart";
            this.Size = new System.Drawing.Size(400, 300);
            this.Load += new System.EventHandler(this.StatisticsPieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartStatistics;
    }
}
