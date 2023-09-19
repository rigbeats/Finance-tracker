namespace Finance_tracker.Controls
{
    partial class SaveFile
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bSaveReport = new System.Windows.Forms.Button();
            this.bLastYear = new System.Windows.Forms.Button();
            this.bLastMonth = new System.Windows.Forms.Button();
            this.bLastWeek = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.bSaveReport);
            this.groupBox4.Controls.Add(this.bLastYear);
            this.groupBox4.Controls.Add(this.bLastMonth);
            this.groupBox4.Controls.Add(this.bLastWeek);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(1, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 446);
            this.groupBox4.TabIndex = 114;
            this.groupBox4.TabStop = false;
            // 
            // bSaveReport
            // 
            this.bSaveReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.bSaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveReport.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSaveReport.ForeColor = System.Drawing.Color.White;
            this.bSaveReport.Location = new System.Drawing.Point(456, 369);
            this.bSaveReport.Name = "bSaveReport";
            this.bSaveReport.Size = new System.Drawing.Size(168, 46);
            this.bSaveReport.TabIndex = 7;
            this.bSaveReport.Text = "save";
            this.bSaveReport.UseVisualStyleBackColor = false;
            this.bSaveReport.Click += new System.EventHandler(this.bSaveReport_Click);
            // 
            // bLastYear
            // 
            this.bLastYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.bLastYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLastYear.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLastYear.ForeColor = System.Drawing.Color.White;
            this.bLastYear.Location = new System.Drawing.Point(413, 80);
            this.bLastYear.Name = "bLastYear";
            this.bLastYear.Size = new System.Drawing.Size(168, 46);
            this.bLastYear.TabIndex = 6;
            this.bLastYear.Text = "last year";
            this.bLastYear.UseVisualStyleBackColor = false;
            this.bLastYear.Click += new System.EventHandler(this.bLastYear_Click);
            // 
            // bLastMonth
            // 
            this.bLastMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.bLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLastMonth.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLastMonth.ForeColor = System.Drawing.Color.White;
            this.bLastMonth.Location = new System.Drawing.Point(246, 80);
            this.bLastMonth.Name = "bLastMonth";
            this.bLastMonth.Size = new System.Drawing.Size(168, 46);
            this.bLastMonth.TabIndex = 5;
            this.bLastMonth.Text = "last month";
            this.bLastMonth.UseVisualStyleBackColor = false;
            this.bLastMonth.Click += new System.EventHandler(this.bLastMonth_Click);
            // 
            // bLastWeek
            // 
            this.bLastWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(103)))));
            this.bLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLastWeek.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLastWeek.ForeColor = System.Drawing.Color.White;
            this.bLastWeek.Location = new System.Drawing.Point(79, 80);
            this.bLastWeek.Name = "bLastWeek";
            this.bLastWeek.Size = new System.Drawing.Size(168, 46);
            this.bLastWeek.TabIndex = 4;
            this.bLastWeek.Text = "last week";
            this.bLastWeek.UseVisualStyleBackColor = false;
            this.bLastWeek.Click += new System.EventHandler(this.bLastWeek_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label17.Location = new System.Drawing.Point(32, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 23);
            this.label17.TabIndex = 3;
            this.label17.Text = "Account statement";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"PDF file (*.pdf)|*.pdf|Все файлы (*.*)|*.*\"";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // SaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "SaveFile";
            this.Size = new System.Drawing.Size(658, 448);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bSaveReport;
        private System.Windows.Forms.Button bLastYear;
        private System.Windows.Forms.Button bLastMonth;
        private System.Windows.Forms.Button bLastWeek;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
