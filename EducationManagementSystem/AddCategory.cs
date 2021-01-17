using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class AddCategory : Form
    {
        private string loggedID = null;
        public AddCategory(string loggedID)
        {
            this.loggedID = loggedID;
            InitializeComponent();
        }

        private void AddCategoryClick(object sender, EventArgs e)
        {
            string ErrorMsg = "Please Fill in the Category Name Field";
            SqlConnection sqlConnection = null;
            try
            {
                if (CategoryNameText.Text == "")
                    throw new Exception(ErrorMsg);
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                
                command.CommandText = "insert into category (name) values ('" +  CategoryNameText.Text + "');";
                command.ExecuteNonQuery();
                MessageBox.Show("Category has been added Successfully");
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

        private void BackClickButton(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage(loggedID).ShowDialog();
            this.Dispose();
        }
    }
}
