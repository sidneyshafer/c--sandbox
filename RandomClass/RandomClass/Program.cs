using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();
            int numEyes;

            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7); // value between 1 and 6
                Console.WriteLine(numEyes);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Ask a question : ");
            Console.ReadLine();

            Random yesNoMaybe = new Random();
            int answerNum = yesNoMaybe.Next(1, 4);

            if (answerNum == 1)
            {
                Console.WriteLine("Yes");
            } 
            else if (answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();

        }
    }
}
