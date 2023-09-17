using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Utilities;
using Finance_tracker.Controls;
using System.Dynamic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Finance_tracker
{
    public partial class Form1 : Form
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        (PictureBox, Label, string) selectedButton;
        int userId;

        public Form1(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            this.cardInfo.UserId = userId;
            this.cardInfo.CardBalance = this.cardBalance;


            cardInfo.CardClick += BCard_Click;
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
            selectedButton.Item1.Image = System.Drawing.Image.FromFile(imagePath);
            selectedButton.Item2.ForeColor = Color.FromArgb(74, 85, 103);
        }

        private void SelectButton(string path, PictureBox pictureBox, Label label, TabPage tabPage)
        {
            string imagePath = Path.Combine(projectPath, path);

            tabControl.SelectedTab = tabPage;
            pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
            label.ForeColor = Color.FromArgb(36, 94, 231);

            selectedButton.Item1 = pictureBox;
            selectedButton.Item2 = label;
            selectedButton.Item3 = imagePath;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // CARD

        private void BCard_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_credit_card_icon.png",
                pbCard,
                lCard,
                Card
                );

            transactionTable.ClearTable();
            List<Card> cards;
            int countOfCards;

            using (var context = new FinanceTrackerContext())
            {
                cards = context.Cards.Where(x => x.UserId == userId).ToList();
                countOfCards = cards.Count;
            }

            if (countOfCards > 0)
            {
                cardInfo.CountOfDots(countOfCards);
                cardInfo.ColorCardBlue();

                var indexSelectedCard = cardInfo.IndexSelectedCard;
                var cardNumber = cards[indexSelectedCard].Number;
                var fullName = cards[indexSelectedCard].HolderFullName;
                var validThru = cards[indexSelectedCard].ValidThru;
                var balance = Convert.ToString(cards[indexSelectedCard].Balance);

                cardInfo.FillFields(
                    cardNumber,
                    fullName,
                    validThru);
                cardBalance.Balance = balance;

                List<Transaction> transactions;
                using (var context = new FinanceTrackerContext())
                {
                    int idSelectedCard = context.Cards
                    .Where(x => x.Number == cardNumber)
                    .Select(x => x.Id)
                    .FirstOrDefault();

                    transactions = context.Transactions
                        .Where(x => x.CardId == idSelectedCard)
                        .Take(8)
                        .ToList();
                }

                transactionTable.FillTable(transactions);
            }
            else
            {
                cardInfo.ColorCardGray();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //REPORT

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

        ///////////////////////////////////////////////////////////////////
        //TRANSFER

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

        private void bTransfer_Click(object sender, EventArgs e)
        {
            //string cardNumber = tbTCardNumber.Text;
            //string[] name = tbCardHolder.Text.Split(' ');

            //bool correctData = CheckCorrectCardData(
            //   cardNumber,
            //    name.Length);

            //if (correctData)
            //{

            //}
        }

        private void MakeTransaction()
        {
            using (var context = new FinanceTrackerContext())
            {
                int? defaultCardId = context.Users
                    .Where(x => x.Id == userId)
                    .FirstOrDefault()
                    .DefaultCardId;

                if (defaultCardId == null)
                    MessageBox.Show("Please select the default card in Settings");

                else
                {
                    var transaction = new Transaction()
                    {
                        CardId = Convert.ToInt32(defaultCardId),
                    };
                }


            }
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
    }
}
