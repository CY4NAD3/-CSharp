using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields and methods (characteristics and actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name= "Rick";
            human1.age = 65;

            human2.name= "Morty";
            human2.age = 16;

            human1.eat();
            human1.sleep();

            human2.eat();
            human2.sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
