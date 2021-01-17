using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        private string loggedID  = null;
        
        public HomePage(string loggedID )
        {
            this.loggedID = loggedID;
            InitializeComponent();

            if(IsStudent())
            {
                UpdateCourseButton.Hide();
                AddCourseButton.Hide();
                UpdateExamButton.Hide();
                AddExamButton.Hide();
                HideCourseButton.Hide();
                DeleteExamButton.Hide();
                DeleteCourseButton.Hide();
                addCategoryButton.Hide();
                addGradeButton.Hide();
            }
            else
            {
                ApplyButton.Hide();
            }
            comboBox1.Items.Add("Show the Category of each Course");
            comboBox1.Items.Add("Show the data of the Instructor of Each Course");
            comboBox1.Items.Add("Show all Students Data");

            //comboBox1.Items.Add("Show course with the highest number of registered students ");
            //comboBox1.Items.Add("Show the courses that are not assigned to the current semester");
            //comboBox1.Items.Add("Show the category with the least number of students");

           // comboBox1.Items.Add("Show the names of registered students in a specific course who didn’t apply for any exam yet.");
            //comboBox1.Items.Add("Show the top five students for each course in a specific year ");
        }

        private bool IsStudent()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = Program.openConnection();

                SqlCommand command = sqlConnection.CreateCommand();

                command.CommandText = "Select count(*) from  [Student] where ID = " + this.loggedID;

                Int32 count = Convert.ToInt32(command.ExecuteScalar());

                return (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
        private void showGrid(string SQLCommand , int colNumber)
        {
            SqlConnection sqlConnection = null;
            SqlDataReader sqlReader = null;
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                
                command.CommandText = SQLCommand ;
                sqlReader = command.ExecuteReader(); 

                while (sqlReader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    DataGridViewRow row = this.dataGridView1.Rows[index];
                    for (int i = 0; i < colNumber; i++)
                    {
                        row.Cells[i].Value = sqlReader.GetValue(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Columns[0].HeaderText = "Category Name";
                dataGridView1.Columns[1].HeaderText = "Catgeory ID";
                dataGridView1.Columns[2].HeaderText = "Course Name";
                dataGridView1.Columns[3].HeaderText = "Semester";
                dataGridView1.Columns[4].HeaderText = "Year";

                showGrid("select category.name, category.id , course.name, course.Semester, course.year from category , course where category.id = course.category_id", 5);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.Columns[0].HeaderText = "Instructor Name";
                dataGridView1.Columns[1].HeaderText = "Course Name";
                dataGridView1.Columns[2].HeaderText = "Instructor ID";
                dataGridView1.Columns[3].HeaderText = "Instructor Email";
                showGrid("select instructor.name, course.name, instructor.ID, instructor.mail from instructor  , course where instructor.id = course.instructor_id", 4);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.Columns[0].HeaderText = "Student Name";
                dataGridView1.Columns[1].HeaderText = "Student ID";
                dataGridView1.Columns[2].HeaderText = "Student Email";
                dataGridView1.Columns[3].HeaderText = "";
                showGrid("select name,ID, mail from student ", 3);
            }
        }
        private void DeleteExamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteExam(loggedID).ShowDialog();
            this.Dispose();
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteCourse(loggedID).ShowDialog();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCategory(loggedID).ShowDialog();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowListOfStudents(loggedID).ShowDialog();
            this.Dispose();
        }

        private void AddGradeClick(object sender, EventArgs e)
        {
            this.Hide();
            new AddGrade(loggedID).ShowDialog();
            this.Dispose();
        }
        private void EditProfileClick(object sender, EventArgs e)
        {
            this.Hide();
            new EditProfile(loggedID, IsStudent()).ShowDialog();
            this.Dispose();
        }
        private void HideCourseClick(object sender, EventArgs e)
        {
            this.Hide();
            new HideUnhideCourses(loggedID).ShowDialog();
            this.Dispose();
        }

        private void UpdateCourseClick(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateCourse(loggedID).ShowDialog();
            this.Dispose();
        }
        private void AddExamClick(object sender, EventArgs e)
        {
            this.Hide();
            new AddExam(loggedID).ShowDialog();
            this.Dispose();
        }

        private void ApplyClick(object sender, EventArgs e)
        {
            this.Hide();
            new Apply(loggedID).ShowDialog();
            this.Dispose();
        }

        private void AddCourseClick(object sender, EventArgs e)
        {
            this.Hide();
            new AddCourse(loggedID).ShowDialog();
            this.Dispose();
        }

        private void UpdateExamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateExam(loggedID).ShowDialog();
            this.Dispose();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Dispose();
        }
    }
}
