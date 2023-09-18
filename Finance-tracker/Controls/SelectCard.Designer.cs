namespace Finance_tracker.Controls
{
    partial class SelectCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.pbDot1 = new System.Windows.Forms.PictureBox();
            this.pbDot3 = new System.Windows.Forms.PictureBox();
            this.pbDot2 = new System.Windows.Forms.PictureBox();
            this.creditCard = new Finance_tracker.Controls.CreditCard();
            this.pbAdditionaSettings = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDeleteCard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdditionaSettings)).BeginInit();
            this.AddDeleteCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.pbDot1);
            this.groupBox1.Controls.Add(this.pbDot3);
            this.groupBox1.Controls.Add(this.pbDot2);
            this.groupBox1.Controls.Add(this.creditCard);
            this.groupBox1.Controls.Add(this.pbAdditionaSettings);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.bAdd.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(221, 240);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(83, 28);
            this.bAdd.TabIndex = 130;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Visible = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pbDot1
            // 
            this.pbDot1.Image = ((System.Drawing.Image)(resources.GetObject("pbDot1.Image")));
            this.pbDot1.Location = new System.Drawing.Point(130, 242);
            this.pbDot1.Name = "pbDot1";
            this.pbDot1.Size = new System.Drawing.Size(25, 25);
            this.pbDot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDot1.TabIndex = 124;
            this.pbDot1.TabStop = false;
            this.pbDot1.Visible = false;
            this.pbDot1.Click += new System.EventHandler(this.pbDot1_Click);
            // 
            // pbDot3
            // 
            this.pbDot3.Image = ((System.Drawing.Image)(resources.GetObject("pbDot3.Image")));
            this.pbDot3.Location = new System.Drawing.Point(180, 242);
            this.pbDot3.Name = "pbDot3";
            this.pbDot3.Size = new System.Drawing.Size(25, 25);
            this.pbDot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDot3.TabIndex = 123;
            this.pbDot3.TabStop = false;
            this.pbDot3.Visible = false;
            this.pbDot3.Click += new System.EventHandler(this.pbDot3_Click);
            // 
            // pbDot2
            // 
            this.pbDot2.Image = ((System.Drawing.Image)(resources.GetObject("pbDot2.Image")));
            this.pbDot2.Location = new System.Drawing.Point(155, 242);
            this.pbDot2.Name = "pbDot2";
            this.pbDot2.Size = new System.Drawing.Size(25, 25);
            this.pbDot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDot2.TabIndex = 122;
            this.pbDot2.TabStop = false;
            this.pbDot2.Visible = false;
            this.pbDot2.Click += new System.EventHandler(this.pbDot2_Click);
            // 
            // creditCard
            // 
            this.creditCard.Location = new System.Drawing.Point(22, 57);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(291, 186);
            this.creditCard.TabIndex = 131;
            // 
            // pbAdditionaSettings
            // 
            this.pbAdditionaSettings.BackColor = System.Drawing.Color.White;
            this.pbAdditionaSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbAdditionaSettings.Image")));
            this.pbAdditionaSettings.Location = new System.Drawing.Point(281, 23);
            this.pbAdditionaSettings.Name = "pbAdditionaSettings";
            this.pbAdditionaSettings.Size = new System.Drawing.Size(25, 25);
            this.pbAdditionaSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdditionaSettings.TabIndex = 129;
            this.pbAdditionaSettings.TabStop = false;
            this.pbAdditionaSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAdditionaSettings_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Helvetica Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit card";
            // 
            // AddDeleteCard
            // 
            this.AddDeleteCard.BackColor = System.Drawing.Color.White;
            this.AddDeleteCard.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDeleteCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.AddDeleteCard.Name = "contextMenuStrip1";
            this.AddDeleteCard.Size = new System.Drawing.Size(119, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // SelectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectCard";
            this.Size = new System.Drawing.Size(340, 276);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdditionaSettings)).EndInit();
            this.AddDeleteCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbAdditionaSettings;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.PictureBox pbDot1;
        private System.Windows.Forms.PictureBox pbDot3;
        private System.Windows.Forms.PictureBox pbDot2;
        private System.Windows.Forms.Label label1;
        private CreditCard creditCard;
        private System.Windows.Forms.ContextMenuStrip AddDeleteCard;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
