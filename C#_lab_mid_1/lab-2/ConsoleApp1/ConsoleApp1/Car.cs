using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {   private int lid;
        private string model;
        private int cc;


        public void setLid(int lid)
        { this.lid = lid; }
        public void setModel(string model)
        { this.model = model; }
        public void setCc(int cc) 
        { this.cc = cc;}




        public int getLid()
        { return lid; }
        public string getModel()
        { return model; }
        public int getCc()
        {   return cc;  }

        public void printDetails()
        {   Console.WriteLine("Car id: " + lid);
            Console.WriteLine("Car model: " + model);
            Console.WriteLine("Car cc:" + cc);
            Console.WriteLine("-------------------");
        }
       /* static void Main(string[] args)
        {   Car c1 = new Car();
            c1.setLid(101);
            c1.setModel("Phantom");
            c1.setCc(40000);
            Console.WriteLine("Car id: " + c1.getLid());
            Console.WriteLine("Car model: " + c1.getModel());
            Console.WriteLine("Car CC: " + c1.getCc()); 
            c1.printDetails();
            Console.ReadKey();
        }

        */






    }
}
