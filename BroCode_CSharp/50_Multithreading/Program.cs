using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _50_Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program        
            //          We can use multiple threads to perform,
            //          different tasks of our program at the same time.           
            //          Current thread running is "main" thread
            //          using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            CountDown();
            CountUp();

            Console.WriteLine(mainThread.Name + " is complete");

            Console.ReadKey();
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
