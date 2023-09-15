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


namespace Finance_tracker.Controls
{
    public partial class CardBar : UserControl
    {
        string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));

        public CardBar()
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

        public string CardNumber
        { get { return tbCardNumber.Text; } }

        public string CardHolder
        { get { return tbCardHolder.Text; } }

        public string ValidThru
        { get { return tbValidThru.Text; } }

        public Color TbNumberBackColor
        { set { tbCardNumber.BackColor = value; } }

        public Color TbHolderBackColor
        { set { tbCardHolder.BackColor = value; } }

        public Color TbValidThruBackColor
        { set { tbValidThru.BackColor = value; } }

        public bool TbNumberReadOnly
        { set { tbCardNumber.ReadOnly = value; } }

        public bool TbHolderReadOnly
        { set { tbCardHolder.ReadOnly = value; } }

        public bool TbValidThruReadOnly
        { set { tbValidThru.ReadOnly = value; } }

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
    }
}
