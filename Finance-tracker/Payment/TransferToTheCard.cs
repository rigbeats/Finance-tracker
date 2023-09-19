using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_tracker.Payment
{
    public partial class TransferToTheCard : UserControl
    {
        public TransferToTheCard()
        {
            InitializeComponent();

            creditCard.TbHolderReadOnly = false;
            creditCard.TbNumberReadOnly = false;
            creditCard.TbValidThruReadOnly = false;
        }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            string cardNumber = creditCard.CardNumber;
            string name = creditCard.Name;

            bool correctCardData = creditCard.CheckCorrectCardData();
            bool correctAmount = CheckCorrectAmount();

            if (correctCardData && correctAmount)
            {

            }
        }

        private bool CheckCorrectAmount()
        {
            string amount = tbTAmount.Text;

            if (Regex.IsMatch(amount, @"^[0-9]+$"))
            {
                return true;
            }

            return false;
        }
    }
}
