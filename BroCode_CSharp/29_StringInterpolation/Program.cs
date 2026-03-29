using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {   //string interpolation = allows us to insert variables into a string literal
            //                       precede a string literal with $
            //                       {} are placeholders

            string firstName = "Azraf";
            string lastName = "Alam";
            int age = 21;

            Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine();

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age, -10} years Old");

            Console.ReadKey();
        }
    }
}
