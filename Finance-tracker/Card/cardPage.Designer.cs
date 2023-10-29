namespace Finance_tracker.Controls
{
    partial class cardPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionTable = new Finance_tracker.Controls.TransactionTable();
            this.cardBalance = new Finance_tracker.Controls.CardBalance();
            this.selectCard = new Finance_tracker.Controls.SelectCard();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 18);
            this.label3.TabIndex = 123;
            this.label3.Text = "Here your credit card and transactions on them";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 122;
            this.label2.Text = "Card";
            // 
            // transactionTable
            // 
            this.transactionTable.Location = new System.Drawing.Point(15, 78);
            this.transactionTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactionTable.Name = "transactionTable";
            this.transactionTable.Size = new System.Drawing.Size(656, 511);
            this.transactionTable.TabIndex = 121;
            // 
            // cardBalance
            // 
            this.cardBalance.BackColor = System.Drawing.Color.White;
            this.cardBalance.Balance = "0";
            this.cardBalance.Location = new System.Drawing.Point(694, 370);
            this.cardBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.Size = new System.Drawing.Size(340, 111);
            this.cardBalance.TabIndex = 125;
            // 
            // selectCard
            // 
            this.selectCard.CardBalance = null;
            this.selectCard.IndexSelectedCard = 0;
            this.selectCard.Location = new System.Drawing.Point(694, 78);
            this.selectCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectCard.Name = "selectCard";
            this.selectCard.Size = new System.Drawing.Size(340, 274);
            this.selectCard.TabIndex = 126;
            this.selectCard.UserId = 0;
            this.selectCard.Load += new System.EventHandler(this.selectCard_Load);
            // 
            // cardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.selectCard);
            this.Controls.Add(this.transactionTable);
            this.Controls.Add(this.cardBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "cardPage";
            this.Size = new System.Drawing.Size(1053, 681);
            this.Load += new System.EventHandler(this.cardPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransactionTable transactionTable;
        private CardBalance cardBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private SelectCard selectCard;
    }
}
