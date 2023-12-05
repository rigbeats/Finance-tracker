using Finance_tracker.Entity_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
// TODO: do something about the text on the chart it looks awful
namespace Finance_tracker.Statistics
{
    public partial class StatisticsPieChart : UserControl
    {
        public StatisticsPieChart()
        {
            InitializeComponent();
        }
        private List<BudgetEntry> GetTop6ExpensiveItems(string category)
        {
            using (var context = new FinanceTrackerContext())
            {
                return context.BudgetEntries
                    .Where(item => item.Category == category)
                    .OrderByDescending(item => item.Amount)
                    .Take(6)
                    .ToList();
            }
        }

        private List<(string Label, int Value)> PrepareDataForPieChart(List<BudgetEntry> items)
        {
            return items
                .Select(item => (Label: item.Name, Value: item.Amount))
                .ToList();
        }
        private void BindDataToPieChart(List<(string Label, int Value)> pieChartData, string category)
        {
            pieChartStatistics.Series.Clear();
            var series = new Series(category);
            series.ChartType = SeriesChartType.Pie;

            series["PieLabelStyle"] = "Disabled";

            foreach (var dataPoint in pieChartData)
            {
                series.Points.AddXY(dataPoint.Label, dataPoint.Value);
            }

            pieChartStatistics.Series.Add(series);
        }
        public void DisplayPieChart(string category)
        {
            var top6Items = GetTop6ExpensiveItems(category);
            var pieChartData = PrepareDataForPieChart(top6Items);
            BindDataToPieChart(pieChartData, category);
        }

        private void pieChartStatistics_Click(object sender, EventArgs e)
        {

        }

        private void StatisticsPieChart_Load(object sender, EventArgs e)
        {

        }
    }
}
