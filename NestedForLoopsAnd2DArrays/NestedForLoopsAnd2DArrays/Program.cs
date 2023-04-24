using System;

namespace NestedForLoopsAnd2DArrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9},
        };

        static void Main(string[] args)
        {
            Console.WriteLine("2D array printed using foreach loop:");
            foreach (int item in matrix)
            {
                Console.Write(item + " "); // output = 1 2 3 4 5 6 7 8 9
            }

            // Above foreach loop as a nested for loop
            Console.WriteLine("\n2D array printed using nested for loop:");
            // outer for loop
            // iterates through rows in array
            // GetLength(0) --> first dimension
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner for loop
                // iterates through columns in array
                // GetLength(1) --> second dimension
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Console.Write(matrix[i, j] + " "); // output = 1 2 3 4 5 6 7 8 9
                    if (matrix[i, j] % 2 == 0) // (matrix[i, j] % 2 == 1) --> prints odd numbers
                    {
                        Console.Write(matrix[i, j] + " "); // output = 2 4 6 8

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

            // Print diagonal values in matrix
            Console.WriteLine("\nDiagonal Values in 2D matrix.");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " "); // output = 1 5 9

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // this loop goes through each element in the diagonal
                Console.WriteLine(matrix[i,i]);
            }

            // Show diagonal going down in other direction
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j]); // output = 3 5 7
            }

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
