using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3And4
{
    public class Lab_4
    {
        private Action<List<string>> printList = (messages) =>
        {
            foreach (string item in messages)
            {
                Console.WriteLine(item);
            }
        };

        private List<string> names = new List<string>
        {
            "suman",
            "saroj",
            "bibek",
            "bikram",
            "anush",
            "sugam",
            "dhirajan"
        };

        public Lab_4()
        {
            printList(names);
            Console.WriteLine($"The number {names.Count} is {(IsEven(names.Count)?"Even":"Odd")}");
            Console.WriteLine($"The number {names.Count} is {(IsMultipleOf5(names.Count)?"Multiple of 5":"Not the multiple of 5")} ");
        }
        private Func<int,bool> IsEven = (num) =>
        {
            return num % 2 == 0; 
        };

        private Predicate<int> IsMultipleOf5=(num) =>
        {
                return num % 5 == 0; 
        };
    }
}
