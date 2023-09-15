using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
