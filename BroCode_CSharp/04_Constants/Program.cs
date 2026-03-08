using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constants = immutable values which are known at compile time 
            //and do not change for the life of the program

            const double pi = 3.13159;

            //pi = 420;

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}
