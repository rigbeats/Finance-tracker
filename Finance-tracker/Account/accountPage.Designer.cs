namespace Finance_tracker.Account
{
    partial class accountPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.phoneNumberUserControl = new Finance_tracker.Account.PhoneNumberUserControl();
            this.countryComboBox = new Finance_tracker.Account.CountryComboBox();
            this.passwordUserControl1 = new Finance_tracker.Account.PasswordUserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label3.Location = new System.Drawing.Point(22, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 18);
            this.label3.TabIndex = 124;
            this.label3.Text = "Here you can access your account information";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(25, 79);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(300, 29);
            this.textBoxFirstName.TabIndex = 136;
            this.textBoxFirstName.Text = "First name";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(389, 79);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(300, 29);
            this.textBoxLastName.TabIndex = 137;
            this.textBoxLastName.Text = "Last name";
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmailAddress.Location = new System.Drawing.Point(25, 169);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(300, 29);
            this.textBoxEmailAddress.TabIndex = 138;
            this.textBoxEmailAddress.Text = "Email address";
            this.textBoxEmailAddress.Enter += new System.EventHandler(this.textBoxEmailAddress_Enter);
            this.textBoxEmailAddress.Leave += new System.EventHandler(this.textBoxEmailAddress_Leave);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(389, 251);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(300, 29);
            this.textBoxCity.TabIndex = 139;
            this.textBoxCity.Text = "City";
            this.textBoxCity.Enter += new System.EventHandler(this.textBoxCity_Enter);
            this.textBoxCity.Leave += new System.EventHandler(this.textBoxCity_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(25, 319);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(300, 29);
            this.textBoxAddress.TabIndex = 140;
            this.textBoxAddress.Text = "Address";
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // phoneNumberUserControl
            // 
            this.phoneNumberUserControl.CountryCode = "+996";
            this.phoneNumberUserControl.Location = new System.Drawing.Point(389, 310);
            this.phoneNumberUserControl.Name = "phoneNumberUserControl";
            this.phoneNumberUserControl.Size = new System.Drawing.Size(306, 38);
            this.phoneNumberUserControl.TabIndex = 135;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Location = new System.Drawing.Point(25, 242);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(306, 38);
            this.countryComboBox.TabIndex = 134;
            // 
            // passwordUserControl1
            // 
            this.passwordUserControl1.Location = new System.Drawing.Point(389, 160);
            this.passwordUserControl1.Name = "passwordUserControl1";
            this.passwordUserControl1.Password = "";
            this.passwordUserControl1.Size = new System.Drawing.Size(306, 38);
            this.passwordUserControl1.TabIndex = 141;
            // 
            // accountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordUserControl1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.phoneNumberUserControl);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "accountPage";
            this.Size = new System.Drawing.Size(1053, 681);
            this.Load += new System.EventHandler(this.accountPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CountryComboBox countryComboBox;
        private PhoneNumberUserControl phoneNumberUserControl;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private PasswordUserControl passwordUserControl1;
    }
}
