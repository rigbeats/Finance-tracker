using Finance_tracker.Entity_classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finance_tracker.Overview
{
    public partial class ColumnChart : UserControl
    {
        public ColumnChart()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void ColumnChart_Load(object sender, EventArgs e)
        {

        }

        private void LoadChartData()
        {
            chart.Series.Clear();

            Series incomeSeries = new Series("Income");
            incomeSeries.ChartType = SeriesChartType.Column;

            Series expensesSeries = new Series("Expenses");
            expensesSeries.ChartType = SeriesChartType.Column;

            chart.Series.Add(incomeSeries);
            chart.Series.Add(expensesSeries);

            chart.Legends.Add(new Legend("Legend"));
            using (var dbContext = new FinanceTrackerContext())
            {
                for (int i = 5; i >= 0; i--)
                {
                    DateTime month = DateTime.Now.AddMonths(-i);

                    var income = dbContext.BudgetEntries
                        .Where(b => b.Category == "Income" && b.Date.Month == month.Month && b.Date.Year == month.Year)
                    .Sum(b => (int?)b.Amount) ?? 0;

                    var expenses = dbContext.BudgetEntries
                        .Where(b => b.Category == "Totals" && b.Date.Month == month.Month && b.Date.Year == month.Year)
                        .Sum(b => (int?)b.Amount) ?? 0;

                    incomeSeries.Points.AddXY(month.ToString("MMMM"), income);
                    expensesSeries.Points.AddXY(month.ToString("MMMM"), expenses);
                }
            }
        }


    }
}
