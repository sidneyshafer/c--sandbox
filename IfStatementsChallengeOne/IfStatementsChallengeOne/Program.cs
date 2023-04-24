using System;

namespace IfStatementsChallengeOne
{
    class Program
    {
        // Global Variables
        // Created globaly so they can be used in multiplt methods
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        // Create method to register a user
        public static void Register()
        {
            Console.WriteLine("Please enter your username:");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("--------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password:");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Loging failed, wrong username. Restart Program");
            }
        }
    }
}
