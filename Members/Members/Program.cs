using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members("Lucy","Intern",30000,23);
            member1.Introducing(true);

            Console.ReadKey();
        }
        // finalizer called after program finishes
    }
}
