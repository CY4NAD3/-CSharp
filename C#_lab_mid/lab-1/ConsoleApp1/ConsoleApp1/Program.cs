using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct students
    {
        public int id;
        public string name;
        public int age;
    }

    enum weekdays
    {
        sat,sun,mon,
        tue,
        wed,
        thu
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("asdf");
             Console.WriteLine("1234");

             int a = 9;
             float b = 3.4f;
             double c = 6.6;
             string d = "Hi there";

             Console.WriteLine("Integer value:{2} {0} {1}", b,c,a);
             Console.WriteLine("Double value:" + c + " " + d + " " + a);
             Console.WriteLine($"d is: {d}");



             Console.Write("Enter your name:");
             string aa = Console.ReadLine();
             Console.WriteLine("Inserted name:" + aa);

             Console.Write("Enter your age:");
             int bb = int.Parse(Console.ReadLine());
             Console.WriteLine("Inserted age:" + bb);

             Console.WriteLine("Enter your salary");
             float cc = float.Parse(Console.ReadLine());
             Console.WriteLine("Inserted salary:" + cc);

             Console.WriteLine("Enter your salary");
             double dd = double.Parse(Console.ReadLine());
             Console.WriteLine("Inserted salary:" + dd);   */


            /*     //condition

                 int a = 10;

                 if (a > 18)
                 {
                     Console.WriteLine("Good");
                 }
                 else if (a == 10)
                 {
                     Console.WriteLine("Neutral");
                 }
                 else
                 {
                     Console.WriteLine("Bad");
                 }

                 int b = 2;

                 switch (b)
                 {
                     case 1:
                         Console.WriteLine("one");
                         break;
                     case 2:
                         Console.WriteLine("two");
                         break;
                     default:
                         Console.WriteLine("none");
                         break;
                 }  */

            /*  //loop
              int i;
              for (i = 0; i <= 5; i++)
              {
                  Console.WriteLine(i);
              }
              while (i < 10)
              {
                  Console.WriteLine(i);
                  i++;
              }
              do
              {
                  Console.WriteLine(i);
                  i++;
              } while (i < 15);   

            
            string[] students = new string[5];
            int i;
            Console.WriteLine("Enter students:");
            for (i = 0; i < 5; i++)
            {
                students[i] = Console.ReadLine();
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("5: " + students[i]);
            }

            for (i = 0; i < students.Length; i++)
            {
                Console.WriteLine("5: " + students[i]);
            }

            foreach (string s in students)
            {
                Console.WriteLine("foreach: " + s);
            }

            foreach (var s in students)
            {
                Console.WriteLine("foreach: " + s);
            }


            var a = 2;
            var b = 3.3;
            var c = "Hll";

            Console.WriteLine("int: " + a);
            Console.WriteLine("double: " + b);
            Console.WriteLine("string: " + c);   


            int[][] jg = new int[4][];
            jg[0] = new int[] { 1, 2, 3, 4 };
            jg[1] = new int[] { 2, 3, 4 };
            jg[2] = new int[] { 3 };
            jg[3] = new int[] { 4,7,8 };
            for (int i = 0; i < jg.Length; i++)
            {
                for (int j = 0; j < jg[i].Length; j++)
                {
                    Console.Write(jg[i][j] + " ");
                }
                Console.WriteLine();
            }


            students s;
            s.id = 1;
            s.name = "Neymar";
            s.age = 31;

            Console.WriteLine(s.id);
            Console.WriteLine(s.name);
            Console.WriteLine(s.age);  */


            Console.WriteLine(weekdays.sat);
            Console.WriteLine(weekdays.sun);

            Console.WriteLine((int)weekdays.sat);
            Console.WriteLine((int)weekdays.sun);










            Console.ReadKey();
        }
    }
}
