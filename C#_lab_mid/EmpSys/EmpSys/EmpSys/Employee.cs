using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSys
{
    internal class Employee
    {
        private int id;
        private string name;
        private string dept;

        public void setiD(int id)
        {
            this.id = id;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setDept(String dept)
        {
            this.dept = dept;
        }

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getDept()
        {
            return dept;
        }

        public Employee() { 
            this.id = 0;
            this.name= null;
            this.dept= null;
        }
        public Employee(int id, string name, string dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
        public void print()
        {
            Console.WriteLine("Id: " + getId());
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Department: " + getDept());
        }
    }
}

