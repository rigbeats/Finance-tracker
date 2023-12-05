namespace Finance_tracker.Overview
{
    partial class overviewPage
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
            this.columnChart1 = new Finance_tracker.Overview.ColumnChart();
            this.label2 = new System.Windows.Forms.Label();
            this.goalProgressBar1 = new Finance_tracker.GoalProgressBar();
            this.SuspendLayout();
            // 
            // columnChart1
            // 
            this.columnChart1.Location = new System.Drawing.Point(24, 84);
            this.columnChart1.Name = "columnChart1";
            this.columnChart1.Size = new System.Drawing.Size(556, 321);
            this.columnChart1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 123;
            this.label2.Text = "Overview";
            // 
            // goalProgressBar1
            // 
            this.goalProgressBar1.CurrentAmount = 0;
            this.goalProgressBar1.GoalAmount = 0;
            this.goalProgressBar1.Location = new System.Drawing.Point(24, 426);
            this.goalProgressBar1.Name = "goalProgressBar1";
            this.goalProgressBar1.Size = new System.Drawing.Size(312, 185);
            this.goalProgressBar1.TabIndex = 124;
            // 
            // overviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goalProgressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columnChart1);
            this.Name = "overviewPage";
            this.Size = new System.Drawing.Size(1053, 681);
            this.Load += new System.EventHandler(this.overviewPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnChart columnChart1;
        private System.Windows.Forms.Label label2;
        private GoalProgressBar goalProgressBar1;
    }
}
