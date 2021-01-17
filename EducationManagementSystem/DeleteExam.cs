using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class DeleteExam : Form
    {
        private string loggedID = null;
        public DeleteExam(string loggedID)
        {
            InitializeComponent();
            this.loggedID = loggedID;
            new UpdateExam(loggedID).ShowExamIDMenu(examID , this.loggedID);
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (examID.Text != "")
            {
                SqlConnection sqlConnection = null;
                try
                {
                    sqlConnection = Program.openConnection();
                    SqlCommand command = sqlConnection.CreateCommand();
                    
                    command.CommandText = "Delete from exam where id =" + examID.Text + ";";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Exam has been deleted");
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
