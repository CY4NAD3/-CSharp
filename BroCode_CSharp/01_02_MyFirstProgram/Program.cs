using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args) // main method
        {   //main method body
            Console.WriteLine("I like pizza!");
            Console.WriteLine("It's really good!");
            Console.Beep();

            Console.Write("Hey!!");
            Console.WriteLine("Hello!!!"); //String literal

            //This is a comment
            /* This is a multi-line comment
             * It can span multiple lines
             * It is useful for longer explanations or documentation
             */

            //Escape sequences
            Console.WriteLine("\tBroCode");
            Console.WriteLine("Bro\bCode");
            Console.WriteLine("\tBro\bCode");
            Console.WriteLine("Bro\nCode");
            Console.WriteLine("Bro\\Code");

            Console.ReadKey();
        }
    }
}
