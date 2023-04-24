using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lists
             * Compared to arrays, the group of objects/values you work with can grow
               and shrink dynamically.
             * A collection is a class and it requires an instance of the class before adding
               elements to that collection.
             * For collections that only contain one data type use the System.Collection.Generic namespace
            */

            // List declaration examples
            var numbers = new List<int>(); // List of type int without values
            var numbers2 = new List<int> { 1, 5, 35, 100 }; // List of type int with values

            // Adding and Removing Values
            numbers.Add(7); // Adds an integer with a value of 7 to the list
            numbers.Add(9);
            numbers.Remove(7); // Removes an element with a value of 7

            int index = 0;
            numbers.RemoveAt(index); // Removes an elements at a specific position (index)

            // Getting a value
            int value = numbers2[1]; // value will be 5

            // Clearing a list
            numbers.Clear(); // Deletes every elements in the list

            // Lists and Loops
            var numbers3 = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40 };

            foreach (int element in numbers3) // foreach loop
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers3.Count; i++) // for loop
            {
                Console.Write(numbers3[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
