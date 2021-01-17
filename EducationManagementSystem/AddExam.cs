using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddExam : Form
    {
        private string loggedID = null;
        private string courseID = null;
        
        public AddExam(string loggedID)
        {
            this.loggedID = loggedID;
            
            InitializeComponent();

            //show all Courses Menu so the Instructor can determine the course 
             new UpdateCourse(loggedID).ShowCourseNameMenu(CourseNameComboBox, this.loggedID);
        }
       
        private void AddClick(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            try
            {
                if (CourseNameComboBox.Text == "")
                {
                    throw new Exception("Please Select a Course");
                }
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "insert into Exam (C_id ,  I_ID )  VALUES (" + courseID  + ","  + this.loggedID + ");";
                command.ExecuteNonQuery();
                MessageBox.Show("Exam has been added successfully");
                CourseID.Text = "";
                CourseNameComboBox.Text = "";
                
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

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage(loggedID).ShowDialog();
            this.Dispose();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseNameComboBox.Text != "")
            {
                //here I will convert the name of the selected Course to its ID 
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();
                    command.CommandText = "select ID from course where name = '" + CourseNameComboBox.Text + "';";

                    this.courseID =  Convert.ToString(command.ExecuteScalar());
                    CourseID.Text = courseID;
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

        
    }
}
