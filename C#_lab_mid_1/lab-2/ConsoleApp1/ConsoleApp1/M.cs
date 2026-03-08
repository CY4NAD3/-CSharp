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
            Car c1 = new Car();
            c1.setLid(101);
            c1.setModel("Phantom");
            c1.setCc(40000);


            Console.WriteLine("Car id: " + c1.getLid());
            Console.WriteLine("Car model: " + c1.getModel());
            Console.WriteLine("Car CC: " + c1.getCc());
            c1.printDetails();
            Console.ReadKey();
        }




    }
}
