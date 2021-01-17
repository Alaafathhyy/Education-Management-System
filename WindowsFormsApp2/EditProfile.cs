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


namespace WindowsFormsApp2
{
    public partial class EditProfile : Form
    {
        private string loggedID = null;
        private string table = null;

        public EditProfile(string loggedID, Boolean isStudent)
        {
            this.loggedID = loggedID;
            if (isStudent)
                table = "Student";
            else
                table = "Instructor";

            InitializeComponent();
            InintialData();
        }
        
        private void InintialData()
        {
            IDText.Text = this.loggedID;
            SqlConnection sqlConnection = null;
            SqlDataReader dataReader = null;
            try
            {
                sqlConnection = Program.openConnection();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "Select mail, name, mobile, password from " + table + " where ID = " + this.loggedID + ";";

                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    EmailText.Text = Convert.ToString(dataReader.GetValue(0));
                    NameText.Text = Convert.ToString(dataReader.GetValue(1));
                    MobileText.Text = Convert.ToString(dataReader.GetValue(2));
                    PasswordText.Text = Convert.ToString(dataReader.GetValue(3));
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
                if (dataReader != null)
                    dataReader.Close();
            }
        }
        private void SaveUpdatesClick(object sender, EventArgs e)
        {
            string ErrorMsg = "Please Fill in all the Fields Correctly";
            SqlConnection sqlConnection = null;
            try
            {
               if (EmailText.Text == "" || NameText.Text == "" || MobileText.Text == "" || PasswordText.Text == "")
                  throw new Exception(ErrorMsg);
               sqlConnection = Program.openConnection();
               SqlCommand command = sqlConnection.CreateCommand();

               command.CommandText = "update " + table + " set name = '" + NameText.Text + "', mail = '" + EmailText.Text + "', mobile = '"
                                    + MobileText.Text + "', password = '" + PasswordText.Text + "' where ID = " + this.loggedID;
 
               command.ExecuteNonQuery();
               sqlConnection.Close();

                MessageBox.Show("Your profile has been successfully updated ");
                this.Hide();
                new HomePage(loggedID).ShowDialog();
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
            new HomePage(loggedID).ShowDialog();
            this.Dispose();
        }
    }     
}
