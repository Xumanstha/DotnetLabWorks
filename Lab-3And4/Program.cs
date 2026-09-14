using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3And4
{
    internal class Program
    {
        public delegate void MessageHandler();

        // 2. Create two methods
        static void ShowWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static void ShowGoodbye()
        {
            Console.WriteLine("Goodbye! Have a nice day!");
        }
        static void Main(string[] args)
        {
            //// 3. Single-cast delegate
            //// Delegate points only to ShowWelcome()
            //MessageHandler message = ShowWelcome;

            //Console.WriteLine("Single-cast Delegate:");
            //message();

            //// 4. Multi-cast delegate
            //// Add ShowGoodbye() to the delegate
            //message += ShowGoodbye;

            //Console.WriteLine("\nMulti-cast Delegate:");
            //message();

            //// 5. Remove ShowWelcome()
            //// Only ShowGoodbye() remains
            //message -= ShowWelcome;

            //Console.WriteLine("\nAfter Removing ShowWelcome():");
            //message();
            Lab_4 example= new Lab_4();
            //Console.ReadKey();

        }
    }
}
