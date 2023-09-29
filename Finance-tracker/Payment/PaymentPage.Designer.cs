namespace Finance_tracker.PaymentPage
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.payment = new Finance_tracker.Payment.Payment();
            this.transferToTheCard = new Finance_tracker.Payment.TransferToTheCard();
            this.utilitiesPayment = new Finance_tracker.Payment.TypeOfPayment();
            this.mobilePayment = new Finance_tracker.Payment.TypeOfPayment();
            this.internetPayment = new Finance_tracker.Payment.TypeOfPayment();
            this.SuspendLayout();
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.label18.Name = "label18";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.label23.Name = "label23";
            // 
            // payment
            // 
            this.payment.Amount = "";
            this.payment.CardId = null;
            this.payment.Category = null;
            resources.ApplyResources(this.payment, "payment");
            this.payment.Name = "payment";
            this.payment.Number = "";
            this.payment.Purpose = "-";
            // 
            // transferToTheCard
            // 
            resources.ApplyResources(this.transferToTheCard, "transferToTheCard");
            this.transferToTheCard.Name = "transferToTheCard";
            // 
            // utilitiesPayment
            // 
            this.utilitiesPayment.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.utilitiesPayment, "utilitiesPayment");
            this.utilitiesPayment.Name = "utilitiesPayment";
            this.utilitiesPayment.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("utilitiesPayment.PictureBoxImage")));
            this.utilitiesPayment.Title = "utilities";
            this.utilitiesPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.utilitiesPayment_KeyPress);
            // 
            // mobilePayment
            // 
            this.mobilePayment.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.mobilePayment, "mobilePayment");
            this.mobilePayment.Name = "mobilePayment";
            this.mobilePayment.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("mobilePayment.PictureBoxImage")));
            this.mobilePayment.Title = "mobile";
            // 
            // internetPayment
            // 
            this.internetPayment.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.internetPayment, "internetPayment");
            this.internetPayment.Name = "internetPayment";
            this.internetPayment.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("internetPayment.PictureBoxImage")));
            this.internetPayment.Title = "internet";
            // 
            // PaymentPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.payment);
            this.Controls.Add(this.transferToTheCard);
            this.Controls.Add(this.utilitiesPayment);
            this.Controls.Add(this.mobilePayment);
            this.Controls.Add(this.internetPayment);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label23);
            this.Name = "PaymentPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private Payment.TypeOfPayment internetPayment;
        private Payment.TypeOfPayment mobilePayment;
        private Payment.TypeOfPayment utilitiesPayment;
        private Payment.TransferToTheCard transferToTheCard;
        private Payment.Payment payment;
    }
}
