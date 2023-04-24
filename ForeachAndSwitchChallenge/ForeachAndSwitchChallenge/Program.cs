using System;

namespace ForeachAndSwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType = string.Empty;

            Console.WriteLine("Enter a value : ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the data type to validate the input you entered.");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter : ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    // check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;

                case 2:
                    // check for int
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;

                case 3:
                    bool retFlag = false;
                    // check for boolean
                    valid = Boolean.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;

                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Something went wrong, not able to detect the input type.");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", inputValue);

            if (valid)
            {
                Console.WriteLine("It is valid : {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }

            Console.ReadKey();

            /// <summary>
            ///  Function to check if the input string is a pure letter string.
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            static bool IsAllAlphabetic(string value)
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                        return false;
                }

                return true;
            }
        }
    }
}
