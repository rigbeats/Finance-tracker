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
    public partial class cardPage : UserControl
    {
        public int UserId { get; set; }

        public cardPage()
        {
            InitializeComponent();
            selectCard.UserId = UserId;
            selectCard.CardBalance = this.cardBalance;

            selectCard.UpdateCardPage += UpdateTable;
        }

        public void UpdateTable()
        {
            List<Card> cards;
            int countOfCards;

            using (var context = new FinanceTrackerContext())
            {
                cards = context.Cards
                    .Where(x => x.UserId == UserId)
                    .ToList();
            }

            countOfCards = cards.Count;
            if (countOfCards > 0)
            {
                selectCard.CountOfDots(countOfCards);
                selectCard.CreditCard.ColorCardBlue();

                var indexSelectedCard = selectCard.IndexSelectedCard;
                var cardNumber = cards[indexSelectedCard].Number;
                var fullName = cards[indexSelectedCard].HolderFullName;
                var validThru = cards[indexSelectedCard].ValidThru;
                var balance = Convert.ToString(cards[indexSelectedCard].Balance);

                selectCard.CreditCard.FillFields(
                    cardNumber,
                    fullName,
                    validThru);
                cardBalance.Balance = balance;

                var transactions = selectCard.GetLastTransaction();
                transactionTable.FillTable(transactions);
            }
            else
            {
                selectCard.CreditCard.ColorCardGray();
            }
        }
    }
}
