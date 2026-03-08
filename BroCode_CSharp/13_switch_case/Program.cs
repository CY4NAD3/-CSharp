using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch = an efficient alternative to many if else statements

            Console.WriteLine("What day is today?");
            String day = Console.ReadLine();
            day = day.ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "tuesday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "wednesday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "thursday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "friday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "saturday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "sunday":
                    Console.WriteLine("Today is " + day);
                    break;
                default:
                    Console.WriteLine("That's not a day.");
                    break;

            }
            Console.ReadKey();
        }
    }
}
