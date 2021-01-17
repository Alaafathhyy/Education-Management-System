using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Apply : Form
    {
        private string loggedID = null;

        public Apply(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
            UpdateCourses();
        }
        private void UpdateCourses()
        {
            SqlConnection sqlConnection = null;
            try
            {
                CourseNameComboBox.Items.Clear();
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();

                command.CommandText = "Select * from Course where hiddden = 0 and course.id not in (select course_id from register where student_id = " + this.loggedID + ");";
                SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    CourseNameComboBox.Items.Add(sqlReader["name"].ToString());
                }
                ClearTextBoxes(this.Controls);
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

        private void ShowCourseDetails()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();

                command.CommandText = "Select ID, Instructor_id, semester, year, category_ID  from Course where name = '" + CourseNameComboBox.Text + "';";
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    CourseID.Text = Convert.ToString(dataReader.GetValue(0));
                    InstructorID.Text = Convert.ToString(dataReader.GetValue(1));
                    Semester.Text = Convert.ToString(dataReader.GetValue(2));
                    Year.Text = Convert.ToString(dataReader.GetValue(3));
                    CategoryID.Text = Convert.ToString(dataReader.GetValue(4));
                }
                dataReader.Close();

                command.CommandText = "Select name from Instructor where ID = " + InstructorID.Text + ";";
                InstructorName.Text = Convert.ToString(command.ExecuteScalar());

                command.CommandText = "Select name from category where ID = " + CategoryID.Text + ";";
                CategoryName.Text = Convert.ToString(command.ExecuteScalar());
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

        private void UpdateCourses(object sender, EventArgs e)
        {
            if (CourseNameComboBox.Text != "")
            {
                ShowCourseDetails();
            }
        }

        private void ApplyClick(object sender, EventArgs e)
        {
            if (CourseNameComboBox.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();

                    command.CommandText = "insert into register (course_id , student_id) values (" + CourseID.Text + ", " + this.loggedID + ");";
                    command.ExecuteNonQuery();

                    MessageBox.Show("You have Successfully registered");
                    CourseNameComboBox.Text = "";
                    UpdateCourses();
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
        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
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
