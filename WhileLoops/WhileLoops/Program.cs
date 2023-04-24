using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loops
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            // output = 0,1,2,3,4,5,6,7,8,9
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase by one." +
                    "Anything else, enter if you want to finish counting.");
                enteredText = Console.ReadLine();
                
                counter++;
                Console.WriteLine("Current people count it {0}", counter);
            }
            Console.WriteLine("{0} people are on the bus.", counter);
            Console.Read();
        }
    }
}
