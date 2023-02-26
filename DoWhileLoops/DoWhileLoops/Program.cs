using System;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Will always run code first, then check condition
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            // output = 0,1,2,3,4

            i = 15;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            // output = 15


            // User Input Program
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string nameOfAFriend = Console.ReadLine();
                lengthOfText += nameOfAFriend.Length;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks for your input! " + wholeText);


            Console.ReadKey();
        }
    }
}
