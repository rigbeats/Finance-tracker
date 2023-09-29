namespace Finance_tracker.Payment
{
    partial class Payment
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bTransfer = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.lPurpose = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.panel6);
            this.groupBox6.Controls.Add(this.bTransfer);
            this.groupBox6.Controls.Add(this.tbAmount);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.tbPurpose);
            this.groupBox6.Controls.Add(this.lPurpose);
            this.groupBox6.Controls.Add(this.tbNumber);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Location = new System.Drawing.Point(1, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(639, 368);
            this.groupBox6.TabIndex = 120;
            this.groupBox6.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.panel6.Location = new System.Drawing.Point(30, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 1);
            this.panel6.TabIndex = 125;
            // 
            // bTransfer
            // 
            this.bTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.bTransfer.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTransfer.ForeColor = System.Drawing.Color.White;
            this.bTransfer.Location = new System.Drawing.Point(180, 314);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(280, 33);
            this.bTransfer.TabIndex = 122;
            this.bTransfer.Text = "transfer";
            this.bTransfer.UseVisualStyleBackColor = false;
            this.bTransfer.Click += new System.EventHandler(this.bTransfer_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.White;
            this.tbAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAmount.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbAmount.Location = new System.Drawing.Point(30, 246);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(121, 23);
            this.tbAmount.TabIndex = 120;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Helvetica", 14F);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label30.Location = new System.Drawing.Point(26, 215);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 22);
            this.label30.TabIndex = 119;
            this.label30.Text = "Amount";
            // 
            // tbPurpose
            // 
            this.tbPurpose.BackColor = System.Drawing.Color.White;
            this.tbPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPurpose.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPurpose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbPurpose.Location = new System.Drawing.Point(30, 171);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.ReadOnly = true;
            this.tbPurpose.Size = new System.Drawing.Size(152, 23);
            this.tbPurpose.TabIndex = 118;
            // 
            // lPurpose
            // 
            this.lPurpose.AutoSize = true;
            this.lPurpose.Font = new System.Drawing.Font("Helvetica", 14F);
            this.lPurpose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.lPurpose.Location = new System.Drawing.Point(26, 140);
            this.lPurpose.Name = "lPurpose";
            this.lPurpose.Size = new System.Drawing.Size(82, 22);
            this.lPurpose.TabIndex = 117;
            this.lPurpose.Text = "Purpose";
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.White;
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumber.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.tbNumber.Location = new System.Drawing.Point(30, 96);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(121, 23);
            this.tbNumber.TabIndex = 116;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Helvetica", 14F);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label28.Location = new System.Drawing.Point(26, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 22);
            this.label28.TabIndex = 106;
            this.label28.Text = "Number";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label27.Location = new System.Drawing.Point(26, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 23);
            this.label27.TabIndex = 3;
            this.label27.Text = "Payments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(30, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 1);
            this.panel1.TabIndex = 126;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(641, 370);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.Label lPurpose;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button bTransfer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Panel panel1;
    }
}
