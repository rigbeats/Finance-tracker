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
using iTextSharp.text.pdf.security;

namespace Finance_tracker.Payment
{
    public partial class Payment : UserControl
    {
        public int? CardId { get; set; }

        public delegate void Transfer(object sender, Transaction transaction);
        public event Transfer MakeTransaction;

        public Payment()
        {
            InitializeComponent();
        }

        public string Purpose
        {
            get { return tbPurpose.Text; }
            set { tbPurpose.Text = value; }
        }

        public string Number
        {
            get { return tbNumber.Text; }
            set { tbNumber.Text = value; }
        }

        public string Amount
        {
            get { return tbAmount.Text; }
            set { tbAmount.Text = value; }
        }

        public string Category { get; set; }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            var cardId = Convert.ToInt32(this.CardId);
            var amount = Convert.ToDecimal(tbAmount.Text);
            var number = tbNumber.Text;
            var traget = tbPurpose.Text;
            var date = DateTime.Now;

            var transacrion = new Transaction
            {
                CardId = cardId,
                Amount = amount,
                Category = Category,
                Date = date,
                Number = number
            };

            MakeTransaction?.Invoke(this, transacrion);
        }

        public void UpdatePurposeTitle(string title)
        {
            tbPurpose.Text = title;
        }

        public void ClearTitles()
        {
            tbAmount.Clear();
            tbNumber.Clear();
        }

    }
}
