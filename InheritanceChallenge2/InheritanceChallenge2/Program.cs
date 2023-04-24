using System;

namespace InheritanceChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee allie = new Employee("Shafer", "Allie", 60000);
            allie.Work();
            allie.Pause();

            Boss sidney = new Boss("Ferrari", "Shafer", "Sidney", 500000);
            sidney.Lead();

            Trainee brent = new Trainee(32, 8, "Shafer", "Brent", 12000);
            brent.Learn();
            brent.Work();


            Console.ReadKey();
        }
    }
}
