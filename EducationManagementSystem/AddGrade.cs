using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class AddGrade : Form
    {
        private string loggedID = null, SelectedCourseID = null;
        public AddGrade(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
            new UpdateCourse(loggedID).ShowCourseNameMenu(CourseNameComboBox, this.loggedID);
        }


        private void CourseNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseNameComboBox.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                 

                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();
                    command.CommandText = "Select ID from course where name = '" + CourseNameComboBox.Text + "';";

                    //get the selected Course ID 
                    SelectedCourseID = Convert.ToString(command.ExecuteScalar());

                    // generate all Exams ID 
                    command.CommandText = "Select ID from Exam where c_id =  " + SelectedCourseID + ";";
                    SqlDataReader sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        ExamIDComboBox.Items.Add(sqlReader["id"].ToString());
                    }
                    sqlReader.Close();

                    command.CommandText = "Select student_ID from register where course_id =  " + SelectedCourseID + ";";
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        StudentIDComboBox.Items.Add(sqlReader["student_id"].ToString());
                    }
                    sqlReader.Close();
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

        private void AddMarkClick(object sender, EventArgs e)
        {
            if (StudentIDComboBox.Text != "" && ExamIDComboBox.Text != "" && CourseNameComboBox.Text != "" && GradeText.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();
                    command.CommandText = "insert into transcript(student_id , exam_id , course_id , grade) " +
                        "values( " + StudentIDComboBox.Text + ", " + ExamIDComboBox.Text + ", "
                        + SelectedCourseID + "," + GradeText.Text + ") ;";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Grade has been added Successfully");
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

