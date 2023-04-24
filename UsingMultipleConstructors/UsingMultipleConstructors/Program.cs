using System;

namespace UsingMultipleConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sidney = new Human("Sidney", "Shafer", "blue", 18);
            sidney.IntroduceMyself();
            Console.WriteLine("-----------------------------");

            Human allie = new Human("Allie", "Shafer", "blue", 18);
            allie.IntroduceMyself();
            Console.WriteLine("-----------------------------");

            Human lisa = new Human("Lisa", "Shafer", 55);
            lisa.IntroduceMyself();
            Console.WriteLine("-----------------------------");

            Human brent = new Human("Brent", "Shafer");
            brent.IntroduceMyself();
            Console.WriteLine("-----------------------------");

            Human tj = new Human("Tj");
            tj.IntroduceMyself();
            Console.WriteLine("-----------------------------");

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();
            Console.WriteLine("-----------------------------");

            Console.ReadKey();
        }
    }
}
