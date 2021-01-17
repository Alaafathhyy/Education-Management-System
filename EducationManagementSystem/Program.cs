using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static SqlConnection openConnection()
        {
           SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-EB22A1S;Initial Catalog=MyDatabase;Integrated Security=True");
           sqlConnection.Open();
           return sqlConnection;
        }

        
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
