using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace CourseManager
{
    public partial class CourseViewer : Form
    {
        private SchoolEntities schoolContext;
        public CourseViewer()
        {
            InitializeComponent();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            var departmentQuery = from d in schoolContext.Departments.Include("Courses")
                                  orderby d.Name
                                  select d;          

            try
            {
                this.departmentList.DisplayMember = "Name";
				this.departmentList.DataSource = ((ObjectQuery)departmentQuery).Execute(MergeOption.AppendOnly);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Department department = (Department)this.departmentList.SelectedItem;

                courseGridView.DataSource = department.Courses;
				
                coursegridview.columns["department"].visible = false;
                coursegridview.columns["studentgrades"].visible = false;
                coursegridview.columns["onlinecourse"].visible = false;
                coursegridview.columns["onsitecourse"].visible = false;
                coursegridview.columns["people"].visible = false;
                coursegridview.columns["departmentid"].visible = false;

                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
            schoolContext.Dispose();
        }
    }
}
