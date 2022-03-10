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

namespace DataAdapterProgram
{
    public partial class Form1 : Form
    {
        private SqlConnection northwindConnection = new SqlConnection(@"Data Source=LAPTOP-9NI9ES32\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        private SqlDataAdapter sqlDataAdapter1;
        private DataSet northwindDataSet = new DataSet("Northwind");
        private DataTable customersTable = new DataTable("Customers");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers", northwindConnection);
            northwindDataSet.Tables.Add(customersTable);
            sqlDataAdapter1.Fill(northwindDataSet.Tables["Customers"]);
            dataGridView1.DataSource = northwindDataSet.Tables["Customers"];
            SqlCommandBuilder commands = new SqlCommandBuilder(sqlDataAdapter1);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            northwindDataSet.EndInit();
            try
            {
                sqlDataAdapter1.Update(northwindDataSet.Tables["Customers"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
