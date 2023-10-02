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
            //rtbWants1.TextChanged += RTB_TextChanged;
            //rtbWants2.TextChanged += RTB_TextChanged;
            //rtbDebts1.TextChanged += RTB_TextChanged;
            //rtbDebts2.TextChanged += RTB_TextChanged;
            //rtbTotalNeeds.TextChanged += RTB_TextChanged;
            //rtbTotalWants.TextChanged += RTB_TextChanged;
            //rtbTotalDebts.TextChanged += RTB_TextChanged;

            // Initialize the form when it's loaded
            LoadData();
        }

        private void RTB_TextChanged(object sender, EventArgs e)
        {
            // Handle RTB text changed event
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
            //rtbTotalNeeds.Text = totalNeeds.ToString();
            //rtbTotalWants.Text = totalWants.ToString();
            //rtbTotalDebts.Text = totalDebts.ToString();

            //// Check if the sum of Needs, Wants, and Debts exceeds Income
            //if (totalNeeds + totalWants + totalDebts > income)
            //{
            //    // Handle the case where expenses exceed income (e.g., show a warning)
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
                //var entries = context.BudgetEntries.ToList();
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
                    // Handle other categories similarly
                }
            }
        }

        public void SaveData()
        {
            using (var context = new FinanceTrackerContext())
            {
                // Update or insert data into the database based on the RTB values
                UpdateOrInsertBudgetEntry(context, "Income", "Income", ParseInt(rtbIncome.Text));
                UpdateOrInsertBudgetEntry(context, "Needs", "Rent", ParseInt(rtbNeeds.Text));
                UpdateOrInsertBudgetEntry(context, "Wants", "Utilities", ParseInt(rtbWants.Text));
                // Handle other categories similarly

                // Save changes to the database
                context.SaveChanges();
            }
        }

        private void UpdateOrInsertBudgetEntry(FinanceTrackerContext context, string category, string name, int amount)
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
        }
        private void budgetPage_Load(object sender, EventArgs e)
        {

        }

        private void rtbTotalExpenses_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
