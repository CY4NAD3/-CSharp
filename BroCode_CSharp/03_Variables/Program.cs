using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 233; //initialization

            int y = 321; //declaration and initialization

            int z = x + y; //declaration, initialization and assignment

            int age = 21;

            double height = 300.5;

            bool alive = false;

            char symbol = '@';

            String name = "Azraf";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height);
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);

            String username = symbol + name;
            Console.WriteLine("Your username is " + username);

            Console.ReadKey();
        }
    }
}