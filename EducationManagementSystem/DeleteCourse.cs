using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class DeleteCourse : Form
    {
        private string loggedID = null;
        public DeleteCourse(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
            new UpdateCourse(loggedID).ShowCourseNameMenu(courseName , this.loggedID);
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if(courseName.Text != "")
            {
                 SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();

                    command.CommandText = "Delete from course where name = '" + courseName.Text + "';";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Course has been deleted");
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
