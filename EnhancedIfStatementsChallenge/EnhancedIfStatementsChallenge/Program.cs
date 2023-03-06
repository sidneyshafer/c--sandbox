using System;

namespace EnhancedIfStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string tempMessage = string.Empty;
            string inputValue = string.Empty;

            // Take input from the console
            Console.WriteLine("What is the temperature today?");
            inputValue = Console.ReadLine();

            // Validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            // variable = condition ? ifTrue : ifFalse
            tempMessage = inputTemperature <= 15 ? "It is too cold here" :
                inputTemperature >= 16 && inputTemperature <= 28 ? "It is ok" : "It is hot here";

            Console.WriteLine(tempMessage);
            Console.ReadKey();
        }
    }
}
