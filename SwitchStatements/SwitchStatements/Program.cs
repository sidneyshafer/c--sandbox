using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club");
                    // Must use break keyword to exit switch
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                // default called when no other cases are true
                default:
                    Console.WriteLine("How are old are you?");
                    break;
            }

            // Above switch as if statement:
            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How are old are you?");
            }

            // Switch statement with strings
            string username = "Sidney";

            switch (username)
            {
                case "Sidney":
                    Console.WriteLine("Username is Sidney");
                    break;
                case "root":
                    Console.WriteLine("Username is root");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }


            Console.Read();
        }
    }
}