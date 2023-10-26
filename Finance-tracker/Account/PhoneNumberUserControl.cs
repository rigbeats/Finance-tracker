using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_tracker.Account
{
    public partial class PhoneNumberUserControl : UserControl
    {
        public string CountryCode
        {
            get => countryCodeLabel.Text;
            set => countryCodeLabel.Text = value;
        }
        public PhoneNumberUserControl()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
