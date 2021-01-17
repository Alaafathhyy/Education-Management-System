using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ShowListOfStudents : Form
    {
        private string loggedID = null;


        public ShowListOfStudents(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
        }

        private void showClick(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                bool first = true;
                string sqlcommad = "Select name from course ";
                if (semesterText.Text != "")
                {
                    if (first) sqlcommad += "where semester = " + semesterText.Text;
                    first = false;
                }
                if(yearText.Text != "")
                {
                    if (!first) sqlcommad += " and year = " + yearText.Text;
                    else sqlcommad += "where year = " + yearText.Text;
                    first = false;
                }
                if(categoryIDText.Text != "")
                {
                    if (!first) sqlcommad += " and category_id = " + categoryIDText.Text;
                    else sqlcommad += "where category_id = " + categoryIDText.Text;
                }

                command.CommandText = sqlcommad;
                SqlDataReader sqlReader = command.ExecuteReader();

                dataGridView1.Columns[0].HeaderText = "Course Name";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                while (sqlReader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    DataGridViewRow row = this.dataGridView1.Rows[index];
                    row.Cells[0].Value = sqlReader.GetValue(0);      
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

        private void backClick(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage(loggedID).ShowDialog();
            this.Dispose();
        }
    }
}
