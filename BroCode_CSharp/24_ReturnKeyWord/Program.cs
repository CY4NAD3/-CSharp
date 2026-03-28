using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ReturnKeyWord
{
    internal class Program
    {
        //return = return data back to the place where method is invoked
        static void Main(string[] args)
        {
            double x, y , result;

            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = multiply(x, y);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static double multiply(double x, double y)
        { 
            return x * y;    
        }
    }
}
