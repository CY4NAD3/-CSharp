using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array.

            double value = checkOut(100.5, 605.2, 99.99, 1.02);
            Console.WriteLine(value);

            Console.ReadKey();
        }

        //static double checkOut(double a)
        //{
        //    return a;
        //}
        //static double checkOut(double a, double b)
        //{
        //    return a + b;
        //}
        // and continue on and on but instead we can use params

        static double checkOut(params double[] prices) 
        {
            double total = 0;

            foreach (double pr in prices)
            {
                total += pr;
            }


            //for (int i = 0; i < prices.Length; i++)
            //{
            //    total += prices[i];
            //}

            return total;
        }

    }
}
