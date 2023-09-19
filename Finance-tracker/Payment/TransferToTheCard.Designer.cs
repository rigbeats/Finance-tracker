namespace Finance_tracker.Payment
{
    partial class TransferToTheCard
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTAmount = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.bTransfer = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.creditCard = new Finance_tracker.Controls.CreditCard();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.creditCard);
            this.groupBox5.Controls.Add(this.tbTAmount);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.bTransfer);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(1, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 366);
            this.groupBox5.TabIndex = 117;
            this.groupBox5.TabStop = false;
            // 
            // tbTAmount
            // 
            this.tbTAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTAmount.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTAmount.ForeColor = System.Drawing.Color.White;
            this.tbTAmount.Location = new System.Drawing.Point(30, 279);
            this.tbTAmount.Name = "tbTAmount";
            this.tbTAmount.Size = new System.Drawing.Size(277, 23);
            this.tbTAmount.TabIndex = 120;
            this.tbTAmount.Text = " 111";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label32.Location = new System.Drawing.Point(26, 246);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 23);
            this.label32.TabIndex = 119;
            this.label32.Text = "Amount";
            // 
            // bTransfer
            // 
            this.bTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.bTransfer.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTransfer.ForeColor = System.Drawing.Color.White;
            this.bTransfer.Location = new System.Drawing.Point(28, 314);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(280, 33);
            this.bTransfer.TabIndex = 118;
            this.bTransfer.Text = "transfer";
            this.bTransfer.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label16.Location = new System.Drawing.Point(26, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Transfer to the card";
            // 
            // creditCard
            // 
            this.creditCard.Location = new System.Drawing.Point(20, 58);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(291, 186);
            this.creditCard.TabIndex = 121;
            this.creditCard.TbHolderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.creditCard.TbNumberBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.creditCard.TbValidThruBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            // 
            // TransferToTheCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Name = "TransferToTheCard";
            this.Size = new System.Drawing.Size(338, 368);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbTAmount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button bTransfer;
        private System.Windows.Forms.Label label16;
        private Controls.CreditCard creditCard;
    }
}
