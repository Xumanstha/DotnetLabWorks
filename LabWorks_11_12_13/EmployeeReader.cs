using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // or System.Data.SqlClient depending on your project

namespace LabWorks_11_12_13
{
    public class EmployeeReader
    {
        private string connectionString =
    @"Server=LAPTOP-M0KH8SF3\SQLEXPRESS;
      Database=EmployeeDB;
      Trusted_Connection=True;
      TrustServerCertificate=True;";

        public void GetActiveEmployees()
        {
            string query = "SELECT Name, Salary FROM Employee WHERE IsResigned = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Active Employees:");
                    Console.WriteLine("------------------");

                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        decimal salary = Convert.ToDecimal(reader["Salary"]);

                        Console.WriteLine($"Name: {name}, Salary: {salary:C}");
                    }
                }
            }
        }
    }
}



