using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Your name is "+inputName);
            Console.ReadLine();
        }
    }
}
