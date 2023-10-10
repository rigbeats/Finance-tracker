namespace Finance_tracker.Budget
{
    partial class BudgetPieChart
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
            this.pieChartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartExpenses
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartExpenses.Legends.Add(legend1);
            this.pieChartExpenses.Location = new System.Drawing.Point(15, 4);
            this.pieChartExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.pieChartExpenses.Name = "pieChartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "ExpensesSeries";
            this.pieChartExpenses.Series.Add(series1);
            this.pieChartExpenses.Size = new System.Drawing.Size(330, 309);
            this.pieChartExpenses.TabIndex = 216;
            this.pieChartExpenses.Text = "chart1";
            this.pieChartExpenses.Click += new System.EventHandler(this.pieChartExpenses_Click);
            // 
            // BudgetPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pieChartExpenses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BudgetPieChart";
            this.Size = new System.Drawing.Size(360, 321);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartExpenses;
    }
}
