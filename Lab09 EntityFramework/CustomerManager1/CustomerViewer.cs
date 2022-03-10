using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CodeFirst;

namespace CustomerManager1
{
    public partial class CustomerViewer : Form
    {
        SampleContext context = new SampleContext();
        byte[] Ph;
        public CustomerViewer()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.txtBoxName.Text,
                    LastName = this.txtBoxLastName.Text,
                    Email = this.txtBoxEmail.Text,
                    Age = Int32.Parse(this.txtBoxAge.Text),
                    Photo = Ph,
                    Orders = listBoxOrders.SelectedItems.OfType<Order>().ToList()
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void Output()
        {
            if (this.rBtnCustomers.Checked == true)
                dataGridView1.DataSource = context.Customers.ToList();
            else if (this.rbtnOrders.Checked == true)
                dataGridView1.DataSource = context.Orders.ToList();
            else if (this.rbtnVIPOrders.Checked == true)
                dataGridView1.DataSource = context.VipOrders.ToList();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(dialog.OpenFile());
                ImageConverter converter = new ImageConverter();
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers
                        orderby b.FirstName
                        select b;
            customerList.DataSource = query.ToList();
        }

        private void CustomerViewer_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order { ProductName = "Аудио", Quantity = 12, PurchaseDate = DateTime.Parse("12.01.2016") });
            context.Orders.Add(new Order { ProductName = "Видео", Quantity = 22, PurchaseDate = DateTime.Parse("10.01.2016") });
            context.VipOrders.Add(new VipOrder { ProductName = "Авто", Quantity = 101, PurchaseDate = DateTime.Parse("10.01.2016"), status = "Высокий" });
            context.SaveChanges();

            listBoxOrders.DataSource = context.Orders.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var customer = dataGridView1.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return;
            lblID.Text = Convert.ToString(customer.CustomerID);
            txtBoxID.Text = customer.ToString();
            txtBoxName.Text = customer.FirstName;
            txtBoxLastName.Text = customer.LastName;
            txtBoxEmail.Text = customer.Email;
            txtBoxAge.Text = customer.Age.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblID.Text == String.Empty) return;

            var id = Convert.ToInt32(lblID.Text);
            var customer = context.Customers.Find(id);
            if (customer == null) return;

            customer.FirstName = this.txtBoxName.Text;
            customer.LastName = this.txtBoxLastName.Text;
            customer.Email = this.txtBoxEmail.Text;
            customer.Age = Int32.Parse(this.txtBoxAge.Text);

            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
            Output();
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblID.Text == String.Empty) return;
            var id = Convert.ToInt32(lblID.Text);
            var customer = context.Customers.Find(id);

            context.Entry(customer).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
            ClearAll();
        }

        private void ClearAll()
        {
            txtBoxName.Text = String.Empty;
            txtBoxLastName.Text = String.Empty;
            txtBoxEmail.Text = String.Empty;
            txtBoxAge.Text = String.Empty;
            lblID.Text = "ID";
            txtBoxID.Text = String.Empty;
            customerList.Text = String.Empty;
        }
    }
}
