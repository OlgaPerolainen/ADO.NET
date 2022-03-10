
namespace LINQsql_m
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
            this.btnTopTen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnTopTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnTopTen
            // 
            this.btnTopTen.Location = new System.Drawing.Point(50, 79);
            this.btnTopTen.Name = "btnTopTen";
            this.btnTopTen.Size = new System.Drawing.Size(230, 47);
            this.btnTopTen.TabIndex = 0;
            this.btnTopTen.Text = "Десять самых дорогих товаров";
            this.btnTopTen.UseVisualStyleBackColor = true;
            this.btnTopTen.Click += new System.EventHandler(this.btnTopTen_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTopTen,
            this.columnUnitPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(418, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 303);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnTopTen
            // 
            this.columnTopTen.Text = "Ten Most";
            this.columnTopTen.Width = 120;
            // 
            // columnUnitPrice
            // 
            this.columnUnitPrice.Text = "UnitPrice";
            this.columnUnitPrice.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTopTen);
            this.Name = "Form1";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTopTen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnTopTen;
        private System.Windows.Forms.ColumnHeader columnUnitPrice;
    }
}

