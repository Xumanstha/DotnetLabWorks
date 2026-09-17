using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LabWorks_11_12_13
{
    public class EmployeeDataSetHandler
    {
        private string connectionString =
@"Server=LAPTOP-M0KH8SF3\SQLEXPRESS;
      Database=EmployeeDB;
      Trusted_Connection=True;
      TrustServerCertificate=True;";

        public DataSet LoadEmployeeData()
        {
            string query = "SELECT * FROM Employee";
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataSet, "Employee");
            }

            DataTable table = dataSet.Tables["Employee"];

            Console.WriteLine("Employee Data:");
            Console.WriteLine("--------------");

            foreach (DataRow row in table.Rows)
            {
                string name = row["Name"].ToString();
                string department = row["Department"].ToString();
                int experience = Convert.ToInt32(row["Experience"]);

                Console.WriteLine($"Name: {name}, Department: {department}, Experience: {experience}");
            }

            return dataSet;
        }
    }
}
