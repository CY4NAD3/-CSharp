using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type casting = Converting a data type to another data type
            //               useful when we accept user input (string)
            //               types of casting: implicit and explicit
            //               Different data types can do different things

            double a = 3.50;
            int b1 = Convert.ToInt32(a); //(Round) Convert Methods are
                                         //used to convert a data type to another data type
            int b2 = (int)a; //(Trunc)explicit casting 
                             //(manually converting a data type to another data type)
            int c = 123;
            double d = Convert.ToDouble(c) + 0.1; // to display a decimal point we add

            int e = 321;
            String f = e.ToString(); //to convert a number to a string
                                     //we use ToString() method

            String g = "$";
            char h = Convert.ToChar(g); //to convert a string to a char
                                        //we use Convert.ToChar() method

            String i = "True";
            bool j = Convert.ToBoolean(i); //to convert a string to a boolean
                                           //we use Convert.ToBoolean() method


            Console.WriteLine(a);
            Console.WriteLine(a.GetType()); //returns data type of variable

            Console.WriteLine(b1);
            Console.WriteLine(b1.GetType());

            Console.WriteLine(b2);
            Console.WriteLine(b2.GetType());

            Console.WriteLine(c.GetType());

            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            Console.WriteLine(g.GetType());
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());

            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}
