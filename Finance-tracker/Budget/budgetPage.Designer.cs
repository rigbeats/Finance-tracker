namespace Finance_tracker.Budget
{
    partial class budgetPage
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
            this.rtbIncome = new System.Windows.Forms.RichTextBox();
            this.rtbNeeds = new System.Windows.Forms.RichTextBox();
            this.rtbWants = new System.Windows.Forms.RichTextBox();
            this.rtbTotalExpenses = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbIncome
            // 
            this.rtbIncome.Location = new System.Drawing.Point(88, 67);
            this.rtbIncome.Name = "rtbIncome";
            this.rtbIncome.Size = new System.Drawing.Size(250, 25);
            this.rtbIncome.TabIndex = 0;
            this.rtbIncome.Text = "";
            // 
            // rtbNeeds
            // 
            this.rtbNeeds.Location = new System.Drawing.Point(88, 152);
            this.rtbNeeds.Name = "rtbNeeds";
            this.rtbNeeds.Size = new System.Drawing.Size(250, 25);
            this.rtbNeeds.TabIndex = 1;
            this.rtbNeeds.Text = "";
            // 
            // rtbWants
            // 
            this.rtbWants.Location = new System.Drawing.Point(88, 230);
            this.rtbWants.Name = "rtbWants";
            this.rtbWants.Size = new System.Drawing.Size(250, 25);
            this.rtbWants.TabIndex = 2;
            this.rtbWants.Text = "";
            // 
            // rtbTotalExpenses
            // 
            this.rtbTotalExpenses.Location = new System.Drawing.Point(88, 313);
            this.rtbTotalExpenses.Name = "rtbTotalExpenses";
            this.rtbTotalExpenses.Size = new System.Drawing.Size(250, 25);
            this.rtbTotalExpenses.TabIndex = 3;
            this.rtbTotalExpenses.Text = "";
            this.rtbTotalExpenses.TextChanged += new System.EventHandler(this.rtbTotalExpenses_TextChanged);
            // 
            // budgetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbTotalExpenses);
            this.Controls.Add(this.rtbWants);
            this.Controls.Add(this.rtbNeeds);
            this.Controls.Add(this.rtbIncome);
            this.Name = "budgetPage";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.budgetPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbIncome;
        private System.Windows.Forms.RichTextBox rtbNeeds;
        private System.Windows.Forms.RichTextBox rtbWants;
        private System.Windows.Forms.RichTextBox rtbTotalExpenses;
    }
}
