using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaces - prefixed with I to distinguish from other classes
            // Example: IProtect, IDog, IStrong
            // Create Interfaces using the 'I' keyword

            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t2.Equals(t1));


            Console.ReadKey();
        }
    }
}
