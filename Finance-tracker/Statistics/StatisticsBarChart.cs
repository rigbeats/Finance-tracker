using Finance_tracker.Entity_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finance_tracker.Statistics
{
    public partial class StatisticsBarChart : UserControl
    {
        public StatisticsBarChart()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public List<BudgetEntry> GetTop10EntriesByCategoryAndDate(DateTime fromDate, DateTime toDate, string category)
        {
            using (var context = new FinanceTrackerContext())
            {
                var query = from entry in context.BudgetEntries
                            where entry.Category == category
                            && entry.Date >= fromDate
                            && entry.Date <= toDate
                            group entry by entry.Name into grouped
                            select new
                            {
                                Name = grouped.Key,
                                Amount = grouped.Sum(e => e.Amount)
                            };

                var data = query.OrderByDescending(e => e.Amount).Take(10).ToList();

                return data.Select(entry => new BudgetEntry
                {
                    Name = entry.Name,
                    Amount = entry.Amount
                }).ToList();
            }
        }

        public void DisplayChart(DateTime fromDate, DateTime toDate, string category)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            var data = GetTop10EntriesByCategoryAndDate(fromDate, toDate, category);

            chart.Titles.Add("Top 10 Entries");

            var series = new Series
            {
                Name = "Entries",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Bar
            };

            chart.ChartAreas[0].AxisX.Interval = 1;

            foreach (var entry in data)
            {
                series.Points.AddXY(entry.Name, entry.Amount);
            }

            chart.Series.Add(series);
        }
    }
}
