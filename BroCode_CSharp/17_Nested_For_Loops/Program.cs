using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Nested_For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested for loops = one loop inside another loop
            //                    Uses vary, Used a lot in sorting algos

            Console.Write("How many rows? :");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("How many columns? :");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("What symbol or character do you want to use? :");
            String symbol = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Normal Triangle
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Alternative code Normal Triangle
            for (int i = rows; i > 0; i--) {
                for (int j = columns; j >= i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
