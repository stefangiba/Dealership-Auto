using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Auto.Repository
{
    public class BaseRepository
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=DealershipAuto;Integrated Security=True;"; // Conexiunea la baza de date

        //Functie care executa interogarile si returneaza un DataTable care este mai apoi prelucrat
        protected DataTable ExecuteQuery(string queryString)
        {
           var dataTable = new DataTable();
           using (SqlConnection connection =
           new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    // this will query your database and return the result to your datatable
                    da.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error reported by SQL Server, " + ex.Message);
                }
            }
            return dataTable;
        }
    }
}
