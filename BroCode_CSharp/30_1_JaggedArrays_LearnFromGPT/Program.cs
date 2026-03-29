using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_1_JaggedArrays_LearnFromGPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultiDim array

            //Declaration:
            //string[,] parkingLot = new string[3, 3];
            //3 rows
            //3 columns

            //Perfect Grid. Every row has exactly the same number of columns.
            //[ ][ ][ ]
            //[ ][ ][ ]
            //[ ][ ][ ]s

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     {"Corvette", "Camaro","Silverado"},
                                     {"Corolla", "Camry", "Rav4"}
                                   };

            parkingLot[2, 0] = "Tacoma";

            for (int i = 0; i < parkingLot.GetLength(0); i++)       //parkingLot.GetLength(0) for rows
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)    //parkingLot.GetLength(1) for columns
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("====================================================================================================");
            //Jagged Arrays = A jagged array is an array of arrays.

            //Declaration:
            string[][] cars = new string[3][];
            //                           ↑ this creates 3 rows (outer array)
            //                           but each row is empty/null

            //3 rows
            //but each row can have different length

            //size: [only do 1, size |or| size + values] [We use this size methos to take input or initialize each one indiv]
            cars[0] = new string[4];
            //                   ↑ this creates 4 columns for row 0 (inner array)

            cars[1] = new string[2];
            //                   ↑ row 1 has 2 columns

            cars[2] = new string[5];
            //                   ↑ row 2 has 5 columns

            //size + values together:
            cars[0] = new string[] { "Allion", "Camry", "BMW", "Audi" };
            cars[1] = new string[] { "Corolla", "Ferrari"};
            cars[2] = new string[] { "Rav4", "Tacoma", "Honda", "Lexus", "Mazda"};

            //Memory looks like:
            //[ ][ ][ ][ ]
            //[ ][ ]
            //[ ][ ][ ][ ][ ]
            //Not a rectangle anymore

            //string[][] parkingLot = new string[3][];
            //parkingLot[0][0] = "Allion"; // ❌ CRASH, inner array not initialized yet

            cars[0][3] = "Mercedes"; 

            for(int i = 0; i < cars.Length; i++)
            {
                for (int j = 0; j < cars[i].Length; j++)
                {
                    Console.Write(cars[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            
            Console.WriteLine("====================================================================================================");
            //Initialize Jagged Arrays 3 ways

            //Way 1 — declare then assign: 
            int[][] jaggedArray1 = new int[3][];
            jaggedArray1[0] = new int[] { 1, 2 };       //Semi colon
            jaggedArray1[1] = new int[] { 1, 2, 3, 4 };
            jaggedArray1[2] = new int[] { 1, 2, 3 };

            //Way 2 — inline initialization:
            int[][] jaggedArray2 = new int[][]
            {
                new int[]{1, 2},      //commas
                new int[]{1, 2, 3, 4},
                new int[]{1, 2, 3}
            };

            //Way 3 — shortest way:
            int[][] jaggedArray3 =
            {
                new int[]{1, 2},     //commas
                new int[]{1, 2, 3, 4},
                new int[]{1, 2, 3}
            };

            //Accessing:

            Console.WriteLine(jaggedArray1[1][2]); // row 1, index 2 → prints 3
           //                           ↑ row  ↑ element
            Console.WriteLine(jaggedArray2[1][2]);
            Console.WriteLine(jaggedArray3[1][2]);


            Console.ReadKey();
        }
    }
}
