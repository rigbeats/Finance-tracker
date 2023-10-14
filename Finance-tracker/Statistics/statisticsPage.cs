using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_tracker.Statistics
{
    public partial class statisticsPage : UserControl
    {
        public statisticsPage()
        {
            InitializeComponent();
        }

        private void statisticsPage_Load(object sender, EventArgs e)
        {

        }
        private void radioButtonNeeds_CheckedChanged(object sender, EventArgs e)
        {
            statisticsPieChart.DisplayPieChart("Needs");
        }

        private void radioButtonWants_CheckedChanged(object sender, EventArgs e)
        {
            statisticsPieChart.DisplayPieChart("Wants");
        }

        private void radioButtonDebts_CheckedChanged(object sender, EventArgs e)
        {
            statisticsPieChart.DisplayPieChart("Debts");
        }

        private void statisticsBarChart1_Load(object sender, EventArgs e)
        {

        }
    }
}
