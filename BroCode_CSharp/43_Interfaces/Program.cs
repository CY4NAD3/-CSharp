using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            // An interface declares "what a class should have"
            // An inheriting class defines "how it should do it"

            // Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            rabbit.flee();
            Hawk hawk = new Hawk();
            hawk.hunt();
            Fish fish = new Fish();
            fish.flee();
            fish.hunt();



            Console.ReadKey();
        }
    }
    interface IPrey
    {
        void flee();

    }
    interface IPredator
    {
        void hunt();
    }
    class Rabbit : IPrey
    {
        public void flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }
    class Hawk : IPredator
    {
        public void hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void flee()
        {
            Console.WriteLine("The fish swims away");            
        }
        public void hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish for food");
        }
    }
}
