using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
            this.Dispose();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            string ErrorMsg = "This user is not registered";
            SqlConnection sqlConnection = null;
            try
            {
                if (PasswordText.Text == "")
                    throw new Exception(ErrorMsg);
                if (IDText.Text == "")
                    throw new Exception(ErrorMsg);

                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();

                command.CommandText = "Select count(*) from  (Select id , name , password FROM [Student] WHERE  (Student.ID = '" + IDText.Text + "' and Student.password = '" + PasswordText.Text + "')"
                               + " UNION " +
                               "SELECT id , name , password FROM  [instructor] WHERE (instructor.ID = '" + IDText.Text + "' and instructor.password = '" + PasswordText.Text + "')" +
                               ") AS CountTable";

                Int32 count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                {
                    throw new Exception(ErrorMsg);
                }
                sqlConnection.Close();
                this.Hide();
                new HomePage(IDText.Text).ShowDialog();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
    }
}
