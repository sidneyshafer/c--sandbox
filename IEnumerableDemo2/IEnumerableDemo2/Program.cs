using System;
using System.Collections.Generic;

namespace IEnumerableDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //a list of type List<int> initialized with some numbers
            List<int> numberList = new List<int>() { 2, 8, 6 };
            //an array of type int[] initialized with some numbers
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            
            //new line
            Console.WriteLine(" ");
            //call CollectionSum() and pass the list to it
            CollectionSum(numberList);

            //new line
            Console.WriteLine(" ");
            //call CollectionSum() and pass the array to it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            //sum variable to store the sum of the numbers in anyCollection
            int sum = 0;

            //for each number in the collection passed to this method
            foreach(int num in anyCollection)
            {
                //add the num value to sum
                sum += num;
            }

            //print the sum
            Console.WriteLine("Sum is : {0}", sum);
        }
    }
}
