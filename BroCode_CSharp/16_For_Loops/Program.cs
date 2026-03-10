using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loops = execute a block of code a FINITE number of times

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
