using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;


namespace Finance_tracker.Controls
{
    public partial class CardInfo : UserControl
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        int indexSelectedCard;
        public int UserId { get; set; }
        public CardBalance CardBalance { get; set; }

        public string CardNumber
        { get { return tbCardNumber.Text; } }

        public string CardHolder
        { get { return tbCardHolder.Text; } }

        public string ValidThru
        { get { return tbValidThru.Text; } }

        public Color TbNumberBackColor
        { set { tbCardNumber.BackColor = value; } }

        public Color TbHolderBackColor
        { set { tbCardHolder.BackColor = value; } }

        public Color TbValidThruBackColor
        { set { tbValidThru.BackColor = value; } }

        public bool TbNumberReadOnly
        { set { tbCardNumber.ReadOnly = value; } }

        public bool TbHolderReadOnly
        { set { tbCardHolder.ReadOnly = value; } }

        public bool TbValidThruReadOnly
        { set { tbValidThru.ReadOnly = value; } }

        public int IndexSelectedCard
        {
            get { return indexSelectedCard; }
            set { indexSelectedCard = value; }
        }

        public event Action UpdateCardTab;

        public CardInfo()
        {
            InitializeComponent();
        }

        public void FillFields(string number, string fullName, string validThru)
        {
            var cardNumber = string.Concat("**** **** **** ", number.Substring(12));
            tbCardNumber.Text = cardNumber;
            tbCardHolder.Text = fullName;
            tbValidThru.Text = validThru;
        }

        public void ColorCardBlue()
        {
            string ImagePath = Path.Combine(projectPath, "Images\\blue_card.png");
            pbLargeCard.Image = System.Drawing.Image.FromFile(ImagePath);

            lCardTitle1.BackColor = Color.FromArgb(36, 95, 232);
            lCardTitle3.BackColor = Color.FromArgb(36, 95, 232);
            lCardTitle2.BackColor = Color.FromArgb(36, 95, 232);
            tbCardHolder.BackColor = Color.FromArgb(36, 95, 232);
            tbValidThru.BackColor = Color.FromArgb(36, 95, 232);
            tbCardNumber.BackColor = Color.FromArgb(36, 95, 232);

            tbCardNumber.Clear();
            tbValidThru.Clear();
            tbCardHolder.Clear();
        }

        public void ColorCardGray()
        {
            string ImagePath = Path.Combine(projectPath, "Images\\gray_card.png");
            pbLargeCard.Image = System.Drawing.Image.FromFile(ImagePath);

            lCardTitle1.BackColor = Color.FromArgb(166, 174, 183);
            lCardTitle3.BackColor = Color.FromArgb(166, 174, 183);
            lCardTitle2.BackColor = Color.FromArgb(166, 174, 183);
            tbCardHolder.BackColor = Color.FromArgb(166, 174, 183);
            tbValidThru.BackColor = Color.FromArgb(166, 174, 183);
            tbCardNumber.BackColor = Color.FromArgb(166, 174, 183);

            tbCardNumber.Clear();
            tbValidThru.Clear();
            tbCardHolder.Clear();
        }

        public bool CheckCorrectCardData()
        {
            string cardNumber = tbCardNumber.Text;
            var cardHolder = tbCardHolder.Text;
            string validThru = tbValidThru.Text;
            int numberOfWordsInName = cardHolder.Split(' ').Length;

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

        public void CountOfDots(int count)
        {
            pbDot1.Visible = false;
            pbDot2.Visible = false;
            pbDot3.Visible = false;

            switch (count)
            {
                case 1:
                    pbDot1.Visible = true;
                    pbDot1.Location = new Point(155, 242);
                    break;
                case 2:
                    pbDot1.Visible = true;
                    pbDot1.Location = new Point(142, 242);
                    pbDot2.Visible = true;
                    pbDot2.Location = new Point(167, 242);
                    break;
                case 3:
                    pbDot1.Visible = true;
                    pbDot1.Location = new Point(130, 242);
                    pbDot2.Visible = true;
                    pbDot2.Location = new Point(155, 242);
                    pbDot3.Visible = true;
                    pbDot3.Location = new Point(180, 242);
                    break;
            }
        }

        public void SetSelectedCard(int dotNumber)
        {
            string grayDotPath = Path.Combine(projectPath, "Icons\\dot_icon.png");
            string blueDotPath = Path.Combine(projectPath, "Icons\\selected_dot_icon.png");

            pbDot1.Image = Image.FromFile(grayDotPath);
            pbDot2.Image = Image.FromFile(grayDotPath);
            pbDot3.Image = Image.FromFile(grayDotPath);

            switch (dotNumber)
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
            UpdateCardTab?.Invoke();
        }

        private void pbDot2_Click(object sender, EventArgs e)
        {
            SetSelectedCard(1);
            UpdateCardTab.Invoke();
        }

        private void pbDot3_Click(object sender, EventArgs e)
        {
            SetSelectedCard(2);
            UpdateCardTab?.Invoke();
        }

        private void pbAdditionaSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var location = new Point(
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
                var cards = context.Cards.Where(x => x.UserId == UserId).ToList();
                countOfCard = cards.Count;
            }

            if (countOfCard < 3)
            {
                CountOfDots(0);
                ColorCardGray();
                CardBalance.ClearBalance();

                TbNumberBackColor = Color.FromArgb(183, 192, 201);
                TbHolderBackColor = Color.FromArgb(183, 192, 201);
                TbValidThruBackColor = Color.FromArgb(183, 192, 201);
                CardBalance.TbBackColor = Color.FromArgb(183, 192, 201);

                TbNumberReadOnly = false;
                TbHolderReadOnly = false;
                TbValidThruReadOnly = false;
                CardBalance.TbReadOnly = false;
                bAdd.Visible = true;

            }
            else
                MessageBox.Show("There can be only 3 cards");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new FinanceTrackerContext())
            {
                var validThru = ValidThru;

                var deleteCard = context.Cards
                    .Where(x => x.UserId == UserId
                             && x.ValidThru == validThru)
                    .FirstOrDefault();

                if (deleteCard != null)
                {
                    context.Cards.Remove(deleteCard);
                    context.SaveChanges();
                }
            }

            if (IndexSelectedCard > 0)
                IndexSelectedCard--;

            UpdateCardTab?.Invoke();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string balance = CardBalance.Balance;
            bool correctCardData = CheckCorrectCardData();
            bool correctBalance = CardBalance.CheckCorrectBalance();

            if (correctCardData && correctBalance)
            {
                TbNumberReadOnly = true;
                TbHolderReadOnly = true;
                TbValidThruReadOnly = true;
                CardBalance.TbReadOnly = true;
                bAdd.Visible = true;

                CardBalance.TbBackColor = Color.White;

                var card = new Card
                {
                    Number = CardNumber,
                    HolderFullName = CardHolder,
                    ValidThru = ValidThru,
                    Balance = Convert.ToDecimal(balance),
                    UserId = UserId
                };

                using (var context = new FinanceTrackerContext())
                {
                    context.Cards.Add(card);
                    context.SaveChanges();
                }

                IndexSelectedCard++;
                UpdateCardTab?.Invoke();
            }
        }

        public List<Transaction> GetLastTransaction()
        {
            List<Transaction> transactions;
            var cardNumber = tbCardNumber.Text;

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

            return transactions;
        }
    }
}
