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

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand1.CommandType = CommandType.Text;
            sqlConnection1.Open();
            SqlDataReader reader = sqlCommand1.ExecuteReader();
            bool moreResults = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                moreResults = reader.NextResult();
            } while (moreResults);
            reader.Close();
            sqlCommand1.Connection.Close();
            richTextBox1.Text = results.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.CommandText = "Ten Most Expensive Products";
            sqlConnection1.Open();
            SqlDataReader reader = sqlCommand2.ExecuteReader();
            while(reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result.Append(reader[i].ToString() + "\t");
                }
                result.Append(Environment.NewLine);
            }
            reader.Close();
            sqlCommand2.Connection.Close();
            richTextBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlCommand3.CommandType = CommandType.Text;
            sqlCommand3.CommandText = "CREATE TABLE SalesPerson (" +
                "[SalesPersonID] [int] IDENTITY (1, 1) NOT NULL, " +
                "[FirstName] [nvarchar](50) NULL, " +
                "[LastName] [nvarchar](50) NULL)";
            sqlCommand3.Connection.Open();
            try
            {
                sqlCommand3.ExecuteNonQuery();
                MessageBox.Show("Таблица SalesPerson создана");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCommand3.Connection.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand4.CommandType = CommandType.Text;
            sqlCommand4.Parameters["@City"].Value = CityTextBox.Text;
            sqlCommand4.Connection.Open();
            SqlDataReader reader = sqlCommand4.ExecuteReader();
            bool moreResults = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                    moreResults = reader.NextResult();
                }

            } while (moreResults);

            reader.Close();
            sqlCommand4.Connection.Close();
            richTextBox1.Text = results.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand5.Parameters["@CategoryName"].Value = CategoryNameTextBox.Text;
            sqlCommand5.Parameters["@OrdYear"].Value = ordYearTextBox.Text;
            sqlCommand5.Connection.Open();
            SqlDataReader reader = sqlCommand5.ExecuteReader();
            while(reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }
            reader.Close();
            sqlCommand5.Connection.Close();
            richTextBox1.Text = results.ToString();
        }
    }
}
