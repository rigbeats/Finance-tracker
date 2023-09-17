using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;

namespace Finance_tracker.Controls
{
    public partial class cardTab : UserControl
    {
        public int UserId { get; set; }

        public cardTab()
        {
            InitializeComponent();

            this.cardInfo.UserId = UserId;
            this.cardInfo.CardBalance = this.cardBalance;

            cardInfo.UpdateCardTab += UpdateTab;
        }

        public void UpdateTab()
        {
            List<Card> cards;
            int countOfCards;

            using (var context = new FinanceTrackerContext())
            {
                cards = context.Cards.Where(x => x.UserId == UserId).ToList();
            }

            countOfCards = cards.Count;
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

                var transactions = cardInfo.GetLastTransaction();
                transactionTable.FillTable(transactions);
            }
            else
            {
                cardInfo.ColorCardGray();
            }
        }
    }
}
