namespace Finance_tracker.Account
{
    partial class PhoneNumberUserControl
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.countryCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(61, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(242, 31);
            this.textBox.TabIndex = 0;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // countryCodeLabel
            // 
            this.countryCodeLabel.AutoSize = true;
            this.countryCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryCodeLabel.Location = new System.Drawing.Point(-5, 8);
            this.countryCodeLabel.Name = "countryCodeLabel";
            this.countryCodeLabel.Size = new System.Drawing.Size(60, 25);
            this.countryCodeLabel.TabIndex = 1;
            this.countryCodeLabel.Text = "+996";
            // 
            // PhoneNumberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countryCodeLabel);
            this.Controls.Add(this.textBox);
            this.Name = "PhoneNumberUserControl";
            this.Size = new System.Drawing.Size(306, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label countryCodeLabel;
    }
}
