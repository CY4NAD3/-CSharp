using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor = A special method in a class
            //Same name as the class name
            //Can be used to assign arguments to fields when creating an object


            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);
                     
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

        public Human(string name, int age) 
        {
            this.name = name;
            this.age = age;
            
        }

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
