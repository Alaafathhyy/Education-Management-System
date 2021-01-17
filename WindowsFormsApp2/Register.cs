using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            string ErrorMsg = "Please Fill in all the Fields Correctly";
            SqlConnection sqlConnection = null;
            try
            {
                if (mailText.Text == "" || nameText.Text == "" || mobileText.Text == "" || PasswordText.Text == "" || userTypeCheckBox.CheckedItems.Count != 1)
                    throw new Exception(ErrorMsg);

                string table = userTypeCheckBox.SelectedItem.ToString();

                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText =
                           "insert into " + table + "(name , mobile , mail , password ) OUTPUT INSERTED.ID  VALUES ('" 
                           + nameText.Text + "','" + mobileText.Text + "','" + mailText.Text + "' , " + PasswordText.Text + " );";

                string id = Convert.ToString(command.ExecuteScalar());


                sqlConnection.Close();

                MessageBox.Show("You have Successuflly registered, your ID is: [" + id + "]");

                this.Hide();
                new HomePage(id).ShowDialog();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Dispose();
        }
    }
}

