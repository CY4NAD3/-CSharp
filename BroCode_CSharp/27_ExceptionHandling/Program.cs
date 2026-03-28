using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _27_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exception = errors that occur during execution

            //try       = try some code that is considered "dangerous"
            //catch     = catches and handles exceptions when they occur
            //finally   = always executes regardless if exception is caught or not

            double x, y, result;
            //int x, y, result;
            try
            {
                Console.WriteLine("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());
                //x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());
                //y = int.Parse(Console.ReadLine());

                result = x / y;
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Enter only numbers please");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by 0! Idiot!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }

            Console.ReadKey();
        }
    }
}
