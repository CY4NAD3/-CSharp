using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSys
{
    internal class Start
    {
       public static void Main(string[] args)
        {
            Manager m1 = new Manager();
            //(int id, string name, string dept, string rank, float salary) : base(id, name, dept)
            //Manager m2 = new Manager(22, "Ratul", "HR", "Officer", 200.20f);
            m1.print();
        }
    }
}
