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

namespace LINQsqlSproc
{
    public partial class Form1 : Form
    {
        Northwnd db = new Northwnd(@"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\northwnd.mdf");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            string param = textBox1.Text;
            var custQuery = db.CustOrdersDetail(Convert.ToInt32(param));
            string msg = "";
            foreach(CustOrdersDetailResult custOrdersDetail in custQuery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "")
            {
                msg = "No results.";               
            }
            MessageBox.Show(msg);
            param = "";
            textBox1.Text = "";
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            string param = textBox2.Text;
            var custQuery = db.CustOrderHist(param);
            string msg = "";
            foreach(CustOrderHistResult custOrderHist in custQuery)
            {
                msg = msg + custOrderHist.ProductName + "\n";
            }
            if (msg == "")
            {
                msg = "No results.";
            }
            MessageBox.Show(msg);
            param = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле может содержать только цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле может содержать только буквы");
            }
        }
    }
}
