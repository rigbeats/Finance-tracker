using Finance_tracker.Entity_classes;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Finance_tracker.Account
{
    public partial class accountPage : UserControl
    {
        public int accountId { get; set; }
        public accountPage()
        {
            InitializeComponent();
            User currentUser = new User();
        }

        private void accountPage_Load(object sender, EventArgs e)
        {

        }
        //TODO: связать выбранную страну с меткой номера телефона
        //TODO: поменять иконки на кнопке пароля
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
            string newFirstName = textBoxFirstName.Text;

            using (var context = new FinanceTrackerContext())
            {
                UserData userData = context.UserData.SingleOrDefault();
                if (userData != null)
                {
                    userData.FirstName = newFirstName;
                    context.SaveChanges();
                }
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

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new FinanceTrackerContext())
            {
                var user = context.Users.Include(u => u.UserData).FirstOrDefault(u => u.Id == accountId);

                if (user != null)
                {
                    user.UserData.FirstName = textBoxFirstName.Text;
                    user.UserData.LastName = textBoxLastName.Text;
                    user.UserData.Country = countryComboBox.SelectedCountry.ToString();
                    user.UserData.PhoneNumber = phoneNumberUserControl.Text;

                    // No need to modify the UserDataId (identity column)
                    context.Entry(user.UserData).State = EntityState.Modified;

                    // Save changes
                    context.SaveChangesAsync();
                }
            }
        }

    }
}
