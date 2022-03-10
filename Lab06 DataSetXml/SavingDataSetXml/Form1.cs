using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingDataSetXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFillDataSet_Click(object sender, EventArgs e)
        {
            customersAdapter.Fill(northwindDataSet1.Customers);
            ordersAdapter.Fill(northwindDataSet1.Orders);
            customersGrid.DataSource = northwindDataSet1.Customers;
        }

        private void btnSaveXMLData_Click(object sender, EventArgs e)
        {
            try
            {
                northwindDataSet1.WriteXml("Northwind.xml");
                MessageBox.Show("Data saved as XML");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveXMLSchema_Click(object sender, EventArgs e)
        {
            try
            {
                northwindDataSet1.WriteXmlSchema("Northwind.xsd");
                MessageBox.Show("Schema saved successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
