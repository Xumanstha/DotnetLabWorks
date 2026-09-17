using LabWorks_11_12_13.Data;
using LabWorks_11_12_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorks_11_12_13
{
    public class EmployeeWriterEF
    {
        public static void InsertEmployee()
        {
            using (var context = new AppDbContext())
            {
                var newEmployee = new Employee
                {
                    Name = "Emma Watson",
                    Salary = 62000m,
                    Department = "Marketing",
                    IsResigned = false,
                    Experience = 4
                };

                context.Employees.Add(newEmployee);
                context.SaveChanges();

                Console.WriteLine($"Inserted employee with new Id: {newEmployee.EmployeeId}");
            }
        }
    }
}
