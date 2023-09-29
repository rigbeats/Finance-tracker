using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;

namespace Finance_tracker.PaymentPage
{
    public partial class PaymentPage : UserControl
    {
        public int? CardId { get; set; }

        public PaymentPage()
        {
            InitializeComponent();

            payment.CardId = CardId;
            transferToTheCard.CardId = CardId;

            internetPayment.OpenTransaction += OpenTransaction;
            mobilePayment.OpenTransaction += OpenTransaction;
            utilitiesPayment.OpenTransaction += OpenTransaction;

            payment.MakeTransaction += MakeTransaction;
            transferToTheCard.MakeTransaction += MakeTransaction;
        }

        private void MakeTransaction(object sender, Transaction transaction)
        {
            if (CardId == null)
                MessageBox.Show("Please choose the default card in the settings");
            else
            {
                using (var context = new FinanceTrackerContext())
                {
                    var cardBalance = context.Cards
                        .Where(x => x.Id == CardId)
                        .Select(x => x.Balance)
                        .FirstOrDefault();    

                    var amountOfTransaction = Convert.ToDecimal(transaction.Amount);

                    if (amountOfTransaction > cardBalance)
                        MessageBox.Show("Insufficient funds on the balance sheet");
                    else
                    {
                        context.Transactions.Add(transaction);

                        context.Cards
                            .Find(CardId)
                            .Balance -= amountOfTransaction;

                        context.SaveChanges();

                        MessageBox.Show("The payment was successful");
                        
                        if (sender.GetType() == typeof(Payment.Payment))
                            payment.ClearTitles();
                        else if (sender.GetType() == typeof(Payment.TransferToTheCard))
                            transferToTheCard.ClearTitles();
                    }
                }
            }
        }

        private void OpenTransaction(string title)
        {
            payment.UpdatePurposeTitle(title);
            payment.Update();

            payment.Category = title;
            payment.Enabled = true;
        }

        private void utilitiesPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
}
