using System;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foreach Loop
            // create a new array
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }
            Console.WriteLine("----------------");

            // counter
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
            }
            Console.WriteLine("----------------");

            // Create a friend list array
            string[] friends = { "Allie", "Lisa", "Brent", "Tryg" };
            foreach(string friend in friends)
            {
                Console.WriteLine("Hello {0}, my friend!", friend);
            }

            Console.ReadKey();
        }
    }
}
