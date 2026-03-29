using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional operator = used in conditional assignment if a condition is true/false

            //(condition)? x : y

            double temperature = 20;
            string message;

            //if(temperature >= 15)
            //{
            //    message = "It's warm outside";
            //}
            //else
            //{
            //    message = "It's cold outside";
            //}
            //Console.WriteLine(message);

            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";
            bool result= (temperature >= 15) ? true : false;

            Console.WriteLine(message);
            Console.WriteLine(result);
            Console.WriteLine((temperature >= 15) ? 1 : 0);

            Console.ReadKey();
        }
    }
}
