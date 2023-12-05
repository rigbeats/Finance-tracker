using System;
using System.Windows.Forms;

namespace Finance_tracker.Statistics
{
    public partial class statisticsPage : UserControl
    {
        public DateTime from = DateTime.Now;
        public DateTime to = DateTime.Now;
        public statisticsPage()
        {
            InitializeComponent();

        }
        private void statisticsPage_Load(object sender, EventArgs e)
        {

        }

        private void statisticsLineChart_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            from = dateTimePickerFrom.Value;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            to = dateTimePickerTo.Value;
        }

        private void statisticsBarChart1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonNeeds_CheckedChanged(object sender, EventArgs e)
        {
            statisticsPieChart.DisplayPieChart("Needs");
            statisticsBarChart.DisplayChart(from, to, "Needs");
        }

        private void radioButtonWants_CheckedChanged(object sender, EventArgs e)
        {
            statisticsPieChart.DisplayPieChart("Wants");
            statisticsBarChart.DisplayChart(from, to, "Wants");
        }

        private void radioButtonDebts_CheckedChanged(object sender, EventArgs e)
        {
            statisticsPieChart.DisplayPieChart("Debts");
            statisticsBarChart.DisplayChart(from, to, "Debts");
        }
    }
}
