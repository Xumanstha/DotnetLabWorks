using LabWorks_11_12_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorks_11_12_13
{
   public class EmployeeUpdaterEF
    {
        public static void IncrementExperience(string employeeName)
        {
            using (var context = new AppDbContext())
            {
                var employee = context.Employees
                    .FirstOrDefault(e => e.Name == employeeName);

                if (employee == null)
                {
                    Console.WriteLine($"No employee found with name '{employeeName}'.");
                    return;
                }

                employee.Experience += 1;
                context.SaveChanges();

                Console.WriteLine($"{employee.Name}'s experience updated to {employee.Experience}.");
            }
        }
    }
}
