using System;

namespace Enums
{
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su };

    enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec }

    class Program
    {
        static void Main(string[] args)
        {
            // Enums = A set of constants that are immutable and should be placed
            //         at namespace level.

            Day friday = Day.Fr;
            Day sunday = Day.Su;

            Day aDay = Day.Fr;

            Console.WriteLine(friday == aDay); // True

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int) Day.Mo); // 0

            Console.WriteLine((int)Months.Feb); // 2
            Console.WriteLine((int)Months.Jul); // 12

            Console.ReadKey();
        }
    }
}
