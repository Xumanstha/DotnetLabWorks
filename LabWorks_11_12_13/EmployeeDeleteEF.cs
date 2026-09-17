using LabWorks_11_12_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorks_11_12_13
{
   public class EmployeeDeleterEF
    {
        public static void DeleteEmployee(int id)
        {
            using (var context = new AppDbContext())
            {
                var employee = context.Employees.Find(id);

                if (employee == null)
                {
                    Console.WriteLine($"No employee found with Id {id}.");
                    return;
                }

                context.Employees.Remove(employee);
                context.SaveChanges();

                Console.WriteLine($"Employee with Id {id} deleted.");
            }
        }
    }
}
