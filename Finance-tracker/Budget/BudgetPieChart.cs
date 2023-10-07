using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_tracker.Budget
{
    public partial class BudgetPieChart : UserControl
    {
        public BudgetPieChart()
        {
            InitializeComponent();
            pieChartExpenses.Titles.Add("Expenses");

            // TODO: send actual data instead of mock data inside 
            pieChartExpenses.Series["ExpensesSeries"].Points.AddXY("Needs", "33");
            pieChartExpenses.Series["ExpensesSeries"].Points.AddXY("Wants", "33");
            pieChartExpenses.Series["ExpensesSeries"].Points.AddXY("Savings/debts", "33");

        }
    }
}
