using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _47_AutoImplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for a property,
            //                               you only have to write get; and/or set; inside the property

            Car car = new Car("Porche");

            car.Model = "Lambo";

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {
        //private string model;

        //public string Model{
        //    get { return model; }
        //    set
        //    {
        //        model = value;
        //    }
        //}

        public String Model {  get; set; }
        public Car(String model)
        {
            this.Model = model;
        }

    }
}
