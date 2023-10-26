using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finance_tracker.Account
{
    public partial class accountPage : UserControl
    {
        public accountPage()
        {
            InitializeComponent();
        }

        private void accountPage_Load(object sender, EventArgs e)
        {

        }

        #region textbox events
        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "First name")
            {
                textBoxFirstName.Text = string.Empty;
            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Last name")
            {
                textBoxLastName.Text = string.Empty;
            }
        }

        private void textBoxEmailAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxEmailAddress.Text == "Email address")
            {
                textBoxEmailAddress.Text = string.Empty;
            }
        }

        private void textBoxCity_Enter(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "City")
            {
                textBoxCity.Text = string.Empty;
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Address")
            {
                textBoxAddress.Text = string.Empty;
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                textBoxFirstName.Text = "First name";
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                textBoxLastName.Text = "Last name";
            }
        }

        private void textBoxEmailAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmailAddress.Text))
            {
                textBoxEmailAddress.Text = "Email address";
            }
        }

        private void textBoxCity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCity.Text))
            {
                textBoxCity.Text = "City";
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                textBoxAddress.Text = "Address";
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
