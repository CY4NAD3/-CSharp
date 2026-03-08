using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HypotenuseCalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("The hypotenuse (side C) is:");
            Console.WriteLine(c);

            Console.ReadKey();  
        }
    }
}
