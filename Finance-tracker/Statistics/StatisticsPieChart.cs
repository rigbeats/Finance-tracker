using Finance_tracker.Entity_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_tracker.Statistics
{
    public partial class StatisticsPieChart : UserControl
    {
        public StatisticsPieChart()
        {
            InitializeComponent();
        }

        private List<BudgetEntry> GetTop5ExpensiveItems()
        {
            using (var context = new FinanceTrackerContext())
            {
                return context.BudgetEntries
                    .OrderByDescending(item => item.Amount)
                    .Take(5)
                    .ToList();
            }
        }

        private List<(string Label, int Value)> PrepareDataForPieChart(List<BudgetEntry> items)
        {
            return items
                .Select(item => (Label: item.Name, Value: item.Amount))
                .ToList();
        }
        private void BindDataToPieChart(List<(string Label, int Value)> data)
        {
            pieChartStatistics.Series["Expenses"].Points.DataBind(data, "Label", "Value", "");
        }
        public void DisplayPieChart()
        {
            var top5Items = GetTop5ExpensiveItems();
            var pieChartData = PrepareDataForPieChart(top5Items);
            BindDataToPieChart(pieChartData);
        }

    }
}
