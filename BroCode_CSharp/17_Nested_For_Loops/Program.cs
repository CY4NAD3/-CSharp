using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.PortableExecutable;
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

            // Right angle left side
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Inverse right angle left side
            for (int i = rows; i > 0; i--) {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            // Right angle right side
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Inverse right angle right side
            for (int i = rows; i > 0; i--)
            {
                for (int k = rows - i; k > 0 ; k--)
                {
                    Console.Write(" ");     
                }
                for (int j = i ; j > 0 ; j--)
                {
                    Console.Write(symbol);  
                }
                Console.WriteLine();    
            }
            Console.WriteLine();
            
            for (int i = 1; i <= rows; i++)
            {
                Console.Write(new String(' ', rows - i));
                Console.Write(new String(Convert.ToChar(symbol), 2 * i - 1));
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int k = 0; k < rows - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i - 1 ; j++)
                {
                    Console.Write(symbol);  
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //diamond
            for (int i = 1; i < rows; i++)
            {
                Console.Write(new String(' ', rows - i));
                Console.Write(new String(Convert.ToChar(symbol), 2 * i - 1));
                Console.WriteLine();
            }for (int i = rows; i > 0; i--)
            {
                Console.Write(new String(' ', rows - i));
                Console.Write(new String(Convert.ToChar(symbol), 2 * i - 1));
                Console.WriteLine();
            }
            Console.WriteLine();
            
            //XO rectangle
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O"); 
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
