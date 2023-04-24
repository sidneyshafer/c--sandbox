using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged Array - an array within an array

            //      index :                 0   1    2    3
            // normal array of type int : [15],[21],[23],[13]
            //      index :                  0                      1                      2    
            // jagged array of type int : [array1([15],[13],[2])],[array2([7],[8],[5])],[array3([2],[4],[1])]


            // Declare jagged array
            int[][] jaggedArray = new int[3][];

            // Add values
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 10, 5 };

            // Alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 5, 6 },
                new int[] { 2, 3, 4 },
            };

            // Access values
            Console.WriteLine("The 1st value in entry 1 is {0}", jaggedArray2[0][0]);
            Console.WriteLine("The 2nd value in entry 1 is {0}", jaggedArray2[0][1]);
            Console.WriteLine("The 3rd value in entry 1 is {0}", jaggedArray2[0][2]);
            Console.WriteLine("The 4th value in entry 1 is {0}", jaggedArray2[0][3]);
            Console.WriteLine("The 5th value in entry 1 is {0}", jaggedArray2[0][4]);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("The 1st value in entry 2 is {0}", jaggedArray2[1][0]);
            Console.WriteLine("The 2nd value in entry 2 is {0}", jaggedArray2[1][1]);
            Console.WriteLine("The 3rd value in entry 2 is {0}", jaggedArray2[1][2]);

            Console.WriteLine("-------------------------------");

            // Loop through array
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                // loop through rows
                Console.WriteLine("Row: {0}",i);
                // loop through values
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("Value: {0}", jaggedArray2[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}