using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_tracker.Controls
{
    public partial class CardBalance : UserControl
    {
        public CardBalance()
        {
            InitializeComponent();
        }

        public Color TbBackColor
        { set { tbBalance.BackColor = value; } }

        public string Balance
        {
            get { return tbBalance.Text; }
            set { tbBalance.Text = value; }
        }

        public bool TbReadOnly
        { set { tbBalance.ReadOnly = value; } }

        public void ClearBalance()
        {
            tbBalance.Clear();
        }

        public bool CheckCorrectBalance()
        {
            var balance = tbBalance.Text;

            if (!Regex.IsMatch(balance, "^[0-9]+(,[0-9]+)?$"))
            {
                if (balance == "")
                    tbBalance.Text = "0";
                else
                {
                    MessageBox.Show("Invalid balance");
                    return false;
                }
            }

            return true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
