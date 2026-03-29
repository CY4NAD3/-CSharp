using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _42_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //polymorphism = Greek word that means to "have many forms"
            //               Objects can be identified by more than one type
            //               Ex.A Dog is also: Canine, Animal, Organism

            Vehicle car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //Car[] vehicles = { car, bicycle, boat }; not allowed

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.go();
            }

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public virtual void go()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }
    class Car : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The car is moving");
        }

    }
    class Bicycle : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The bicycle is moving");
        }

    }
    class Boat : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The boat is moving");
        }

    }
}
