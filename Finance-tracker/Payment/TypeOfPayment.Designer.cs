namespace Finance_tracker.Payment
{
    partial class TypeOfPayment
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.title = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Controls.Add(this.image);
            this.groupBox11.Controls.Add(this.title);
            this.groupBox11.Location = new System.Drawing.Point(1, 1);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(95, 95);
            this.groupBox11.TabIndex = 123;
            this.groupBox11.TabStop = false;
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Helvetica Bold", 12F);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.title.Location = new System.Drawing.Point(1, 67);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(93, 20);
            this.title.TabIndex = 121;
            this.title.Text = "title";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(25, 18);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(45, 45);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 119;
            this.image.TabStop = false;
            // 
            // TypeOfPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox11);
            this.Name = "TypeOfPayment";
            this.Size = new System.Drawing.Size(97, 97);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox title;
    }
}
