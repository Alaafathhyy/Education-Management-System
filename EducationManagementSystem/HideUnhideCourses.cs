using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class HideUnhideCourses : Form
    {
        private string loggedID = null;

        public HideUnhideCourses(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
            UpdateShowCourse();
            UpdateHideCourse();
        }
        private void UpdateShowCourse()
        {
            SqlConnection sqlConnection = null;
            SqlDataReader sqlReader = null;
            ShowBox.Items.Clear();
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();

                command.CommandText = "Select * from [course] where hiddden = 1 and instructor_id = " + this.loggedID;
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    ShowBox.Items.Add(sqlReader["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void UpdateHideCourse()
        {
            new UpdateCourse(loggedID).ShowCourseNameMenu(HideBox, this.loggedID);
        }

        private void ShowClick(object sender, EventArgs e)
        {
            if (ShowBox.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();

                    command.CommandText = "update course set hiddden = 0 where name ='" + ShowBox.Text + "';";
                    command.ExecuteScalar();
                    MessageBox.Show(ShowBox.Text + " Course is available ");
                    ShowBox.Text = "";

                    UpdateShowCourse();
                    UpdateHideCourse();
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

        private void HideClick(object sender, EventArgs e)
        {
            if (HideBox.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();

                    command.CommandText = "update course set hiddden = 1 where name ='" + HideBox.Text + "';";
                    command.ExecuteScalar();
                    MessageBox.Show(HideBox.Text + " Course has been hidden ");
                    HideBox.Text = "";

                    UpdateHideCourse();
                    UpdateShowCourse();
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

