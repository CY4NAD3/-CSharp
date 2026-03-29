using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_StaticModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            //Console.WriteLine(car1.numberOfCars); //non-static
            //Console.WriteLine(car2.numberOfCars);
            Console.WriteLine(Car.numberOfCars);
            Car.startRace();



            Console.ReadKey();
        }
    }

    //class can also be static but we won't be able to create objs
    class Car       //We are entering cars in a race
    {
        string model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void startRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
