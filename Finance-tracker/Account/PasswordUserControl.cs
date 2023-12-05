using System;
using System.Windows.Forms;

namespace Finance_tracker.Account
{
    public partial class PasswordUserControl : UserControl
    {
        public string Password
        {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }
        public PasswordUserControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            passwordTextBox.Clear();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;

            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordButton.Image = Properties.Resources.closed_eye_icon;
            }
            else
            {
                passwordButton.Image = Properties.Resources.open_eye_icon;
            }
        }
    }
}
