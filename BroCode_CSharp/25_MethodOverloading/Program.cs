using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _25_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading = methods share same name, but different parameters
            //                      name + parameters = signature
            //                      methods must have a unique signature

            double total;

            total = multiply(2, 3, 4);
            Console.WriteLine(total);     

            Console.ReadKey();
        }

        static double multiply(double a, double b)
        {
            return a * b;
        }
        static double multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
