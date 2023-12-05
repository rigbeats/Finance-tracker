using System;
using System.Windows.Forms;

namespace Finance_tracker
{
    public partial class GoalProgressBar : UserControl
    {
        public int GoalAmount { get; set; }
        public int CurrentAmount { get; set; }

        public GoalProgressBar()
        {
            InitializeComponent();
        }

        public void UpdateProgress()
        {
            if (GoalAmount != 0)
            {
                decimal percentage = ((decimal)CurrentAmount / GoalAmount) * 100;
                progressBar.Value = (int)percentage;

                lblProgress.Text = $"{CurrentAmount:C} / {GoalAmount:C} ({percentage:F2}%)";
            }
            else
            {
                progressBar.Value = 0;
                lblProgress.Text = "Goal Amount is zero.";
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbGoalAmount.Text))
            {
                MessageBox.Show("Please enter a valid goal amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbGoalAmount.Text, out int goalAmount) || goalAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive numeric goal amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GoalAmount = goalAmount;

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAmount.Text, out int enteredAmount))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentAmount += enteredAmount;

            UpdateProgress();

            txtAmount.Clear();
        }
    }
}
