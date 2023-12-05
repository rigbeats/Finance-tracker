using Finance_tracker.Entity_classes;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_tracker.Payment
{
    public partial class TransferToTheCard : UserControl
    {
        public delegate void Transfer(object sender, Transaction transaction);
        public event Transfer MakeTransaction;

        public int? CardId { get; set; }

        public TransferToTheCard()
        {
            InitializeComponent();

            creditCard.TbHolderReadOnly = false;
            creditCard.TbNumberReadOnly = false;
            creditCard.TbValidThruReadOnly = false;
        }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            var amount = Convert.ToDecimal(tbTAmount.Text);
            string cardNumber = creditCard.CardNumber;
            var cardId = Convert.ToInt32(CardId);
            string name = creditCard.Name;
            var date = DateTime.Now;

            bool correctCardData = creditCard.CheckCorrectCardData();
            if (!correctCardData)
                MessageBox.Show("Invalid card data");
            bool correctAmount = CheckCorrectAmount();
            if (!correctAmount)
                MessageBox.Show("Invalid amount");

            if (correctCardData && correctAmount)
            {
                var transaction = new Transaction()
                {
                    CardId = cardId,
                    Amount = amount,
                    Category = "Card",
                    Date = date,
                    Number = cardNumber,
                };

                MakeTransaction?.Invoke(this, transaction);
            }
        }

        private bool CheckCorrectAmount()
        {
            string amount = tbTAmount.Text;
            amount = amount.Trim();

            if (Regex.IsMatch(amount, @"^[0-9]+$"))
            {
                return true;
            }

            return false;
        }

        public void ClearTitles()
        {
            creditCard.ClearCard();
            tbTAmount.Clear();
        }
    }
}
