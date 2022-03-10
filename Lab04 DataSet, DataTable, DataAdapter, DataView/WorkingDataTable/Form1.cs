using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = northwindDataSet1.Customers;
            customersDataGridView.MultiSelect = false;
            customersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            customersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnFillTable_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.CustomersRow newRow = (NorthwindDataSet.CustomersRow)northwindDataSet1.Customers.NewRow();
            newRow.CustomerID = "WINGT";
            newRow.CompanyName = "Wingtip Toys";
            newRow.ContactName = "Steve Lasker";
            newRow.ContactTitle = "CEO";
            newRow.Address = "1234 Main Street";
            newRow.City = "Buffalo";
            newRow.Region = "NY";
            newRow.PostalCode = "98052";
            newRow.Country = "USA";
            newRow.Phone = "206-555-0111";
            newRow.Fax = "206-555-0112";
            try
            {
                northwindDataSet1.Customers.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failure");
            }
        }

        private NorthwindDataSet.CustomersRow GetSelectedRow()
        {
            string selectedCustomerId = customersDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            NorthwindDataSet.CustomersRow selectedRow = northwindDataSet1.Customers.FindByCustomerID(selectedCustomerId);
            return selectedRow;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void UpdateRowVersionDisplay()
        {
            try
            {
                txtBoxCurrentDRV.Text = GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();

            }
            catch(Exception ex)
            {
                txtBoxCurrentDRV.Text = ex.Message;
            }
            try
            {
                txtBoxOriginalDRV.Text = GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch(Exception ex)
            {
                txtBoxOriginalDRV.Text = ex.Message;
            }
            txtBoxRowState.Text = GetSelectedRow().RowState.ToString();
        }

        private void btnUpdateValue_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name] = txtBoxCellValue.Text;
            UpdateRowVersionDisplay();
        }

        private void customersDataGridView_Click(object sender, EventArgs e)
        {
            txtBoxCellValue.Text = customersDataGridView.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();
        }

        private void btnAcceptChange_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void btnRejectChange_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
