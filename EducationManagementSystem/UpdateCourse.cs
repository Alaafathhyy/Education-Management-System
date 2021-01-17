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
    public partial class UpdateCourse : Form
    {
        private string loggedID = null;
        private string selectedCourseID = null , selectedCategoryID = null;
        public UpdateCourse(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
            
            ShowCourseNameMenu(CourseNameComboBox, this.loggedID);
            ShowCategoryNamesMenu(UpdateCategoryComboBox);
            
        }
        public void ShowCourseNameMenu(ComboBox Menu, string ID)
        {
            Menu.Items.Clear();
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "Select * from  [Course] where hiddden = 0 and Instructor_id = " + ID + ";";
                SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    Menu.Items.Add(sqlReader["name"].ToString());
                }
                sqlConnection.Close();
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
        public void ShowCategoryNamesMenu(ComboBox Menu )
        {
            Menu.Items.Clear();
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();

                //get all categories to choose from 
                command.CommandText = "Select * from Category ";

                SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    Menu.Items.Add(sqlReader["name"].ToString());
                }

                sqlConnection.Close();
                sqlReader.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCourseButton(object sender, EventArgs e)
        {  

                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();

                    if (UpdateNameText.Text != "")
                    {
                        command.CommandText =
                               " update Course set name = '" + UpdateNameText.Text + "' where ID = " + selectedCourseID;
                        command.ExecuteNonQuery();
                    }
                   
                    if (YearText.Text != "")
                    {
                    command.CommandText =
                          " update Course set year = " + YearText.Text + " where ID = " + selectedCourseID;
                        command.ExecuteNonQuery();
                    }
                    if (Semester.Text != "")
                    {
                        command.CommandText =
                              " update Course set semester = " + Semester.Text + " where ID = " + selectedCourseID;
                        command.ExecuteNonQuery();
                    }
                    if(UpdateCategoryComboBox.Text != null)
                    {
                    command.CommandText =
                             " update Course  set category_id = " + selectedCategoryID + " where ID = " + selectedCourseID;
                    command.ExecuteNonQuery();
                    }


                    sqlConnection.Close();
                    MessageBox.Show("Course has been Updated Successfuly");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    if (sqlConnection != null)
                        sqlConnection.Close();
                }

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseNameComboBox.Text != "")
            {
                
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();

                    SqlCommand command = sqlConnection.CreateCommand();
                    command.CommandText = "select ID from course where name = '" + CourseNameComboBox.Text + "';";

                    this.selectedCourseID = Convert.ToString(command.ExecuteScalar());
                    CourseIDText.Text = selectedCourseID;
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (sqlConnection != null)
                        sqlConnection.Close();
                }
            }

        }

       
        private void UpdateCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateCategoryComboBox.Text != "")
            {

                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();

                    SqlCommand command = sqlConnection.CreateCommand();
                    command.CommandText = "select ID from Category where name = '" + UpdateCategoryComboBox.Text + "';";
                    this.selectedCategoryID = Convert.ToString(command.ExecuteScalar());
                    CategoryIDText.Text = selectedCategoryID;
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (sqlConnection != null)
                        sqlConnection.Close();
                }
            }

        }
        private void BackClickButton(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage(loggedID).ShowDialog();
            this.Dispose();
        }

    }
}
