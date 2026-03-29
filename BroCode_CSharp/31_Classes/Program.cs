using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class = a bundle of related codes
            //        Can be used as a blueprint to create object (OOP)
            //We can write our class in the same C# file or a diff one
            //To use the methods of Messages class, you can do 2 things:
            // 1) We need to create an obj from this class
            // 2) We can precede the class defn with the keyword static
            //We will do 2) now

            //Math.Round(3.14); //Math class
            //Math.Abs(-3.14);
            //Math.Pow(2, 3);

            Messages.hello();
            Messages.waiting();
            Messages.bye();

            Console.ReadKey();
        }
    }
    
}
