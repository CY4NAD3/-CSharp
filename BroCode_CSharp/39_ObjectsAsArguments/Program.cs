using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ObjectsAsArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "Red");

            Console.WriteLine(car1.color + " " + car1.model);

            changeColor(car1, "Silver");

            Console.WriteLine(car1.color + " " + car1.model);


            Console.ReadKey();
        }

        public static void changeColor(Car car, string color)
        {
            car.color = color;
        }
    }

    class Car
    {
        public string model;
        public string color;
        public Car(String model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
