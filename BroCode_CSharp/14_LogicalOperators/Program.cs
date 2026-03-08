using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // logical operators = can be used to check if more than 1 condition is true/false

            //&& = AND operator (both conditions must be true)
            //|| = OR operator (one of the conditions must be true)

            Console.WriteLine("What is the temperature outside? (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("The temperature is warm!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Do not go outside!");
            }
        }
    }
}
