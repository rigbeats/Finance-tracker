namespace Finance_tracker.Controls
{
    partial class TransactionTable
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.lastTransactionsTable = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transaction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 30);
            this.panel3.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label10.Location = new System.Drawing.Point(528, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 106;
            this.label10.Text = "Date";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 30);
            this.panel7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label9.Location = new System.Drawing.Point(357, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 106;
            this.label9.Text = "Category";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(656, 1);
            this.panel6.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label8.Location = new System.Drawing.Point(192, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 106;
            this.label8.Text = "Transaction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label7.Location = new System.Drawing.Point(76, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 105;
            this.label7.Text = "Amount";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Location = new System.Drawing.Point(655, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 30);
            this.panel8.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(656, 1);
            this.panel4.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.panel33);
            this.groupBox3.Controls.Add(this.panel34);
            this.groupBox3.Controls.Add(this.panel35);
            this.groupBox3.Controls.Add(this.panel36);
            this.groupBox3.Controls.Add(this.panel37);
            this.groupBox3.Controls.Add(this.panel38);
            this.groupBox3.Controls.Add(this.panel39);
            this.groupBox3.Controls.Add(this.lastTransactionsTable);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(0, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 511);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.Gainsboro;
            this.panel33.Location = new System.Drawing.Point(1, 459);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(656, 1);
            this.panel33.TabIndex = 120;
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.Gainsboro;
            this.panel34.Location = new System.Drawing.Point(1, 408);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(656, 1);
            this.panel34.TabIndex = 119;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.Gainsboro;
            this.panel35.Location = new System.Drawing.Point(1, 357);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(656, 1);
            this.panel35.TabIndex = 118;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.Gainsboro;
            this.panel36.Location = new System.Drawing.Point(1, 306);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(656, 1);
            this.panel36.TabIndex = 117;
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.Gainsboro;
            this.panel37.Location = new System.Drawing.Point(1, 255);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(656, 1);
            this.panel37.TabIndex = 116;
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.Gainsboro;
            this.panel38.Location = new System.Drawing.Point(1, 204);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(656, 1);
            this.panel38.TabIndex = 115;
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.Gainsboro;
            this.panel39.Location = new System.Drawing.Point(1, 153);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(656, 1);
            this.panel39.TabIndex = 114;
            // 
            // lastTransactionsTable
            // 
            this.lastTransactionsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastTransactionsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.amount,
            this.transaction,
            this.category,
            this.date});
            this.lastTransactionsTable.Font = new System.Drawing.Font("Helvetica Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTransactionsTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(103)))));
            this.lastTransactionsTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lastTransactionsTable.HideSelection = false;
            this.lastTransactionsTable.Location = new System.Drawing.Point(1, 102);
            this.lastTransactionsTable.Name = "lastTransactionsTable";
            this.lastTransactionsTable.Size = new System.Drawing.Size(654, 407);
            this.lastTransactionsTable.StateImageList = this.imageList1;
            this.lastTransactionsTable.TabIndex = 4;
            this.lastTransactionsTable.UseCompatibleStateImageBehavior = false;
            this.lastTransactionsTable.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "Number";
            this.number.Width = 71;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 119;
            // 
            // transaction
            // 
            this.transaction.Text = "Transaction";
            this.transaction.Width = 165;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 170;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 125;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label20);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.ForeColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(560, 73);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(656, 30);
            this.panel9.TabIndex = 112;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label19.Location = new System.Drawing.Point(528, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 18);
            this.label19.TabIndex = 106;
            this.label19.Text = "Date";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 30);
            this.panel10.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label20.Location = new System.Drawing.Point(357, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 18);
            this.label20.TabIndex = 106;
            this.label20.Text = "Category";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(656, 1);
            this.panel11.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label21.Location = new System.Drawing.Point(192, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 18);
            this.label21.TabIndex = 106;
            this.label21.Text = "Transaction";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label22.Location = new System.Drawing.Point(76, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 18);
            this.label22.TabIndex = 105;
            this.label22.Text = "Amount";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gainsboro;
            this.panel12.Location = new System.Drawing.Point(655, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 30);
            this.panel12.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gainsboro;
            this.panel13.Location = new System.Drawing.Point(0, 29);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(656, 1);
            this.panel13.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last 8 transactions";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(22, 51);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TransactionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Name = "TransactionTable";
            this.Size = new System.Drawing.Size(656, 511);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.ListView lastTransactionsTable;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader transaction;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
    }
}
