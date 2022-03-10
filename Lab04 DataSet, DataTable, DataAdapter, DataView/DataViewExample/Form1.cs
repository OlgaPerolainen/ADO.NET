using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
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
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);

            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            customersDataView.Sort = "CustomerID";
            customersGrid.DataSource = customersDataView;
        }

        private void btnSetDataViewProperties_Click(object sender, EventArgs e)
        {
            try
            {
                customersDataView.Sort = txtBoxSort.Text;
                customersDataView.RowFilter = txtBoxFilter.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRowView newCustRow = customersDataView.AddNew();
            newCustRow["CustomerID"] = "WINGT";
            newCustRow["CompanyName"] = "Wing Tip Toys";
            newCustRow.EndEdit();
        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            string selectedCustomerID = (string)customersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomerID)];
            ordersDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            ordersGrid.DataSource = ordersDataView;
        }
    }
}
