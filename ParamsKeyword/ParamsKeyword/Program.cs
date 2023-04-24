using System;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math class
            // Math.Min() --> only takes in two numbers

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            // Overloads - different kinds of implementation for a specific method
            Console.WriteLine("Price is {0}, pi is {1}, and at is {2}", 32, 3.14, '@');
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} + {5} = {6}", 1,2,3,4,5,6, 1 + 2 + 3 + 4 + 5 + 6);

            ParamsMethod("This", "is", "a", "string", "of", "words", ":", "howdy", ",", "how", "are", "you", "?","...");

            Console.WriteLine();

            ParamsObject(price, pi, at, book);

            int minValue = MinV2(6, 4, 2, 8, 1, 0, 5, -11);
            Console.WriteLine("The minimum value is : {0}", minValue);

            Console.ReadKey();
        }

        // Params keyword allows us to pass in as many paramaters as we want
        // If you pass nothing in, the code will display nothing, but the program will not crash
        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        // Object[] - array og objects 
        public static void ParamsObject(params object[] stuff)
        {
            //for each loop to go through array of objects
            foreach (object obj in stuff)
            {
                //print each object followed by a space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        // Returns the minimum number of numbers passed in
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
