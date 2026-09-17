using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LabWorks_11_12_13
{
    public class EmployeeWriter
    {
        private string connectionString =
    @"Server=LAPTOP-M0KH8SF3\SQLEXPRESS;
      Database=EmployeeDB;
      Trusted_Connection=True;
      TrustServerCertificate=True;";

        public void InsertEmployee(string name, decimal salary, string department, bool isResigned, int experience)
        {
            string query = @"INSERT INTO Employee (Name, Salary, Department, IsResigned, Experience) 
                          VALUES (@Name, @Salary, @Department, @IsResigned, @Experience)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@IsResigned", isResigned);
                command.Parameters.AddWithValue("@Experience", experience);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine(rowsAffected > 0
                    ? "Employee inserted successfully."
                    : "Insert failed.");
            }
        }
    }
}



