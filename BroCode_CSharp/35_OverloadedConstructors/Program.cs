using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _35_OverloadedConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overloaded constructors = technique to create multiple constructors,
            //                          with a different set of parameters.
            //                          name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");


            Console.ReadKey();
        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;            
        }
        public Pizza(string bread)
        {
            this.bread = bread;                     
        }
    }
}
