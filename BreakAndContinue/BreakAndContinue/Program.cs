using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {

                if (i == 3)
                {
                    Console.WriteLine("At 3 we continue!");
                    // skips to next number
                    continue;
                }
                else if (i == 6)
                {
                    Console.WriteLine("At 6 we break!");
                    // exits for loop
                    break;
                }

                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
