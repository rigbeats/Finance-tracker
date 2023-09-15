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

namespace Finance_tracker
{
    public partial class Form1 : Form
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        (PictureBox, Label, string) selectedButton;
        int userId;

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


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // CARD

        int indexSelectedCard;

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
                transactionTable.ClearTable();

                List<Card> cards = context.Cards.Where(x => x.UserId == userId).ToList();
                int countOfCard = cards.Count;
                CountOfDots(countOfCard);

                if (countOfCard == 0)
                {
                    cardInfo.ColorCardGray();
                }
                else
                {
                    cardInfo.ColorCardBlue();

                    var cardNumber = cards[indexSelectedCard].Number;
                    var fullName = cards[indexSelectedCard].HolderFullName;
                    var validThru = cards[indexSelectedCard].ValidThru;

                    cardInfo.FillFields(
                        cardNumber,
                        fullName,
                        validThru);

                    string balance = Convert.ToString(cards[indexSelectedCard].Balance);
                    cardBalance.Balance = balance;

                    int idSelectedCard = context.Cards
                        .Where(x => x.Number == cardNumber)
                        .Select(x => x.Id)
                        .FirstOrDefault();

                    List<Transaction> transactions = context.Transactions
                        .Where(x => x.CardId == idSelectedCard)
                        .Take(8)
                        .ToList();

                    transactionTable.FillTable(transactions);
                }
            }
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

        public void CountOfDots(int count)
        {
            pbDot1.Visible = false;
            pbDot2.Visible = false;
            pbDot3.Visible = false;

            switch (count)
            {
                case 1:
                    pbDot1.Visible = true;
                    pbDot1.Location = new Point(853, 318);
                    break;
                case 2:
                    pbDot1.Visible = true;
                    pbDot1.Location = new Point(840, 318);
                    pbDot2.Visible = true;
                    pbDot2.Location = new Point(865, 318);
                    break;
                case 3:
                    pbDot1.Visible = true;
                    pbDot1.Location = new Point(828, 318);
                    pbDot2.Visible = true;
                    pbDot2.Location = new Point(853, 318);
                    pbDot3.Visible = true;
                    pbDot3.Location = new Point(878, 318);
                    break;
            }
        }

        private void SetSelectedCard(int index)
        {
            string grayDotPath = Path.Combine(projectPath, "Icons\\dot_icon.png");
            string blueDotPath = Path.Combine(projectPath, "Icons\\selected_dot_icon.png");

            pbDot1.Image = System.Drawing.Image.FromFile(grayDotPath);
            pbDot2.Image = System.Drawing.Image.FromFile(grayDotPath);
            pbDot3.Image = System.Drawing.Image.FromFile(grayDotPath);

            switch (index)
            {
                case 0:
                    indexSelectedCard = 0;
                    pbDot1.Image = System.Drawing.Image.FromFile(blueDotPath);
                    break;
                case 1:
                    indexSelectedCard = 1;
                    pbDot2.Image = System.Drawing.Image.FromFile(blueDotPath);
                    break;
                case 2:
                    indexSelectedCard = 2;
                    pbDot3.Image = System.Drawing.Image.FromFile(blueDotPath);
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

        private void pbAdditionaSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point location = new Point(
                    e.Location.X - 130,
                    e.Location.Y
                );
                AddDeleteCard.Show(pbAdditionaSettings, location);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int countOfCard;
            using (var context = new FinanceTrackerContext())
            {
                List<Card> cards = context.Cards.Where(x => x.UserId == userId).ToList();
                countOfCard = cards.Count;
            }
            if (countOfCard < 3)
            {
                CountOfDots(0);
                cardInfo.ColorCardGray();
                cardBalance.ClearBalance();

                cardInfo.TbNumberBackColor = Color.FromArgb(183, 192, 201);
                cardInfo.TbHolderBackColor = Color.FromArgb(183, 192, 201);
                cardInfo.TbValidThruBackColor = Color.FromArgb(183, 192, 201);
                cardBalance.TbBackColor = Color.FromArgb(183, 192, 201);

                cardInfo.TbNumberReadOnly = false;
                cardInfo.TbHolderReadOnly = false;
                cardInfo.TbValidThruReadOnly = false;
                cardBalance.TbReadOnly = false;
                bAdd.Visible = true;

            }
            else
                MessageBox.Show("There can be only 3 cards");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FinanceTrackerContext())
            {
                var validThru = cardInfo.ValidThru;

                var deleteCard = context.Cards
                    .Where(x => x.UserId == userId
                             && x.ValidThru == validThru)
                    .FirstOrDefault();

                if (deleteCard != null)
                {
                    context.Cards.Remove(deleteCard);
                    context.SaveChanges();
                }

                if (indexSelectedCard > 0)
                    indexSelectedCard--;
                BCard_Click(BCard, EventArgs.Empty);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string name = cardInfo.CardHolder;

            string cardNumber = cardInfo.CardNumber;
            var splitName = name.Split(' ');
            string validThru = cardInfo.ValidThru;
            string balance = cardBalance.Balance;

            bool correctData = CheckCorrectCardData(
                    cardNumber,
                    splitName.Length,
                    validThru);

            if (!Regex.IsMatch(balance, "^[0-9]+(,[0-9]+)?$"))
            {
                if (balance == "")
                    balance = "0";
                else
                {
                    MessageBox.Show("Invalid balance");
                    correctData = false;
                }
            }

            if (correctData)
            {
                cardInfo.TbNumberReadOnly = true;
                cardInfo.TbHolderReadOnly = true;
                cardInfo.TbValidThruReadOnly = true;
                cardBalance.TbReadOnly = true;
                bAdd.Visible = true;
                cardBalance.TbBackColor = Color.White;

                using (var context = new FinanceTrackerContext())
                {
                    var card = new Card
                    {
                        Number = cardNumber,
                        HolderFullName = name,
                        ValidThru = validThru,
                        Balance = Convert.ToDecimal(balance),
                        UserId = userId
                    };

                    context.Cards.Add(card);
                    context.SaveChanges();
                }
                indexSelectedCard++;
                BCard_Click(BCard, EventArgs.Empty);
            }
        }

        private bool CheckCorrectCardData(string cardNumber, int numberOfWordsInName, string validThru = "01/01")
        {
            bool eror = false;
            string erorText = string.Empty;

            if (cardNumber.Length != 16)
            {
                erorText = "Invalid card number";
                eror = true;
            }

            else if (numberOfWordsInName != 2)
            {
                erorText = "Invalid card holder";
                eror = true;
            }

            else if (!Regex.IsMatch(validThru, @"^(0[1-9]|1[0-2])\/[0-9]{2}$"))
            {
                erorText = "Invalid valid thru";
                eror = true;
            }

            if (eror)
            {
                MessageBox.Show(erorText);
                return false;
            }

            return true;
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
 