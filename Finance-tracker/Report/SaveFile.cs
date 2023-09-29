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
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Finance_tracker.Controls
{
    public partial class SaveFile : UserControl
    {
        public SaveFile()
        {
            InitializeComponent();
        }

        string selectedPeriod = "week";

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
    }
}
