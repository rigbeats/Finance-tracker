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
            LoadData();
        }

        private void RecalculateTotals(string category)
        {
            int totalAmount = 0;
            using (var context = new FinanceTrackerContext())
            {
                totalAmount = context.BudgetEntries
                    .Where(x => x.Category == category)
                    .Sum(x => x.Amount);
            }
            if (category == "Needs")
            {
                lTotalNeedsAmount.Text = totalAmount.ToString();
                lFinalNeedsAmount.Text = totalAmount.ToString();
            }
            else if (category == "Wants")
            {
                lTotalWantsAmount.Text = totalAmount.ToString();
                lFinalWantsAmount.Text = totalAmount.ToString();
            }
            else if (category == "Debts")
            {
                lTotalDebtsAmount.Text = totalAmount.ToString();
                lFinalDebtsAmount.Text = totalAmount.ToString();
            }
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
        #region loading and saving data
        public void LoadData()
        {
            using (var context = new FinanceTrackerContext())
            {
                // Load data from the database and populate the RTBs
                var entries = context.BudgetEntries.ToList();

                foreach (var entry in entries)
                {

                    //Income

                    if (entry.Name == "Income")
                    {
                        rtbIncome.Text = entry.Amount.ToString();
                    }

                    //Needs

                    else if (entry.Name == "Rent/mortgage")
                    {
                        rtbRentMortgage.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Property tax bill")
                    {
                        rtbPropertyTaxBill.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Auto insurance premiums")
                    {
                        rtbAutoInsurancePremiums.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Health insurance premiums")
                    {
                        rtbHealthInsurancePremiums.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Life insurance premiums")
                    {
                        rtbLifeInsurancePremiums.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Electricity and gas bill")
                    {
                        rtbElectricityAndGasBill.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Gasoline")
                    {
                        rtbGasoline.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Public transportation")
                    {
                        rtbPublicTransportation.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Phone bill")
                    {
                        rtbPhoneBill.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Sanitation/garbage bill")
                    {
                        rtbSanitationGarbageBill.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Groceries")
                    {
                        rtbGroceries.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Car payment")
                    {
                        rtbCarPayment.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Internet bill")
                    {
                        rtbInternetBill.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Other needs")
                    {
                        rtbOtherNeeds.Text = entry.Amount.ToString();
                    }

                    //Wants

                    else if (entry.Name == "Clothing, jewelry")
                    {
                        rtbClothingJewelry.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Dining out")
                    {
                        rtbDiningOut.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Special meals at home")
                    {
                        rtbSpecialMealsAtHome.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Alcohol")
                    {
                        rtbAlcohol.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Movie, concert tickets")
                    {
                        rtbMovieConcertTickets.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Gym/club memberships")
                    {
                        rtbGymClubMemberships.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Travel expenses")
                    {
                        rtbTravelExpenses.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Cable/streaming packages")
                    {
                        rtbCableStreamingPackages.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Home decor items")
                    {
                        rtbHomeDecorItems.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Other wants")
                    {
                        rtbOtherWants.Text = entry.Amount.ToString();
                    }

                    //Debts

                    else if (entry.Name == "Emergency contributions")
                    {
                        rtbEmergencyContributions.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Savings contributions")
                    {
                        rtbSavingsContributions.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Individual retirement")
                    {
                        rtbIndividualRetirement.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Other investments")
                    {
                        rtbOtherInvestments.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Credit card payments")
                    {
                        rtbCreditCardPayments.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Student loan payments")
                    {
                        rtbStudentLoanPayments.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Other debts")
                    {
                        rtbOtherDebts.Text = entry.Amount.ToString();
                    }

                    //Totals

                    else if (entry.Name == "Total needs")
                    {
                        lTotalNeedsAmount.Text = entry.Amount.ToString();
                        lFinalNeedsAmount.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Total wants")
                    {
                        lTotalWantsAmount.Text = entry.Amount.ToString();
                        lFinalWantsAmount.Text = entry.Amount.ToString();
                    }
                    else if (entry.Name == "Total debts")
                    {
                        lTotalDebtsAmount.Text = entry.Amount.ToString();
                        lFinalDebtsAmount.Text = entry.Amount.ToString();
                    }
                }
            }
        }

        public void SaveData()
        {
            UpdateOrInsertBudgetEntry("Income", "Income", ParseInt(rtbIncome.Text));

            //Needs

            UpdateOrInsertBudgetEntry("Needs", "Rent/mortgage", ParseInt(rtbRentMortgage.Text));
            UpdateOrInsertBudgetEntry("Needs", "Property tax bill", ParseInt(rtbPropertyTaxBill.Text));
            UpdateOrInsertBudgetEntry("Needs", "Auto insurance premiums", ParseInt(rtbAutoInsurancePremiums.Text));
            UpdateOrInsertBudgetEntry("Needs", "Health insurance premiums", ParseInt(rtbHealthInsurancePremiums.Text));
            UpdateOrInsertBudgetEntry("Needs", "Life insurance premiums", ParseInt(rtbLifeInsurancePremiums.Text));
            UpdateOrInsertBudgetEntry("Needs", "Electricity and gas bill", ParseInt(rtbElectricityAndGasBill.Text));
            UpdateOrInsertBudgetEntry("Needs", "Gasoline", ParseInt(rtbGasoline.Text));
            UpdateOrInsertBudgetEntry("Needs", "Public transportation", ParseInt(rtbPublicTransportation.Text));
            UpdateOrInsertBudgetEntry("Needs", "Phone bill", ParseInt(rtbPhoneBill.Text));
            UpdateOrInsertBudgetEntry("Needs", "Sanitation/garbage bill", ParseInt(rtbSanitationGarbageBill.Text));
            UpdateOrInsertBudgetEntry("Needs", "Groceries", ParseInt(rtbGroceries.Text));
            UpdateOrInsertBudgetEntry("Needs", "Car payment", ParseInt(rtbCarPayment.Text));
            UpdateOrInsertBudgetEntry("Needs", "Internet bill", ParseInt(rtbInternetBill.Text));
            UpdateOrInsertBudgetEntry("Needs", "Other needs", ParseInt(rtbOtherNeeds.Text));
            
            //Wants

            UpdateOrInsertBudgetEntry("Wants", "Clothing, jewelry", ParseInt(rtbClothingJewelry.Text));
            UpdateOrInsertBudgetEntry("Wants", "Dining out", ParseInt(rtbDiningOut.Text));
            UpdateOrInsertBudgetEntry("Wants", "Special meals at home", ParseInt(rtbSpecialMealsAtHome.Text));
            UpdateOrInsertBudgetEntry("Wants", "Alcohol", ParseInt(rtbAlcohol.Text));
            UpdateOrInsertBudgetEntry("Wants", "Movie, concert tickets", ParseInt(rtbMovieConcertTickets.Text));
            UpdateOrInsertBudgetEntry("Wants", "Gym/club memberships", ParseInt(rtbGymClubMemberships.Text));
            UpdateOrInsertBudgetEntry("Wants", "Travel expenses", ParseInt(rtbTravelExpenses.Text));
            UpdateOrInsertBudgetEntry("Wants", "Cable/streaming packages", ParseInt(rtbCableStreamingPackages.Text));
            UpdateOrInsertBudgetEntry("Wants", "Home decor items", ParseInt(rtbHomeDecorItems.Text));
            UpdateOrInsertBudgetEntry("Wants", "Other wants", ParseInt(rtbOtherWants.Text));

            //Debts

            UpdateOrInsertBudgetEntry("Debts", "Emergency contributions", ParseInt(rtbEmergencyContributions.Text));
            UpdateOrInsertBudgetEntry("Debts", "Savings contributions", ParseInt(rtbSavingsContributions.Text));
            UpdateOrInsertBudgetEntry("Debts", "Individual retirement", ParseInt(rtbIndividualRetirement.Text));
            UpdateOrInsertBudgetEntry("Debts", "Other investments", ParseInt(rtbOtherInvestments.Text));
            UpdateOrInsertBudgetEntry("Debts", "Credit card payments", ParseInt(rtbCreditCardPayments.Text));
            UpdateOrInsertBudgetEntry("Debts", "Student loan payments", ParseInt(rtbStudentLoanPayments.Text));
            UpdateOrInsertBudgetEntry("Debts", "Other debts", ParseInt(rtbOtherDebts.Text));

            //Totals

            UpdateOrInsertBudgetEntry("Totals", "Total needs", ParseInt(lTotalNeedsAmount.Text));
            UpdateOrInsertBudgetEntry("Totals", "Total wants", ParseInt(lTotalWantsAmount.Text));
            UpdateOrInsertBudgetEntry("Totals", "Total debts", ParseInt(lTotalDebtsAmount.Text));

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
        #endregion
        private void budgetPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveNeeds_Click(object sender, EventArgs e)
        {
            SaveData();
            RecalculateTotals("Needs");
        }

        private void btnSaveWants_Click(object sender, EventArgs e)
        {
            SaveData();
            RecalculateTotals("Wants");
        }

        private void btnSaveDebts_Click(object sender, EventArgs e)
        {
            SaveData();
            RecalculateTotals("Debts");
        }

        private void lMonthlyIncome_Click(object sender, EventArgs e)
        {

        }

        private void lInternetBill_Click(object sender, EventArgs e)
        {

        }

        private void lCarPayment_Click(object sender, EventArgs e)
        {

        }

        private void lGroceries_Click(object sender, EventArgs e)
        {

        }

        private void lSanitationGarbageBill_Click(object sender, EventArgs e)
        {

        }

        private void lPhoneBill_Click(object sender, EventArgs e)
        {

        }

        private void lPublicTransportation_Click(object sender, EventArgs e)
        {

        }

        private void lGasoline_Click(object sender, EventArgs e)
        {

        }

        private void lElectricityAndGasBill_Click(object sender, EventArgs e)
        {

        }

        private void lLifeInsurancePremiums_Click(object sender, EventArgs e)
        {

        }

        private void lHealthInsurancePremiums_Click(object sender, EventArgs e)
        {

        }

        private void lAutoInsurancePremiums_Click(object sender, EventArgs e)
        {

        }

        private void lPropertyTaxBill_Click(object sender, EventArgs e)
        {

        }

        private void lRentMortgage_Click(object sender, EventArgs e)
        {

        }

        private void lNeeds_Click(object sender, EventArgs e)
        {

        }

        private void rtbOtherNeeds_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbInternetBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbCarPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbGroceries_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbSanitationGarbageBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbPhoneBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbPublicTransportation_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbGasoline_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbElectricityAndGasBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbLifeInsurancePremiums_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbHealthInsurancePremiums_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbAutoInsurancePremiums_TextChanged(object sender, EventArgs e)
        {

        }

        private void lExpenses_Click(object sender, EventArgs e)
        {

        }

        private void lOtherNeeds_Click(object sender, EventArgs e)
        {

        }

        private void rtbPropertyTaxBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbRentMortgage_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void budgetPieChart1_Load(object sender, EventArgs e)
        {

        }

        private void budgetPieChart1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
