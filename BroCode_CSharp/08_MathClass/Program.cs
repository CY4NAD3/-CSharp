using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14;  //3,14, -3, -3.14
            double y = 5;

            //double a = Math.Pow(x, 3);
            //double b = Math.Sqrt(x);
            //double c = Math.Abs(x);
            //double d = Math.Round(x);
            //double e = Math.Ceiling(x); //rounded up
            //double f = Math.Floor(x); //rounded down
            //double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
