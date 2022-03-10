using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersOrdersFinal
{
    public partial class Form1 : Form
    {
        DataView customersDataView;
        DataView ordersDataView;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            customersDataView.Sort = "CustomerID";
            dataGridCust.DataSource = customersDataView;
            dataGridOrders.DataSource = ordersDataView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxOrderID.Text != "" && textBoxCustID.Text != "")
            {
                MessageBox.Show("Заполните только одно поле");
                return;
            }
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);

            if (textBoxOrderID.Text == "")
            {
                try
                {
                    customersTableAdapter1.Fill(northwindDataSet1.Customers);
                    dataGridCust.DataSource = customersDataView;
                    customersDataView.Sort = "CustomerID";
                    customersDataView.RowFilter = $"CustomerID = '{textBoxCustID.Text}'";
                    if (dataGridCust.Rows[0].Cells[1].Value == null)
                    {
                        MessageBox.Show("Неверный ID клиента");
                        textBoxCustID.Text = "";
                        return;
                    }
                    else
                    {
                        ordersTableAdapter1.Fill(northwindDataSet1.Orders);
                        DataRowView selectedRow = customersDataView[customersDataView.Find(textBoxCustID.Text)];
                        ordersDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
                        dataGridOrders.DataSource = ordersDataView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBoxCustID.Text = textBoxOrderID.Text = "";                
            }
            else
            {
                try
                {
                    ordersTableAdapter1.Fill(northwindDataSet1.Orders);
                    ordersDataView.Sort = "OrderID";
                    ordersDataView.RowFilter = $"OrderID = '{textBoxOrderID.Text}'";
                    dataGridOrders.DataSource = ordersDataView;

                    if (dataGridOrders.Rows[0].Cells[1].Value == null)
                    {
                        MessageBox.Show("Неверный номер заказа");
                        textBoxOrderID.Text = "";
                        return;
                    }

                    else
                    {                     
                        customersTableAdapter1.Fill(northwindDataSet1.Customers);
                        string selectedCustomerID = dataGridOrders.Rows[0].Cells[1].Value.ToString();
                        customersDataView.Sort = "CustomerID";
                        customersDataView.RowFilter = $"CustomerID = '{selectedCustomerID}'";
                        dataGridCust.DataSource = customersDataView;
                        textBoxOrderID.Text = textBoxCustID.Text = "";                       
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }           
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            customersDataView.Sort = "CustomerID";
            dataGridCust.DataSource = customersDataView;
            dataGridOrders.DataSource = ordersDataView;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customersTableAdapter1.Update(northwindDataSet1);
                ordersTableAdapter1.Update(northwindDataSet1);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void textBoxCustID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле может содержать только буквы");
            }
        }

        private void textBoxOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле может содержать только цифры");
            }
        }
    }
}
