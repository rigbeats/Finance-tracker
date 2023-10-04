using Finance_tracker.Entity_classes;
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
    public partial class budgetPage : UserControl
    {
        public budgetPage()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        // Event handler for RichTextBox text changes
        private void InitializeEventHandlers()
        {
            // Attach TextChanged event handlers to your RTBs
            rtbIncome.TextChanged += RTB_TextChanged;
            rtbNeeds.TextChanged += RTB_TextChanged;
            rtbWants.TextChanged += RTB_TextChanged;
            LoadData();
        }

        private void RTB_TextChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            // Calculate the totals and update the corresponding RTBs
            int income = ParseInt(rtbIncome.Text);
            int needs = ParseInt(rtbNeeds.Text);
            int wants = ParseInt(rtbWants.Text);

            int totalExpenses = needs + wants;

            // Update the total RTBs
            rtbTotalExpenses.Text = totalExpenses.ToString();

            // Check if the sum of Needs, Wants, and Debts exceeds Income
            //if (totalNeeds + totalWants + totalDebts > income)
            //{
            //    Handle the case where expenses exceed income (e.g., show a warning)
            //}
        }

        private int ParseInt(string text)
        {
            // Parse an integer from the text, return 0 if parsing fails
            if (int.TryParse(text, out int result))
            {
                return result;
            }
            return 0;
        }

        public void LoadData()
        {
            using (var context = new FinanceTrackerContext())
            {
                // Load data from the database and populate the RTBs
                var entries = context.BudgetEntries.ToList();

                foreach (var entry in entries)
                {
                    if (entry.Category == "Income")
                    {
                        rtbIncome.Text = entry.Amount.ToString();
                    }
                    else if (entry.Category == "Needs")
                    {
                        rtbNeeds.Text = entry.Amount.ToString();
                    }
                    else if (entry.Category == "Wants")
                    {
                        rtbWants.Text = entry.Amount.ToString();
                    }
                    else if (entry.Category == "Totals")
                    {
                        rtbWants.Text = entry.Amount.ToString();
                    }
                    // Handle other categories similarly
                }
            }
        }

        public void SaveData()
        {
            UpdateOrInsertBudgetEntry("Income", "Income", ParseInt(rtbIncome.Text));
            UpdateOrInsertBudgetEntry("Needs", "Rent", ParseInt(rtbNeeds.Text));
            UpdateOrInsertBudgetEntry("Wants", "Utilities", ParseInt(rtbWants.Text));
            UpdateOrInsertBudgetEntry("Totals","Total Expenses", ParseInt(rtbTotalExpenses.Text));
        }

        private void UpdateOrInsertBudgetEntry(string category, string name, int amount)
        {
            using (var context = new FinanceTrackerContext())
            {
                var entry = context.BudgetEntries.SingleOrDefault(e => e.Category == category && e.Name == name);
                if (entry == null)
                {
                    // Insert a new entry if it doesn't exist
                    entry = new BudgetEntry { Category = category, Name = name, Amount = amount };
                    context.BudgetEntries.Add(entry);
                }
                else
                {
                    // Update the existing entry if it exists
                    entry.Amount = amount;
                }
                context.SaveChanges();
            }

        }
        private void budgetPage_Load(object sender, EventArgs e)
        {

        }

        private void rtbTotalExpenses_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
