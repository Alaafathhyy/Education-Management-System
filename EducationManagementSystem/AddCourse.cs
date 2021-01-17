using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class AddCourse : Form
    {
        private string loggedID = null;
        public AddCourse(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();

            //this is to show a menu of all category names avaialble so that the user can select from 
            new UpdateCourse(loggedID).ShowCategoryNamesMenu(CategoryNameComboBox);
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (CategoryNameComboBox.Text != "")
            {
                string ErrorMsg = "Please Fill in all the Fields";
                SqlConnection sqlConnection = null;
                try
                {
                    if (YearText.Text == "" ||  CourseNameText.Text == "" || SemesterText.Text == "")
                        throw new Exception(ErrorMsg);
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();

                   

                    //convert the selected category name into category ID   
                    command.CommandText = "select id from category where name = '" + CategoryNameComboBox.Text + "'";
                    string CategoryID = Convert.ToString(command.ExecuteScalar());

                    command.CommandText = "insert into Course (name , category_id , year , semester , instructor_id)  VALUES ('"
                            + CourseNameText.Text + "'," + CategoryID + "," + YearText.Text + "," + SemesterText.Text + "," + this.loggedID + ");";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Course has been added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sqlConnection != null)
                        sqlConnection.Close();
                }
            }
           
        }

       
        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage(loggedID).ShowDialog();
            this.Dispose();
        }
    }
}
