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
    public partial class UpdateExam : Form
    {
        private string loggedID = null;
        public UpdateExam(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
            ShowExamIDMenu(ExamIDComboBox , this.loggedID);
            new UpdateCourse(loggedID).ShowCourseNameMenu(CourseNameComboBox , this.loggedID);     
        }
        public void ShowExamIDMenu(ComboBox Menu , string ID)
        {
            Menu.Items.Clear();
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                
                command.CommandText = "Select id from [exam] where I_id = " + ID + ";";
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    Menu.Items.Add(sqlReader["id"].ToString());
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
    

        private void BackClick (object sender, EventArgs e)
        {
            this.Hide();
            new HomePage(loggedID).ShowDialog();
            this.Dispose();
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            if (ExamIDComboBox.Text != "" && CourseNameComboBox.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();
                   
                    command.CommandText = "select id from course where name = '" + CourseNameComboBox.Text + "';";
                    string ID = Convert.ToString(command.ExecuteScalar());

                    command.CommandText = "update exam set c_id = " + ID + " where id = " + ExamIDComboBox.Text + ";";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Exam has been Updaded successfully");
                    ExamIDComboBox.Text = "";
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
        }
    }
}

