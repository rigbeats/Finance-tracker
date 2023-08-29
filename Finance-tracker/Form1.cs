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

namespace Finance_tracker
{
    public partial class Form1 : Form
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
        (PictureBox, Label, string) selectedButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectPath, "Icons\\selected_compass_icon.png");

            tabControl.SelectedTab = Overview;
            pbOverview.Image = Image.FromFile(imagePath);
            lOverview.ForeColor = Color.FromArgb(36, 94, 231);

            selectedButton.Item1 = pbOverview;
            selectedButton.Item2 = lOverview;
            selectedButton.Item3 = imagePath;
        }

        private void DeselectButton()
        {
            string imagePath = selectedButton.Item3;
            imagePath = imagePath.Replace("selected_", "");
            selectedButton.Item1.Image = Image.FromFile(imagePath);
            selectedButton.Item2.ForeColor = Color.FromArgb(74, 85, 103);
        }

        private void SelectButton(string path, PictureBox pictureBox, Label label, TabPage tabPage)
        {
            string imagePath = Path.Combine(projectPath, path);

            tabControl.SelectedTab = tabPage;
            pictureBox.Image = Image.FromFile(imagePath);
            label.ForeColor = Color.FromArgb(36, 94, 231);

            //сохранение нажатой кнопки
            selectedButton.Item1 = pictureBox;
            selectedButton.Item2 = label;
            selectedButton.Item3 = imagePath;
        }

        private void BOverview_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_compass_icon.png",
                pbOverview,
                lOverview,
                Overview
                );
        }

        private void BCard_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_credit_card_icon.png",
                pbCard,
                lCard,
                Card
                );
        }

        private void BBudget_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_dollar_sign_icon.png",
                pbBudget,
                lBudget,
                Budget
                );
        }

        private void BPayment_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_money_icon.png",
                pbPayment,
                lPayment,
                Payment
                );
        }

        private void BStatistics_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_statistics_icon.png",
                pbStatistics,
                lStatistics,
                Statistics
                );
        }

        private void BReport_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_save_icon.png",
                pbReport,
                lReport,
                Report
                );
        }

        private void BAccount_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_user_icon.png",
                pbAccount,
                lAccount,
                Account
                );
        }

        private void BLogout_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_user_minus_icon.png",
                pbLogout,
                lLogout,
                Logout
                );
        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            DeselectButton();

            SelectButton(
                "Icons\\selected_settings_icon.png",
                pbSettings,
                lSettings,
                Settings
                );
        }
    }
}
