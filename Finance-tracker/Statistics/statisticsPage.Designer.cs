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
            this.radioButtonNeeds = new System.Windows.Forms.RadioButton();
            this.radioButtonWants = new System.Windows.Forms.RadioButton();
            this.radioButtonDebts = new System.Windows.Forms.RadioButton();
            this.statisticsPieChart = new Finance_tracker.Statistics.StatisticsPieChart();
            this.statisticsLineChart1 = new Finance_tracker.Statistics.StatisticsLineChart();
            this.statisticsBarChart1 = new Finance_tracker.Statistics.StatisticsBarChart();
            this.SuspendLayout();
            // 
            // radioButtonNeeds
            // 
            this.radioButtonNeeds.AutoSize = true;
            this.radioButtonNeeds.Location = new System.Drawing.Point(937, 102);
            this.radioButtonNeeds.Name = "radioButtonNeeds";
            this.radioButtonNeeds.Size = new System.Drawing.Size(56, 17);
            this.radioButtonNeeds.TabIndex = 4;
            this.radioButtonNeeds.TabStop = true;
            this.radioButtonNeeds.Text = "Needs";
            this.radioButtonNeeds.UseVisualStyleBackColor = true;
            this.radioButtonNeeds.CheckedChanged += new System.EventHandler(this.radioButtonNeeds_CheckedChanged);
            // 
            // radioButtonWants
            // 
            this.radioButtonWants.AutoSize = true;
            this.radioButtonWants.Location = new System.Drawing.Point(937, 148);
            this.radioButtonWants.Name = "radioButtonWants";
            this.radioButtonWants.Size = new System.Drawing.Size(56, 17);
            this.radioButtonWants.TabIndex = 5;
            this.radioButtonWants.TabStop = true;
            this.radioButtonWants.Text = "Wants";
            this.radioButtonWants.UseVisualStyleBackColor = true;
            this.radioButtonWants.CheckedChanged += new System.EventHandler(this.radioButtonWants_CheckedChanged);
            // 
            // radioButtonDebts
            // 
            this.radioButtonDebts.AutoSize = true;
            this.radioButtonDebts.Location = new System.Drawing.Point(937, 192);
            this.radioButtonDebts.Name = "radioButtonDebts";
            this.radioButtonDebts.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDebts.TabIndex = 6;
            this.radioButtonDebts.TabStop = true;
            this.radioButtonDebts.Text = "Savings/debts";
            this.radioButtonDebts.UseVisualStyleBackColor = true;
            this.radioButtonDebts.CheckedChanged += new System.EventHandler(this.radioButtonDebts_CheckedChanged);
            // 
            // statisticsPieChart
            // 
            this.statisticsPieChart.Location = new System.Drawing.Point(509, 14);
            this.statisticsPieChart.Name = "statisticsPieChart";
            this.statisticsPieChart.Size = new System.Drawing.Size(400, 300);
            this.statisticsPieChart.TabIndex = 3;
            // 
            // statisticsLineChart1
            // 
            this.statisticsLineChart1.Location = new System.Drawing.Point(52, 354);
            this.statisticsLineChart1.Name = "statisticsLineChart1";
            this.statisticsLineChart1.Size = new System.Drawing.Size(800, 300);
            this.statisticsLineChart1.TabIndex = 2;
            // 
            // statisticsBarChart1
            // 
            this.statisticsBarChart1.Location = new System.Drawing.Point(41, 14);
            this.statisticsBarChart1.Name = "statisticsBarChart1";
            this.statisticsBarChart1.Size = new System.Drawing.Size(400, 300);
            this.statisticsBarChart1.TabIndex = 1;
            // 
            // statisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonDebts);
            this.Controls.Add(this.radioButtonWants);
            this.Controls.Add(this.radioButtonNeeds);
            this.Controls.Add(this.statisticsPieChart);
            this.Controls.Add(this.statisticsLineChart1);
            this.Controls.Add(this.statisticsBarChart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "statisticsPage";
            this.Size = new System.Drawing.Size(1053, 681);
            this.Load += new System.EventHandler(this.statisticsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatisticsBarChart statisticsBarChart1;
        private StatisticsLineChart statisticsLineChart1;
        private StatisticsPieChart statisticsPieChart;
        private System.Windows.Forms.RadioButton radioButtonNeeds;
        private System.Windows.Forms.RadioButton radioButtonWants;
        private System.Windows.Forms.RadioButton radioButtonDebts;
    }
}
