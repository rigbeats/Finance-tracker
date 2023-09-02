using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;

namespace Finance_tracker
{
    public partial class Form1 : Form
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        (PictureBox, Label, string) selectedButton;
        int userId;
        int indexSelectedCard;

        public Form1(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            SelectButton(
                "Icons\\selected_compass_icon.png",
                pbOverview,
                lOverview,
                Overview
                );

            //запрос к базе данных для ускорения последующих
            await Task.Run(async () =>
            {
                using (var context = new FinanceTrackerContext())
                {
                    await context.Cards.FirstOrDefaultAsync();
                }
            });
        }

        private void DeselectButton()
        {
            string imagePath = selectedButton.Item3;
            imagePath = imagePath.Replace("selected_", "");
            selectedButton.Item1.Image = Image.FromFile(imagePath);
            selectedButton.Item2.ForeColor = Color.FromArgb(74, 85, 103);
        }

        private void SelectButton(string path, PictureBox pictureBox, Label label, TabPage tabPage)
        {
            string imagePath = Path.Combine(projectPath, path);

            tabControl.SelectedTab = tabPage;
            pictureBox.Image = Image.FromFile(imagePath);
            label.ForeColor = Color.FromArgb(36, 94, 231);

            //сохранение нажатой кнопки
            selectedButton.Item1 = pictureBox;
            selectedButton.Item2 = label;
            selectedButton.Item3 = imagePath;
        }

        private void BOverview_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_compass_icon.png",
                pbOverview,
                lOverview,
                Overview
                );
        }

        private void BCard_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_credit_card_icon.png",
                pbCard,
                lCard,
                Card
                );

            using (var context = new FinanceTrackerContext())
            {
                lastTransactionsTable.Items.Clear();

                List<Card> cards = context.Cards.Where(x => x.UserId == userId).ToList();
                if (cards.Count == 0)
                {
                    string ImagePath = Path.Combine(projectPath, "Images\\gray_card.png");
                    pbLargeCard.Image = Image.FromFile(ImagePath);

                    lCardTitle1.BackColor = Color.FromArgb(166, 174, 183);
                    lCardTitle3.BackColor = Color.FromArgb(166, 174, 183);
                    lCardTitle2.BackColor = Color.FromArgb(166, 174, 183);
                }
                else
                {
                    switch (cards.Count)
                    {
                        case 1:
                            pbDot1.Visible = true;
                            pbDot1.Location = new Point(156, 240);
                            break;
                        case 2:
                            pbDot1.Visible = true;
                            pbDot1.Location = new Point(144, 240);
                            pbDot2.Visible = true;
                            pbDot2.Location = new Point(169, 240);
                            break;
                        case 3:
                            pbDot1.Visible = true;
                            pbDot1.Location = new Point(131, 240);
                            pbDot2.Visible = true;
                            pbDot2.Location = new Point(156, 240);
                            pbDot3.Visible = true;
                            pbDot3.Location = new Point(181, 240);
                            break;
                    }
                    var cardNumber = cards[indexSelectedCard].Number;
                    lCardNumber.Text = string.Concat("**** **** **** ", cardNumber.Substring(12));

                    string fullName = cards[indexSelectedCard].HolderName 
                        + " " 
                        + cards[indexSelectedCard].HolderSurname;

                    lCardHolder.Text = fullName;

                    lValidThru.Text = cards[indexSelectedCard].ValidThru;

                    tBalance.Text = cards[indexSelectedCard].Balance;


                    ListViewItem listViewItem = null;

                    int idSelectedCard = context.Cards
                        .Where(x => x.Number == cardNumber)
                        .Select(x => x.Id)
                        .FirstOrDefault();
                        
                    List<Transaction> transactions = context.Transactions
                        .Where(x => x.CardId == idSelectedCard)
                        .Take(8)
                        .ToList();

                    for (int i = 0; i < transactions.Count; i++)
                    {
                        var date = transactions[i].Date;
                        listViewItem = new ListViewItem(new string[]
                        {
                            Convert.ToString(i + 1),
                            Convert.ToString(transactions[i].Amount),
                            transactions[i].Target,
                            transactions[i].Category,
                            $"{date.Day}/{date.Month}/{date.Year}"
                        });

                        lastTransactionsTable.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void BBudget_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_dollar_sign_icon.png",
                pbBudget,
                lBudget,
                Budget
                );
        }

        private void BPayment_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_money_icon.png",
                pbPayment,
                lPayment,
                Payment
                );
        }

        private void BStatistics_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_statistics_icon.png",
                pbStatistics,
                lStatistics,
                Statistics
                );
        }

        private void BReport_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_save_icon.png",
                pbReport,
                lReport,
                Report
                );
        }

        private void BAccount_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_user_icon.png",
                pbAccount,
                lAccount,
                Account
                );
        }

        private void BLogout_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_user_minus_icon.png",
                pbLogout,
                lLogout,
                Logout
                );
        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_settings_icon.png",
                pbSettings,
                lSettings,
                Settings
                );
        }

        private void SetSelectedCard(int index)
        {
            string grayDotPath = Path.Combine(projectPath, "Icons\\dot_icon.png");
            string blueDotPath = Path.Combine(projectPath, "Icons\\selected_dot_icon.png");

            pbDot1.Image = Image.FromFile(grayDotPath);
            pbDot2.Image = Image.FromFile(grayDotPath);
            pbDot3.Image = Image.FromFile(grayDotPath);

            switch(index)
            {
                case 0:
                    indexSelectedCard = 0;
                    pbDot1.Image = Image.FromFile(blueDotPath);
                    break;
                case 1:
                    indexSelectedCard = 1;
                    pbDot2.Image = Image.FromFile(blueDotPath);
                    break;
                case 2:
                    indexSelectedCard = 2;
                    pbDot3.Image = Image.FromFile(blueDotPath);
                    break;
            }
        }

        private void pbDot1_Click(object sender, EventArgs e)
        {
            SetSelectedCard(0);
            BCard_Click(BCard, EventArgs.Empty);
        }

        private void pbDot2_Click(object sender, EventArgs e)
        {
            SetSelectedCard(1);
            BCard_Click(BCard, EventArgs.Empty);
        }

        private void pbDot3_Click(object sender, EventArgs e)
        {
            SetSelectedCard(2);
            BCard_Click(BCard, EventArgs.Empty);
        }
    }
}
