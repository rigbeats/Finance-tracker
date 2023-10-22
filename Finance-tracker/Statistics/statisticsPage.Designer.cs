namespace Finance_tracker.Statistics
{
    partial class statisticsPage
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
            this.radioButtonNeeds = new System.Windows.Forms.RadioButton();
            this.radioButtonWants = new System.Windows.Forms.RadioButton();
            this.radioButtonDebts = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.statisticsPieChart = new Finance_tracker.Statistics.StatisticsPieChart();
            this.statisticsBarChart = new Finance_tracker.Statistics.StatisticsBarChart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonNeeds
            // 
            this.radioButtonNeeds.AutoSize = true;
            this.radioButtonNeeds.Location = new System.Drawing.Point(315, 153);
            this.radioButtonNeeds.Name = "radioButtonNeeds";
            this.radioButtonNeeds.Size = new System.Drawing.Size(56, 17);
            this.radioButtonNeeds.TabIndex = 4;
            this.radioButtonNeeds.TabStop = true;
            this.radioButtonNeeds.Text = "Needs";
            this.radioButtonNeeds.UseVisualStyleBackColor = true;
            this.radioButtonNeeds.CheckedChanged += new System.EventHandler(this.radioButtonNeeds_CheckedChanged);
            // 
            // radioButtonWants
            // 
            this.radioButtonWants.AutoSize = true;
            this.radioButtonWants.Location = new System.Drawing.Point(315, 199);
            this.radioButtonWants.Name = "radioButtonWants";
            this.radioButtonWants.Size = new System.Drawing.Size(56, 17);
            this.radioButtonWants.TabIndex = 5;
            this.radioButtonWants.TabStop = true;
            this.radioButtonWants.Text = "Wants";
            this.radioButtonWants.UseVisualStyleBackColor = true;
            this.radioButtonWants.CheckedChanged += new System.EventHandler(this.radioButtonWants_CheckedChanged);
            // 
            // radioButtonDebts
            // 
            this.radioButtonDebts.AutoSize = true;
            this.radioButtonDebts.Location = new System.Drawing.Point(315, 243);
            this.radioButtonDebts.Name = "radioButtonDebts";
            this.radioButtonDebts.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDebts.TabIndex = 6;
            this.radioButtonDebts.TabStop = true;
            this.radioButtonDebts.Text = "Savings/debts";
            this.radioButtonDebts.UseVisualStyleBackColor = true;
            this.radioButtonDebts.CheckedChanged += new System.EventHandler(this.radioButtonDebts_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 982);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "MMMM dd, yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(26, 183);
            this.dateTimePickerFrom.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 10;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please choose the time period and the category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "MMMM dd, yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(26, 229);
            this.dateTimePickerTo.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 14;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // statisticsPieChart
            // 
            this.statisticsPieChart.Location = new System.Drawing.Point(524, 76);
            this.statisticsPieChart.Name = "statisticsPieChart";
            this.statisticsPieChart.Size = new System.Drawing.Size(450, 300);
            this.statisticsPieChart.TabIndex = 16;
            // 
            // statisticsBarChart
            // 
            this.statisticsBarChart.Location = new System.Drawing.Point(26, 382);
            this.statisticsBarChart.Name = "statisticsBarChart";
            this.statisticsBarChart.Size = new System.Drawing.Size(951, 600);
            this.statisticsBarChart.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Statistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label6.Location = new System.Drawing.Point(23, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 18);
            this.label6.TabIndex = 124;
            this.label6.Text = "Here you can view the statistics for a certain time interval";
            // 
            // statisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statisticsBarChart);
            this.Controls.Add(this.statisticsPieChart);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonDebts);
            this.Controls.Add(this.radioButtonWants);
            this.Controls.Add(this.radioButtonNeeds);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "statisticsPage";
            this.Size = new System.Drawing.Size(1053, 681);
            this.Load += new System.EventHandler(this.statisticsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonNeeds;
        private System.Windows.Forms.RadioButton radioButtonWants;
        private System.Windows.Forms.RadioButton radioButtonDebts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private StatisticsPieChart statisticsPieChart;
        private StatisticsBarChart statisticsBarChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
