using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _15_While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats a block of code while a specified condition is true

            String name = "";

            while (name == "") {
                Console.Write("Enter a name: ");
                name = Console.ReadLine();
            }

            //while (1 == 1) {
            //    Console.Write("Infinite loop");   
            //}

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
