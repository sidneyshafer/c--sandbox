using System;

namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullables - values that can have a value or do not have
            // a value.
            // - put ? after datatype

            int? num1 = null;
            int? num2 = 1337;
            //int num5; --> variable cannot be empty

            double? num3 = new Double?();
            double? num4 = 3.141592;

            bool? boolVal = new bool?();

            Console.WriteLine("Nullable numbers are : {0}, {1}, {2}, {3}", num1, num2, num3, num4);

            Console.WriteLine("Bool value is : {0}", boolVal);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("Use is female");
            }
            else
            {
                Console.WriteLine("No gender specified");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                // must cast 'double?' to 'double'
                num8 = (double)num6;
            }

            Console.WriteLine("Value of num8 is : {0}", num8); // 13.1

            // Shorter: THE NULL COALESCING OPERATOR ??
            // Short version of 'if' statement above
            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is : {0}", num8); // 13.1
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is : {0}", num8); // 8.53

            Console.ReadKey();
        }
    }
}