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

        string selectedPeriod = "week";

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

        private void ColorChoosedPeriodButton(int index)
        {
            bLastWeek.BackColor = Color.FromArgb(166, 174, 183);
            bLastMonth.BackColor = Color.FromArgb(166, 174, 183);
            bLastYear.BackColor = Color.FromArgb(166, 174, 183);

            switch (index)
            {
                case 0:
                    bLastWeek.BackColor = Color.FromArgb(74, 85, 103);
                    break;
                case 1:
                    bLastMonth.BackColor = Color.FromArgb(74, 85, 103);
                    break;
                case 2:
                    bLastYear.BackColor = Color.FromArgb(74, 85, 103);
                    break;
            }
        }

        private void bLastWeek_Click(object sender, EventArgs e)
        {
            ColorChoosedPeriodButton(0);
            selectedPeriod = "week";
        }

        private void bLastMonth_Click(object sender, EventArgs e)
        {
            ColorChoosedPeriodButton(1);
            selectedPeriod = "month";
        }

        private void bLastYear_Click(object sender, EventArgs e)
        {
            ColorChoosedPeriodButton(2);
            selectedPeriod = "year";
        }

        private void bSaveReport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreatePdfFile();
            }
        }

        private void CreatePdfFile()
        {
            string pdfPath = saveFileDialog.FileName;

            var doc = new Document();
            var writer = PdfWriter.GetInstance(doc,
                new FileStream(pdfPath, FileMode.Create));

            doc.Open();

            var font = FontFactory.GetFont("Arial", 16);
            var paragraph = new Paragraph("Account statement", font);
            paragraph.Alignment = Element.ALIGN_CENTER;

            doc.Add(paragraph);
            doc.Add(new Chunk());

            var table = CreateTableWithTransactions();
            doc.Add(table);

            doc.Close();
        }

        private PdfPTable CreateTableWithTransactions()
        {
            var table = new PdfPTable(4);
            var headers = new string[]
            {
                "Amount",
                "Transaction",
                "Category",
                "Date"
            };

            foreach (var header in headers)
            {
                table.AddCell(GetCellWithText(header, true));
            }

            var transactions = GetLastTransactions();
            foreach (var transaction in transactions)
            {
                var date = transaction.Date;

                table.AddCell(GetCellWithText(transaction.Amount));
                table.AddCell(GetCellWithText(transaction.Target));
                table.AddCell(GetCellWithText(transaction.Category));
                table.AddCell(GetCellWithText($"{date.Day}.{date.Month}.{date.Year}"));
            }

            return table;
        }

        private DateTime GetInitialDate(string selectedPeriod)
        {
            var currentDate = DateTime.Now;
            DateTime initialDate;

            switch (selectedPeriod)
            {
                case "week":
                    initialDate = currentDate.AddDays(-7);
                    break;
                case "month":
                    initialDate = currentDate.AddMonths(-1);
                    break;
                default:
                    initialDate = currentDate.AddYears(-1);
                    break;
            }

            return initialDate;
        }

        private List<Transaction> GetLastTransactions()
        {
            var transactions = new List<Transaction>();

            using (var context = new FinanceTrackerContext())
            {
                var currentDate = DateTime.Now;
                var initialDate = GetInitialDate(selectedPeriod);

                transactions = context.Transactions
                    .Where(x => x.Date >= initialDate
                        && x.Date <= currentDate)
                    .ToList();
            }

            return transactions;
        }

        private PdfPCell GetCellWithText<T>(T content, bool verticalAlignment = false)
        {
            var phraze = new Phrase(Convert.ToString(content));
            var cell = new PdfPCell(phraze);
            cell.FixedHeight = 25;
            if (verticalAlignment)
                cell.HorizontalAlignment = Element.ALIGN_CENTER;

            return cell;
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
