namespace Finance_tracker.Statistics
{
    partial class statisticsPage
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
            this.statisticsPieChart1 = new Finance_tracker.Statistics.StatisticsPieChart();
            this.statisticsBarChart1 = new Finance_tracker.Statistics.StatisticsBarChart();
            this.statisticsLineChart1 = new Finance_tracker.Statistics.StatisticsLineChart();
            this.SuspendLayout();
            // 
            // statisticsPieChart1
            // 
            this.statisticsPieChart1.Location = new System.Drawing.Point(596, 14);
            this.statisticsPieChart1.Name = "statisticsPieChart1";
            this.statisticsPieChart1.Size = new System.Drawing.Size(400, 300);
            this.statisticsPieChart1.TabIndex = 0;
            this.statisticsPieChart1.Load += new System.EventHandler(this.statisticsPieChart1_Load);
            // 
            // statisticsBarChart1
            // 
            this.statisticsBarChart1.Location = new System.Drawing.Point(41, 14);
            this.statisticsBarChart1.Name = "statisticsBarChart1";
            this.statisticsBarChart1.Size = new System.Drawing.Size(400, 300);
            this.statisticsBarChart1.TabIndex = 1;
            this.statisticsBarChart1.Load += new System.EventHandler(this.statisticsBarChart1_Load);
            // 
            // statisticsLineChart1
            // 
            this.statisticsLineChart1.Location = new System.Drawing.Point(52, 354);
            this.statisticsLineChart1.Name = "statisticsLineChart1";
            this.statisticsLineChart1.Size = new System.Drawing.Size(800, 300);
            this.statisticsLineChart1.TabIndex = 2;
            this.statisticsLineChart1.Load += new System.EventHandler(this.statisticsLineChart1_Load);
            // 
            // statisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statisticsLineChart1);
            this.Controls.Add(this.statisticsBarChart1);
            this.Controls.Add(this.statisticsPieChart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "statisticsPage";
            this.Size = new System.Drawing.Size(1053, 681);
            this.Load += new System.EventHandler(this.statisticsPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private StatisticsPieChart statisticsPieChart1;
        private StatisticsBarChart statisticsBarChart1;
        private StatisticsLineChart statisticsLineChart1;
    }
}
