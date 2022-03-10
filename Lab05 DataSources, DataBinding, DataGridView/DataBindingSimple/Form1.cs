using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingSimple
{
    public partial class Form1 : Form
    {
        private BindingSource productBindingSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(northwindDataSet1.Products);
            productBindingSource = new BindingSource(northwindDataSet1, "Products");
            txtBoxProductID.DataBindings.Add("Text", productBindingSource, "ProductID");
            txtBoxProductName.DataBindings.Add("Text", productBindingSource, "ProductName");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
        }

        private void txtBoxProductID_TextChanged(object sender, EventArgs e)
        {
            if (productBindingSource.Position == 0)
            {
                btnMoveFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnMoveLast.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Focus();
            }
            else if(productBindingSource.Position + 1 == productBindingSource.Count)
            {
                btnMoveLast.Enabled = false;
                btnNext.Enabled = false;
                btnMoveFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnPrevious.Focus();
            }
            else
            {
                btnMoveFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnMoveLast.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void txtBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();
        }
    }
}
