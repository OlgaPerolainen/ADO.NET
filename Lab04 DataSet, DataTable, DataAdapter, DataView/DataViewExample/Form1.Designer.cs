
namespace DataViewExample
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
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.txtBoxSort = new System.Windows.Forms.TextBox();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.btnSetDataViewProperties = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.northwindDataSet1 = new DataViewExample.NorthwindDataSet();
            this.customersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGrid
            // 
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.customersGrid.Location = new System.Drawing.Point(0, 0);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.RowHeadersWidth = 51;
            this.customersGrid.RowTemplate.Height = 24;
            this.customersGrid.Size = new System.Drawing.Size(280, 450);
            this.customersGrid.TabIndex = 0;
            // 
            // txtBoxSort
            // 
            this.txtBoxSort.Location = new System.Drawing.Point(302, 56);
            this.txtBoxSort.Name = "txtBoxSort";
            this.txtBoxSort.Size = new System.Drawing.Size(196, 22);
            this.txtBoxSort.TabIndex = 1;
            this.txtBoxSort.Text = "CustomerID";
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.Location = new System.Drawing.Point(302, 108);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(196, 22);
            this.txtBoxFilter.TabIndex = 2;
            this.txtBoxFilter.Text = "City = \'London\'";
            // 
            // btnSetDataViewProperties
            // 
            this.btnSetDataViewProperties.Location = new System.Drawing.Point(302, 275);
            this.btnSetDataViewProperties.Name = "btnSetDataViewProperties";
            this.btnSetDataViewProperties.Size = new System.Drawing.Size(196, 35);
            this.btnSetDataViewProperties.TabIndex = 3;
            this.btnSetDataViewProperties.Text = "Set Data View Properties";
            this.btnSetDataViewProperties.UseVisualStyleBackColor = true;
            this.btnSetDataViewProperties.Click += new System.EventHandler(this.btnSetDataViewProperties_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(302, 334);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(196, 35);
            this.btnAddRow.TabIndex = 4;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
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
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(302, 392);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(196, 35);
            this.btnGetOrders.TabIndex = 5;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersGrid.Location = new System.Drawing.Point(520, 0);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowTemplate.Height = 24;
            this.ordersGrid.Size = new System.Drawing.Size(280, 450);
            this.ordersGrid.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.btnGetOrders);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnSetDataViewProperties);
            this.Controls.Add(this.txtBoxFilter);
            this.Controls.Add(this.txtBoxSort);
            this.Controls.Add(this.customersGrid);
            this.Name = "Form1";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.TextBox txtBoxSort;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.Button btnSetDataViewProperties;
        private System.Windows.Forms.Button btnAddRow;
        private NorthwindDataSet northwindDataSet1;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.DataGridView ordersGrid;
    }
}

