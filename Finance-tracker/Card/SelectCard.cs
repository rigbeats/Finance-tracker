using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;
using Org.BouncyCastle.Asn1.X509;

namespace Finance_tracker.Controls
{
    public partial class SelectCard : UserControl
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        int indexSelectedCard;

        public int UserId { get; set; }

        public CardBalance CardBalance { get; set; }

        public int IndexSelectedCard
        {
            get { return indexSelectedCard; }
            set { indexSelectedCard = value; }
        }

        public CreditCard CreditCard { get; set; }

        public event Action UpdateCardTab;

        public SelectCard()
        {
            InitializeComponent();

            CreditCard = this.creditCard;
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
                creditCard.ColorCardGray();
                CardBalance.ClearBalance();

                creditCard.TbNumberBackColor = Color.FromArgb(183, 192, 201);
                creditCard.TbHolderBackColor = Color.FromArgb(183, 192, 201);
                creditCard.TbValidThruBackColor = Color.FromArgb(183, 192, 201);
                CardBalance.TbBackColor = Color.FromArgb(183, 192, 201);

                creditCard.TbNumberReadOnly = false;
                creditCard.TbHolderReadOnly = false;
                creditCard.TbValidThruReadOnly = false;
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
                var validThru = creditCard.ValidThru;

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
            bool correctCardData = creditCard.CheckCorrectCardData();
            bool correctBalance = CardBalance.CheckCorrectBalance();

            if (correctCardData && correctBalance)
            {
                creditCard.TbNumberReadOnly = true;
                creditCard.TbHolderReadOnly = true;
                creditCard.TbValidThruReadOnly = true;
                CardBalance.TbReadOnly = true;
                bAdd.Visible = true;

                CardBalance.TbBackColor = Color.White;

                string balance = CardBalance.Balance;
                var card = new Card
                {
                    Number = creditCard.CardNumber,
                    HolderFullName = creditCard.CardHolder,
                    ValidThru = creditCard.ValidThru,
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
            var validThru = creditCard.ValidThru;

            using (var context = new FinanceTrackerContext())
            {
                var cardNumber = context.Cards
                    .Where(x => x.UserId == UserId
                        && x.ValidThru == validThru)
                    .Select(x => x.Number)
                    .FirstOrDefault();

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
