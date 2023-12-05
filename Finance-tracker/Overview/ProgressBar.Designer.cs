namespace Finance_tracker
{
    partial class GoalProgressBar
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCurrentGoalName = new System.Windows.Forms.Label();
            this.tbGoalName = new System.Windows.Forms.TextBox();
            this.tbGoalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCurrentProgress = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar.Location = new System.Drawing.Point(3, 108);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 20);
            this.progressBar.TabIndex = 0;
            // 
            // lblCurrentGoalName
            // 
            this.lblCurrentGoalName.AutoSize = true;
            this.lblCurrentGoalName.Location = new System.Drawing.Point(3, 9);
            this.lblCurrentGoalName.Name = "lblCurrentGoalName";
            this.lblCurrentGoalName.Size = new System.Drawing.Size(113, 13);
            this.lblCurrentGoalName.TabIndex = 1;
            this.lblCurrentGoalName.Text = "Pick your current goal:\r\n";
            // 
            // tbGoalName
            // 
            this.tbGoalName.Location = new System.Drawing.Point(122, 6);
            this.tbGoalName.Name = "tbGoalName";
            this.tbGoalName.Size = new System.Drawing.Size(181, 20);
            this.tbGoalName.TabIndex = 2;
            // 
            // tbGoalAmount
            // 
            this.tbGoalAmount.Location = new System.Drawing.Point(122, 32);
            this.tbGoalAmount.Name = "tbGoalAmount";
            this.tbGoalAmount.Size = new System.Drawing.Size(181, 20);
            this.tbGoalAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Goal amount($):";
            // 
            // tbCurrentAmount
            // 
            this.tbCurrentAmount.Location = new System.Drawing.Point(122, 58);
            this.tbCurrentAmount.Name = "tbCurrentAmount";
            this.tbCurrentAmount.Size = new System.Drawing.Size(181, 20);
            this.tbCurrentAmount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current amount($):";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(3, 149);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(181, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please enter the amount you would like to save";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Location = new System.Drawing.Point(41, 92);
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(87, 13);
            this.lblCurrentProgress.TabIndex = 10;
            this.lblCurrentProgress.Text = "Current progress:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(134, 92);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 11;
            // 
            // GoalProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblCurrentProgress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.tbCurrentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGoalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGoalName);
            this.Controls.Add(this.lblCurrentGoalName);
            this.Controls.Add(this.progressBar);
            this.Name = "GoalProgressBar";
            this.Size = new System.Drawing.Size(312, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCurrentGoalName;
        private System.Windows.Forms.TextBox tbGoalName;
        private System.Windows.Forms.TextBox tbGoalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCurrentProgress;
        private System.Windows.Forms.Label lblProgress;
    }
}
