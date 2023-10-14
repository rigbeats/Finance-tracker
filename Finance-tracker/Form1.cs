using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_tracker.Entity_classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Finance_tracker.Controls;
using System.Runtime.CompilerServices;

namespace Finance_tracker
{ 
    public partial class Form1 : Form
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        (PictureBox, Label, string) selectedButton;
        int userId;
        int? PreviousCardId { get; set; }

        public event EventHandler CardTabUpdate;

        public Form1(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            cardPage.UserId = userId;

            //////////////////////ЗАТЫЧКА ДЛЯ ПРОВЕРКИ
            paymentPage.CardId = 0; //PreviousCardId;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            SelectButton(
                "Icons\\selected_compass_icon.png",
                pbOverview,
                lOverview
                );

            //запрос к базе данных для ускорения последующих
            await Task.Run(async () =>
            {
                using (var context = new FinanceTrackerContext())
                {
                    await context.Cards.FirstOrDefaultAsync();
                }
            });
        }

        private void DeselectButton()
        {
            string imagePath = selectedButton.Item3;
            imagePath = imagePath.Replace("selected_", "");
            selectedButton.Item1.Image = System.Drawing.Image.FromFile(imagePath);
            selectedButton.Item2.ForeColor = Color.FromArgb(74, 85, 103);
        }

        private void SelectButton(string path, PictureBox pictureBox, Label label)
        {
            string imagePath = Path.Combine(projectPath, path);

            pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
            label.ForeColor = Color.FromArgb(36, 94, 231);

            selectedButton.Item1 = pictureBox;
            selectedButton.Item2 = label;
            selectedButton.Item3 = imagePath;
        }

        public void ClearAllPages()
        {
            reportPage.Visible = false;
            cardPage.Visible = false;
            paymentPage.Visible = false;
            budgetPage.Visible = false;
            statisticsPage.Visible = false;
        }

        private void BCard_Click(object sender, EventArgs e)
        {
            DeselectButton();
            ClearAllPages();

            SelectButton(
                "Icons\\selected_credit_card_icon.png",
                pbCard,
                lCard
                );

            cardPage.Visible = true;
            cardPage.UpdateTable();
        }

        private void BReport_Click(object sender, EventArgs e)
        {
            DeselectButton();
            ClearAllPages();

            SelectButton(
                "Icons\\selected_save_icon.png",
                pbReport,
                lReport
                );

            reportPage.Visible = true;
        }

        private void BPayment_Click(object sender, EventArgs e)
        {
            DeselectButton();
            ClearAllPages();

            SelectButton(
                "Icons\\selected_money_icon.png",
                pbPayment,
                lPayment
                );

            paymentPage.Visible = true;
        }

        private void BOverview_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_compass_icon.png",
                pbOverview,
                lOverview
                );
        }

        private void BBudget_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_dollar_sign_icon.png",
                pbBudget,
                lBudget
                );
            budgetPage.Visible = true;
            budgetPage.LoadData();
        }

        private void BStatistics_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_statistics_icon.png",
                pbStatistics,
                lStatistics
                );
            statisticsPage.Visible = true;
        }

        private void BAccount_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_user_icon.png",
                pbAccount,
                lAccount
                );
        }

        private void BLogout_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_user_minus_icon.png",
                pbLogout,
                lLogout
                );
        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_settings_icon.png",
                pbSettings,
                lSettings
                );
        }

        //////////////////////////////////////

        private void bTransfer_Click(object sender, EventArgs e)
        {
            //string cardNumber = tbTCardNumber.Text;
            //string[] name = tbCardHolder.Text.Split(' ');

            //bool correctData = CheckCorrectCardData(
            //   cardNumber,
            //    name.Length);

            //if (correctData)
            //{

            //}
        }

        private void MakeTransaction()
        {
            using (var context = new FinanceTrackerContext())
            {
                int? defaultCardId = context.Users
                    .Where(x => x.Id == userId)
                    .FirstOrDefault()
                    .DefaultCardId;

                if (defaultCardId == null)
                    MessageBox.Show("Please select the default card in Settings");

                else
                {
                    var transaction = new Transaction()
                    {
                        CardId = Convert.ToInt32(defaultCardId),
                    };
                }


            }
        }

        private void paymentPage_Load(object sender, EventArgs e)
        {

        }

        private void budgetPage_Load(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////
    }
}
