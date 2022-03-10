
namespace LoadDataSetXml
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
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnLoadSchema = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridCustomers.Location = new System.Drawing.Point(0, 0);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.RowHeadersWidth = 51;
            this.gridCustomers.RowTemplate.Height = 24;
            this.gridCustomers.Size = new System.Drawing.Size(800, 189);
            this.gridCustomers.TabIndex = 0;
            // 
            // gridOrders
            // 
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridOrders.Location = new System.Drawing.Point(0, 189);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RowHeadersWidth = 51;
            this.gridOrders.RowTemplate.Height = 24;
            this.gridOrders.Size = new System.Drawing.Size(800, 189);
            this.gridOrders.TabIndex = 1;
            // 
            // btnLoadSchema
            // 
            this.btnLoadSchema.Location = new System.Drawing.Point(139, 400);
            this.btnLoadSchema.Name = "btnLoadSchema";
            this.btnLoadSchema.Size = new System.Drawing.Size(177, 38);
            this.btnLoadSchema.TabIndex = 2;
            this.btnLoadSchema.Text = "Load Schema";
            this.btnLoadSchema.UseVisualStyleBackColor = true;
            this.btnLoadSchema.Click += new System.EventHandler(this.btnLoadSchema_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(454, 400);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(177, 38);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnLoadSchema);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.gridCustomers);
            this.Name = "Form1";
            this.Text = "Customers and Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Button btnLoadSchema;
        private System.Windows.Forms.Button btnLoadData;
    }
}

