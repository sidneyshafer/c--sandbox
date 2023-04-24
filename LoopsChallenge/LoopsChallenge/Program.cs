using System;

namespace LoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set variables
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            // When -1 is entered, the program ends and no more values are added

            while(input != "-1")
            {
                Console.WriteLine("Last number entered was {0}", currentNumber);
                Console.WriteLine("Current amount of entries is {0}", count);
                Console.WriteLine("Please enter -1 to calculate the average");
                Console.WriteLine("Please enter the next score:");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("------------------------------------------");
                    // Calculate average and let user know
                    double average = Math.Round((double)total / (double)count, 2);
                    Console.WriteLine("Total entries is: {0}", count);
                    Console.WriteLine("Average score is: {0}", average);
                }
                // Check that user input is a number and that it is between 0 and 20
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {   // if input does not equal -1
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20.");
                        Console.WriteLine("------------------------------------------");
                    }
                    continue;
                }

                count++;
                
            }

            Console.Read();
        }
    }
}
