using System;

namespace UsingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sidney = new Human("Sidney","Shafer", "blue", 18);
            sidney.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
