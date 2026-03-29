using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");
            //Console.WriteLine(car.ToString());
            Console.WriteLine(car);

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
        public override string ToString()
        {
            String message = $"This is a {year} {make} {model}";
            return message;
            //return $"This is a {make} {model}";
        }
    }
}
