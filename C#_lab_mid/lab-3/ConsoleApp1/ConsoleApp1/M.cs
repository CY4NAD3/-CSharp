using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class M
    {
        static void Main(string[] args)
        {

            //default constructor
            Person p1 = new Person();
            p1.setId(1);
            p1.setName("Rahim");
            p1.setSalary(200);
            p1.printDetails();

            //parameterized constructor
            Person p2 = new Person(2, "Karim", 300);
            p2.printDetails();

            Manager m1 = new Manager(2, "asad", 400, 5);
            m1.printDetails();

           Manager m2 = new Manager(3, "sadaf", 500, 6);
           m2.printDetailsp();



            Console.ReadKey();
        }




    }
}
