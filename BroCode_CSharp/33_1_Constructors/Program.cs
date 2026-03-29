using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_1_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor = A special method in a class
            //Same name as the class name
            //Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            car1.drive();

            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            car2.drive();

            Console.ReadKey();
        }
    }
    
    class Car
    {
        String make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public void drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}
