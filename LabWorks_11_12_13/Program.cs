using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorks_11_12_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------Lab-11------------------
            // Task: Retrieve
            //EmployeeReader example = new EmployeeReader();
            //example.GetActiveEmployees();

            // Task: Insert
            //EmployeeWriter example = new EmployeeWriter();
            //example.InsertEmployee("John Smith", 55000m, "IT", false, 3);

            // Task: Load into DataSet
            //EmployeeDataSetHandler example = new EmployeeDataSetHandler();
            //example.LoadEmployeeData();

            // Task: Update via DataSet
            //EmployeeUpdater example =new EmployeeUpdater();
            //example.IncrementExperience("John Smith");

            //---------------Lab-12---------------------
            //EmployeeReaderEF.GetActiveEmployees();
            //EmployeeWriterEF.InsertEmployee();
            //EmployeeUpdaterEF.IncrementExperience("Emma Watson");
            EmployeeDeleterEF.DeleteEmployee(1);
        }
    }
}
