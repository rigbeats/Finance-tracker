using Finance_tracker.Entity_classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Finance_tracker.Controls
{
    public partial class TransactionTable : UserControl
    {
        public TransactionTable()
        {
            InitializeComponent();
        }

        public void ClearTable()
        {
            lastTransactionsTable.Items.Clear();
        }

        public void FillTable(List<Transaction> transactions)
        {
            ClearTable();

            ListViewItem listViewItem;

            for (int i = 0; i < transactions.Count; i++)
            {
                var date = transactions[i].Date;

                listViewItem = new ListViewItem(new string[]
                {
                            Convert.ToString(i + 1),
                            Convert.ToString(transactions[i].Amount),
                            transactions[i].Category,
                            $"{date.Day}/{date.Month}/{date.Year}"
                });

                lastTransactionsTable.Items.Add(listViewItem);
            }
        }
    }
}
