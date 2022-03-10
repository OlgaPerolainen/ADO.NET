
namespace LINQsqlSproc
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEnterOrderId = new System.Windows.Forms.Label();
            this.lblEnterCustID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(375, 62);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(186, 33);
            this.btnOrderDetails.TabIndex = 0;
            this.btnOrderDetails.Text = "Подробности заказа";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(375, 145);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(186, 33);
            this.btnOrderHistory.TabIndex = 1;
            this.btnOrderHistory.Text = "История заказа";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblEnterOrderId
            // 
            this.lblEnterOrderId.AutoSize = true;
            this.lblEnterOrderId.Location = new System.Drawing.Point(48, 62);
            this.lblEnterOrderId.Name = "lblEnterOrderId";
            this.lblEnterOrderId.Size = new System.Drawing.Size(139, 17);
            this.lblEnterOrderId.TabIndex = 4;
            this.lblEnterOrderId.Text = "Введите код заказа";
            // 
            // lblEnterCustID
            // 
            this.lblEnterCustID.AutoSize = true;
            this.lblEnterCustID.Location = new System.Drawing.Point(48, 145);
            this.lblEnterCustID.Name = "lblEnterCustID";
            this.lblEnterCustID.Size = new System.Drawing.Size(148, 17);
            this.lblEnterCustID.TabIndex = 5;
            this.lblEnterCustID.Text = "Введите код клиента";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 263);
            this.Controls.Add(this.lblEnterCustID);
            this.Controls.Add(this.lblEnterOrderId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnOrderDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEnterOrderId;
        private System.Windows.Forms.Label lblEnterCustID;
    }
}

