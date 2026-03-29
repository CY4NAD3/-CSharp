using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _44_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List = data structure that represents a list of objects that can be accessed by index.
            //       Similar to array, but can dynamically increase / decrease in size during runtime
            //       using System.Co11ections.Generic;

            //string[] food = new string[3];

            //food[0] = "pizza";
            //food[1] = "burger";
            //food[2] = "hotdog";
            ////food[3] = "fries"; out of bounds
            
            //foreach (string item in food)
            //{
            //    Console.WriteLine(item);
            //}

            List<String> food = new List<string>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("burger");
            food.Add("hotdog");
            food.Add("fries");

            //Console.WriteLine(food[0]);

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            food.Remove("fries");
            food.Insert(0, "sushi");
            
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            food.Insert(0, "fries");

            //food.Sort();
            //food.Reverse();
            //food.Clear();

            Console.WriteLine(food.Count);
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.IndexOf("fries"));
            Console.WriteLine(food.LastIndexOf("fries"));
            Console.WriteLine();

            string[] foodArray = food.ToArray();

            Console.WriteLine("Array:");
            foreach (String item in foodArray)
            {               
                Console.WriteLine(item);
            }         

            Console.ReadKey();
        }
    }
}
