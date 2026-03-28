using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("___________________");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("___________________");

                Console.WriteLine("Enter Number 1:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number 2:");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t + : Add");
                Console.WriteLine("\t - : Subtract");
                Console.WriteLine("\t * : Multiply");
                Console.WriteLine("\t / : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
                Console.WriteLine("Would you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Bye");
            Console.ReadKey();          
        }
    }
}
