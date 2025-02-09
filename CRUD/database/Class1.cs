using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace CRUD.database
{
    internal class Class1
    {
        protected SqlConnection connect;
        string connectionString = "Data Source=DESKTOP-VCTIH2D\\SQLEXPRESS;Initial Catalog=rauf;Integrated Security=True;TrustServerCertificate=True;";

        protected async Task OpenConnectionAsync()
        {
            try
            {
                connect = new SqlConnection(connectionString);
                await connect.OpenAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("theres an errxxxor" + e.Message);
            }
        }
        protected void CloseConnection()
        {
            if (connect != null)
            {
                connect.Close();  
                connect.Dispose(); 
            }
        }
    }



}

