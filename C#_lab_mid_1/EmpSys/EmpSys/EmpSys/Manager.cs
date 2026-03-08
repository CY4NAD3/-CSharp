using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmpSys
{
    internal class Manager : Employee
    {
        private string rank;
        private float salary;

        public void setRank(string rank)
        {
            this.rank = rank;
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
        public string getRank()
        {
            return rank;
        }
        public float getSalary()
        {
            return salary;
        }
        public Manager()
        {
            this.rank = null;
            this.salary = 0;
        }

        public Manager(int id, string name, string dept, string rank, float salary) : base(id, name, dept)
        {
            base.setiD(id);
            base.setName(name);
            base.setDept(dept);
           
            
            this.rank = rank;
            this.salary = salary;
        }

        public void print()
        {
            base.print();
            Console.WriteLine("Rank: " + getRank());
            Console.WriteLine("Salary: " + getSalary());
        }
    }
}

