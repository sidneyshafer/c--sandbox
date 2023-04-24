using System;

namespace JaggedArraysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] joesFamily = new string[] { "Martha", "Robert" };

            string[][] friendsAndFamily = new string[][]
            {
                new string[] {"Lisa", "Brent"},
                new string[] {"Sidney", "Allie"},
                new string[] {"Leila", "Linda"},
                joesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[1][0], friendsAndFamily[2][1]);

            for(int i = 0; i < friendsAndFamily.Length; i++)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Family: {0}",i);
                for (int j = 0; j < friendsAndFamily[i].Length; j++)
                {
                    Console.WriteLine("Name: {0}", friendsAndFamily[i][j]);
                }
            }

            Console.WriteLine("-----------");
            Console.ReadKey();

        }
    }
}
