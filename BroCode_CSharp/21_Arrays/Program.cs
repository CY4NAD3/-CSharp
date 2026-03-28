using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_22_Arrays
{   //21 and 22 videos in this code
    internal class Program
    {
        static void Main(string[] args)
        {
            //array = a variable that can sore multiple values. Fixed size

            //String[] cars = {"BMW", "Toyota", "Honda" };
            //String[] cars = new string[3];
            string[] cars = new string[3];

            cars[0] = "BMW";
            cars[1] = "Toyota";
            cars[2] = "Honda";

            Console.WriteLine(cars[0]);

            for (int i = 1; i < cars.Length; i++) { 
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine();

            cars[0] = "Tesla";
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }
            

            Console.ReadKey();
        }
    }
}
