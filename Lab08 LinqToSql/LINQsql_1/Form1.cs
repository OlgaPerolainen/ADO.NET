using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace LINQsql_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source=LAPTOP-9NI9ES32\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            var custQuery =
                from cust in db.GetTable<Customer>()
                where cust.orders.Any()
                select cust;
            foreach(var custObj in custQuery)
            {
                ListViewItem item =
                listView1.Items.Add(custObj.customerID.ToString());
                item.SubItems.Add(custObj.city.ToString());
                item.SubItems.Add(custObj.orders.Count.ToString());
            }

        }
    }
}
