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
	[Table(Name = "Customers")]
	public class Customer
	{
		private string _customerID;
		[Column(IsPrimaryKey = true, Storage = "_customerID")]
		public string customerID
		{
			get { return this._customerID; }
			set { this._customerID = value; }
		}

		private string _city;
		[Column(Storage = "_city")]
		public string city
		{
			get { return this._city; }
			set { this._city = value; }
		}

		public override string ToString()
		{
			return customerID + "\t" + city;
		}

		private EntitySet<Order> _orders;
		public Customer()
        {
			this._orders = new EntitySet<Order>();
        }

		[Association(Storage = "_orders", OtherKey = "customerID")]
		public EntitySet<Order> orders
        {
            get { return this._orders; }
            set { this._orders.Assign(value); }
        }
			

	}

	[Table(Name = "Orders")]
	public class Order
	{
		private int _orderID = 0;
		private string _customerID;
		private EntityRef<Customer> _customer;

		public Order()
        {
			this._customer = new EntityRef<Customer>();
        }

		[Column(Storage = "_orderID", DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
		public int orderID
        {
            get { return this._orderID; }
        }

		[Column(Storage = "_customerID", DbType = "NChar(5)")]
		public string customerID
        {
            get { return this._customerID; }
            set { this._customerID = value; }
        }

		[Association(Storage = "_customer", ThisKey = "customerID")]
		public Customer customer
        {
            get { return this._customer.Entity; }
            set { this._customer.Entity = value; }
        }
	}
}
