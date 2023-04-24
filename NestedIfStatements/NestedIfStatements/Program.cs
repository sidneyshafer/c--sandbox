using System;

namespace NestedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            Console.WriteLine("Please enter your username: ");
            userName = Console.ReadLine();

            /*
            if (isRegistered)
            {
                Console.WriteLine("Hello registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            */
            // Can combine code above into 1 if statement:
            // To compare strings, use Equals()
            // And (&&) operator
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hello registered user");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there, Admin");
            }
            // Or (||) operator
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
        }
    }
}
