using System;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(2004, 3, 30);

            Console.WriteLine("My birthday is {0}", dateTime);

            // Write today on screen
            Console.WriteLine(DateTime.Today);
            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be : " + tomorrow);

            Console.WriteLine("Today is : " + DateTime.Today.DayOfWeek);

            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000 : " + days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001 : " + days);
            days = DateTime.DaysInMonth(2002, 2);
            Console.WriteLine("Days in Feb 2002 : " + days);
            days = DateTime.DaysInMonth(2003, 2);
            Console.WriteLine("Days in Feb 2003 : " + days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004 : " + days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Hour : " + now.Hour);
            Console.WriteLine("Minute : " + now.Minute);
            Console.WriteLine("Second : " + now.Second);

            // display time
            Console.WriteLine($"{now.Hour} o'clock, {now.Minute} minutes, and {now.Second} seconds");
            Console.WriteLine("\n");

            Console.WriteLine("Write your birthday in this format : yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input...");
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}