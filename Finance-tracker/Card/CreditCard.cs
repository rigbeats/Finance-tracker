using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Finance_tracker.Controls
{
    public partial class CreditCard : UserControl
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));

        public string CardNumber
        { get { return tbCardNumber.Text; } }

        public string CardHolder
        { get { return tbCardHolder.Text; } }

        public string ValidThru
        { get { return tbValidThru.Text; } }

        public Color TbNumberBackColor
        {
            set { tbCardNumber.BackColor = value; }
            get { return tbCardNumber.BackColor; }
        }

        public Color TbHolderBackColor
        {
            set { tbCardHolder.BackColor = value; }
            get { return tbCardHolder.BackColor; }
        }

        public Color TbValidThruBackColor
        {
            set { tbValidThru.BackColor = value; }
            get { return tbValidThru.BackColor; }
        }

        public bool TbNumberReadOnly
        { set { tbCardNumber.ReadOnly = value; } }

        public bool TbHolderReadOnly
        { set { tbCardHolder.ReadOnly = value; } }

        public bool TbValidThruReadOnly
        { set { tbValidThru.ReadOnly = value; } }

        public CreditCard()
        {
            InitializeComponent();
        }

        public void FillFields(string number, string fullName, string validThru)
        {
            var cardNumber = string.Concat("**** **** **** ", number.Substring(12));
            tbCardNumber.Text = cardNumber;
            tbCardHolder.Text = fullName;
            tbValidThru.Text = validThru;
        }

        public void ColorCardBlue()
        {
            string ImagePath = Path.Combine(projectPath, "Images\\blue_card.png");
            pbLargeCard.Image = System.Drawing.Image.FromFile(ImagePath);

            lCardTitle1.BackColor = Color.FromArgb(36, 95, 232);
            lCardTitle3.BackColor = Color.FromArgb(36, 95, 232);
            lCardTitle2.BackColor = Color.FromArgb(36, 95, 232);
            tbCardHolder.BackColor = Color.FromArgb(36, 95, 232);
            tbValidThru.BackColor = Color.FromArgb(36, 95, 232);
            tbCardNumber.BackColor = Color.FromArgb(36, 95, 232);

            tbCardNumber.Clear();
            tbValidThru.Clear();
            tbCardHolder.Clear();
        }

        public void ColorCardGray()
        {
            string ImagePath = Path.Combine(projectPath, "Images\\gray_card.png");
            pbLargeCard.Image = System.Drawing.Image.FromFile(ImagePath);

            lCardTitle1.BackColor = Color.FromArgb(166, 174, 183);
            lCardTitle3.BackColor = Color.FromArgb(166, 174, 183);
            lCardTitle2.BackColor = Color.FromArgb(166, 174, 183);
            tbCardHolder.BackColor = Color.FromArgb(166, 174, 183);
            tbValidThru.BackColor = Color.FromArgb(166, 174, 183);
            tbCardNumber.BackColor = Color.FromArgb(166, 174, 183);

            tbCardNumber.Clear();
            tbValidThru.Clear();
            tbCardHolder.Clear();
        }

        public bool CheckCorrectCardData()
        {
            string cardNumber = tbCardNumber.Text;
            var cardHolder = tbCardHolder.Text;
            string validThru = tbValidThru.Text;
            int numberOfWordsInName = cardHolder.Split(' ').Length;

            bool eror = false;
            string erorText = string.Empty;

            if (cardNumber.Length != 16)
            {
                erorText = "Invalid card number";
                eror = true;
            }

            else if (numberOfWordsInName != 2)
            {
                erorText = "Invalid card holder";
                eror = true;
            }

            //Cлева месяц, справа год
            //Пропустит 12/22
            //Не пропустит 14/22
            else if (!Regex.IsMatch(validThru, @"^(0[1-9]|1[0-2])\/[0-9]{2}$"))
            {
                erorText = "Invalid valid thru";
                eror = true;
            }

            if (eror)
            {
                MessageBox.Show(erorText);
                return false;
            }

            return true;
        }

        public void ClearCard()
        {
            tbCardNumber.Clear();
            tbValidThru.Clear();
            tbCardHolder.Clear();
        }
    }
}
