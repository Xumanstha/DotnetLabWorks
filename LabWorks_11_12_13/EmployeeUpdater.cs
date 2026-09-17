using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LabWorks_11_12_13
{
   public class EmployeeUpdater
    {
        private string connectionString =
@"Server=LAPTOP-M0KH8SF3\SQLEXPRESS;
      Database=EmployeeDB;
      Trusted_Connection=True;
      TrustServerCertificate=True;";

        public void IncrementExperience(string employeeName)
        {
            string query = "SELECT * FROM Employee";
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(query, connection);

                // CommandBuilder auto-generates INSERT/UPDATE/DELETE commands
                // based on the SELECT query, as long as the table has a primary key
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Fill(dataSet, "Employee");

                DataTable table = dataSet.Tables["Employee"];
                DataRow[] matchingRows = table.Select($"Name = '{employeeName}'");

                if (matchingRows.Length == 0)
                {
                    Console.WriteLine($"No employee found with name '{employeeName}'.");
                    return;
                }

                foreach (DataRow row in matchingRows)
                {
                    int currentExperience = Convert.ToInt32(row["Experience"]);
                    row["Experience"] = currentExperience + 1;
                }

                // Push the in-memory changes back to the database
                int updatedRows = adapter.Update(dataSet, "Employee");

                Console.WriteLine($"{updatedRows} row(s) updated for '{employeeName}'.");
            }
        }
    }
}


