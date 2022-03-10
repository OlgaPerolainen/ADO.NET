
namespace CustomersOrdersFinal
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
            this.dataGridCust = new System.Windows.Forms.DataGridView();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.northwindDataSet1 = new CustomersOrdersFinal.NorthwindDataSet();
            this.customersTableAdapter1 = new CustomersOrdersFinal.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new CustomersOrdersFinal.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.btnLoadAllData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCust
            // 
            this.dataGridCust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCust.Location = new System.Drawing.Point(0, 1);
            this.dataGridCust.Name = "dataGridCust";
            this.dataGridCust.RowHeadersWidth = 51;
            this.dataGridCust.RowTemplate.Height = 24;
            this.dataGridCust.Size = new System.Drawing.Size(805, 150);
            this.dataGridCust.TabIndex = 0;
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(0, 148);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowHeadersWidth = 51;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(805, 150);
            this.dataGridOrders.TabIndex = 1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(610, 396);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(178, 32);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCustID.Location = new System.Drawing.Point(134, 31);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(185, 22);
            this.textBoxCustID.TabIndex = 3;
            this.textBoxCustID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCustID_KeyPress);
            // 
            // btnLoadAllData
            // 
            this.btnLoadAllData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadAllData.Location = new System.Drawing.Point(12, 335);
            this.btnLoadAllData.Name = "btnLoadAllData";
            this.btnLoadAllData.Size = new System.Drawing.Size(178, 32);
            this.btnLoadAllData.TabIndex = 4;
            this.btnLoadAllData.Text = "Загрузить все данные";
            this.btnLoadAllData.UseVisualStyleBackColor = true;
            this.btnLoadAllData.Click += new System.EventHandler(this.btnLoadAllData_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxOrderID);
            this.groupBox1.Controls.Add(this.textBoxCustID);
            this.groupBox1.Location = new System.Drawing.Point(223, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите ID клиента или заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID клиента";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOrderID.Location = new System.Drawing.Point(134, 76);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(185, 22);
            this.textBoxOrderID.TabIndex = 4;
            this.textBoxOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderID_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadAllData);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.dataGridCust);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Customers and Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCust;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private NorthwindDataSet northwindDataSet1;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Button btnLoadAllData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderID;
    }
}

