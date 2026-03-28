using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Azraf";
            int age = 21;
            singHappyBirthday(name, age);
            Program.singHappyBirthday(name, age); //same shit
        }

        static void singHappyBirthday(string birthdayBoy, int yearsOld)
        {
            System.Console.WriteLine($"Happy Birthday To {birthdayBoy}!");
            System.Console.WriteLine("Happy Birthday To You!");
            System.Console.WriteLine("Happy Birthday To Dear You!");
            Console.WriteLine("You are {0} years old", yearsOld);
            System.Console.WriteLine("Happy Birthday To You!");
            Console.WriteLine("");
        }
    }
}
