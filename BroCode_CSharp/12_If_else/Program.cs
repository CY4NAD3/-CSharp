using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name: ");
            String name = Console.ReadLine();

            if (name != "") {
                Console.WriteLine("Hello " + name);
                
            }
            else {
                Console.WriteLine("You didn't enter a name.");
            }
            //if (name == "") { 
            //    Console.WriteLine("You didn't enter a name.");
            //}
            //else {
            //    Console.WriteLine("Hello " + name);
            //}



            //if statement = a basic form of decision making.
            //if a condition is true, then some code is executed.

            //Console.WriteLine("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if(age >= 100)
            //{
            //    Console.WriteLine("You are probably dead.");
            //}
            //else if(age < 0)
            //{
            //    Console.WriteLine("You haven't been born yet.");
            //}
            //else if(age >= 18)
            //{
            //    Console.WriteLine("You are an adult.");
            //}
            //else
            //{
            //    Console.WriteLine("You are a child.");
            //}


            Console.ReadKey();
        }
    }
}
