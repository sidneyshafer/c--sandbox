using System;

namespace MainArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] args --> provides necessary input in order for application to run

            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args ;). Please provide arguments next time. Pass 'help' if you want to get more details.");
                Console.ReadKey();
                return;
            }

            // check if the first command we get is help
            if (args[0] == "help")
            {
                //display manual
                Console.WriteLine("********************* Instructions:");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to subtract 2 numbers");
                Console.WriteLine("* use this format : sub (or) add num1 num2");
                Console.WriteLine("*********************");

                //pause
                Console.ReadKey();
                return;
            }

            //need 3 arguments
            //check length of args
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the 'help' command for instructions");
                //pause
                Console.ReadKey();
                //quit the app
                return;
            }

            // try parsting input
            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the 'help' command for instructions.");
                //pause
                Console.ReadKey();
                //quit the app
                return;
            }

            // a variable to store the results
            float result;

            switch (args[0])
            {
                //case 1 : 'add' add tje two numbers and print the value
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} + {num2} = {result}");
                    break;

                //case 1 : 'add' add tje two numbers and print the value
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The sum of {num1} - {num2} = {result}");
                    break;

                default:
                    Console.WriteLine("Invalid arguments, please use the 'help' command for instructions.");
                    break;
            }

            //Console.WriteLine("Hello " + args[0]);

            Console.ReadKey();
        }
    }
}