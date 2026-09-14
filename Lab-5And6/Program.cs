using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5And6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Ram Sharma",
                    Salary = 45000,
                    Department = "IT",
                    IsResigned = false,
                    Experience = 2
                },

                new Employee
                {
                    Name = "Sita Thapa",
                    Salary = 60000,
                    Department = "HR",
                    IsResigned = false,
                    Experience = 4
                },

                new Employee
                {
                    Name = "Hari Karki",
                    Salary = 75000,
                    Department = "IT",
                    IsResigned = false,
                    Experience = 6
                },

                new Employee
                {
                    Name = "Gita Poudel",
                    Salary = 50000,
                    Department = "Finance",
                    IsResigned = true,
                    Experience = 3
                },

                new Employee
                {
                    Name = "Bikash Adhikari",
                    Salary = 90000,
                    Department = "IT",
                    IsResigned = false,
                    Experience = 8
                },

                new Employee
                {
                    Name = "Anita KC",
                    Salary = 55000,
                    Department = "Marketing",
                    IsResigned = false,
                    Experience = 3
                },

                new Employee
                {
                    Name = "Suman Gurung",
                    Salary = 70000,
                    Department = "Finance",
                    IsResigned = true,
                    Experience = 5
                },

                new Employee
                {
                    Name = "Prakash Rai",
                    Salary = 40000,
                    Department = "Sales",
                    IsResigned = false,
                    Experience = 1
                },

                new Employee
                {
                    Name = "Mina Shrestha",
                    Salary = 85000,
                    Department = "HR",
                    IsResigned = false,
                    Experience = 7
                },

                new Employee
                {
                    Name = "Dipak Bista",
                    Salary = 65000,
                    Department = "Sales",
                    IsResigned = true,
                    Experience = 4
                }
            };
            var activeEmployees = employees
            .Where(e => e.IsResigned == false)
            .ToList();
            Console.WriteLine("All The Active Employees:");
            foreach (var item in activeEmployees)
            {
                Console.WriteLine(item.Name);
            }

            var sortedEmployees = employees
            .OrderByDescending(e => e.Salary)
            .ToList();

            Console.WriteLine("Sorted by descending order of salary:");
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }

            var departments = employees
            .Select(e => e.Department)
            .Distinct()
            .ToList();

            Console.WriteLine("All the Departments:");
            foreach (var department in departments)
            {
                Console.WriteLine(department);
            }
            bool hasZeroExperience = employees
            .Any(e => e.Experience == 0);

            Console.WriteLine(hasZeroExperience);

            var result = employees
            .Select(e => new
             {
                    e.Name,
                    e.Salary
                })
                .ToList();
            foreach (var employee in result)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }
        }
    }
}
