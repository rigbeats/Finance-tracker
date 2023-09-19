namespace Finance_tracker.Controls
{
    partial class CreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCard));
            this.tbValidThru = new System.Windows.Forms.TextBox();
            this.tbCardHolder = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lCardTitle3 = new System.Windows.Forms.Label();
            this.lCardTitle2 = new System.Windows.Forms.Label();
            this.lCardTitle1 = new System.Windows.Forms.Label();
            this.pbLargeCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLargeCard)).BeginInit();
            this.SuspendLayout();
            // 
            // tbValidThru
            // 
            this.tbValidThru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbValidThru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValidThru.Font = new System.Drawing.Font("Helvetica", 11.25F);
            this.tbValidThru.ForeColor = System.Drawing.Color.White;
            this.tbValidThru.Location = new System.Drawing.Point(174, 131);
            this.tbValidThru.Name = "tbValidThru";
            this.tbValidThru.ReadOnly = true;
            this.tbValidThru.Size = new System.Drawing.Size(87, 18);
            this.tbValidThru.TabIndex = 117;
            // 
            // tbCardHolder
            // 
            this.tbCardHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCardHolder.Font = new System.Drawing.Font("Helvetica", 11.25F);
            this.tbCardHolder.ForeColor = System.Drawing.Color.White;
            this.tbCardHolder.Location = new System.Drawing.Point(36, 130);
            this.tbCardHolder.Name = "tbCardHolder";
            this.tbCardHolder.ReadOnly = true;
            this.tbCardHolder.Size = new System.Drawing.Size(103, 18);
            this.tbCardHolder.TabIndex = 116;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCardNumber.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCardNumber.ForeColor = System.Drawing.Color.White;
            this.tbCardNumber.Location = new System.Drawing.Point(28, 61);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.ReadOnly = true;
            this.tbCardNumber.Size = new System.Drawing.Size(229, 23);
            this.tbCardNumber.TabIndex = 115;
            // 
            // lCardTitle3
            // 
            this.lCardTitle3.AutoSize = true;
            this.lCardTitle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.lCardTitle3.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCardTitle3.ForeColor = System.Drawing.Color.White;
            this.lCardTitle3.Location = new System.Drawing.Point(171, 112);
            this.lCardTitle3.Name = "lCardTitle3";
            this.lCardTitle3.Size = new System.Drawing.Size(81, 16);
            this.lCardTitle3.TabIndex = 109;
            this.lCardTitle3.Text = "VALID THRU";
            // 
            // lCardTitle2
            // 
            this.lCardTitle2.AutoSize = true;
            this.lCardTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.lCardTitle2.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCardTitle2.ForeColor = System.Drawing.Color.White;
            this.lCardTitle2.Location = new System.Drawing.Point(33, 112);
            this.lCardTitle2.Name = "lCardTitle2";
            this.lCardTitle2.Size = new System.Drawing.Size(100, 16);
            this.lCardTitle2.TabIndex = 107;
            this.lCardTitle2.Text = "CARD HOLDER";
            // 
            // lCardTitle1
            // 
            this.lCardTitle1.AutoSize = true;
            this.lCardTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.lCardTitle1.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCardTitle1.ForeColor = System.Drawing.Color.White;
            this.lCardTitle1.Location = new System.Drawing.Point(33, 22);
            this.lCardTitle1.Name = "lCardTitle1";
            this.lCardTitle1.Size = new System.Drawing.Size(92, 17);
            this.lCardTitle1.TabIndex = 106;
            this.lCardTitle1.Text = "Primary card";
            // 
            // pbLargeCard
            // 
            this.pbLargeCard.Image = ((System.Drawing.Image)(resources.GetObject("pbLargeCard.Image")));
            this.pbLargeCard.Location = new System.Drawing.Point(0, 0);
            this.pbLargeCard.Name = "pbLargeCard";
            this.pbLargeCard.Size = new System.Drawing.Size(291, 186);
            this.pbLargeCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLargeCard.TabIndex = 1;
            this.pbLargeCard.TabStop = false;
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCardHolder);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.tbValidThru);
            this.Controls.Add(this.lCardTitle3);
            this.Controls.Add(this.lCardTitle1);
            this.Controls.Add(this.lCardTitle2);
            this.Controls.Add(this.pbLargeCard);
            this.Name = "CreditCard";
            this.Size = new System.Drawing.Size(291, 186);
            ((System.ComponentModel.ISupportInitialize)(this.pbLargeCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbValidThru;
        private System.Windows.Forms.TextBox tbCardHolder;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label lCardTitle3;
        private System.Windows.Forms.Label lCardTitle2;
        private System.Windows.Forms.Label lCardTitle1;
        private System.Windows.Forms.PictureBox pbLargeCard;
    }
}
