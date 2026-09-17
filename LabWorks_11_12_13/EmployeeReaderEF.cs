using LabWorks_11_12_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorks_11_12_13
{
    public class EmployeeReaderEF
    {
        public static void GetActiveEmployees()
        {
            using (var context = new AppDbContext())
            {
                var activeEmployees = context.Employees
                    .Where(e => e.IsResigned == false)
                    .ToList();

                Console.WriteLine("Active Employees:");
                Console.WriteLine("------------------");

                foreach (var emp in activeEmployees)
                {
                    Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary:C}");
                }
            }
        }
    }
}
