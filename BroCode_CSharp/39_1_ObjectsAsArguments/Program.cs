using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_1_ObjectsAsArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "Red");
            Car car2 = Copy(car1);
            

            Console.WriteLine(car2.color + " " + car2.model);


            Console.ReadKey();
        }
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
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
