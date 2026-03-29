using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_MultidimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proper grid
            //String[] ford   = {"Mustang", "F-150", "Explorer"};
            //String[] chevy  = {"Corvette", "Camaro", "Silverado"};
            //String[] toyota = {"Corolla", "Camry", "Rav4"};

            //string[,] parkingLot = new string[3, 3];

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     {"Corvette", "Camaro", "Silverado"},
                                     {"Corolla", "Camry", "Rav4"}
                                   };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
                                                                    //parkingLot.Length is for 1D arrays    
            for (int i = 0; i < parkingLot.GetLength(0); i++)       //parkingLot.GetLength(0) for rows
            { 
                for (int j = 0; j < parkingLot.GetLength(1); j++)    //parkingLot.GetLength(1) for columns
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                Console.WriteLine();
            }

            //foreach(String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            Console.ReadKey();
        }
    }
}
