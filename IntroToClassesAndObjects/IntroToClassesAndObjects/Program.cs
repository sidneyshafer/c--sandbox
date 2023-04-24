using System;

namespace IntroToClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Class
                * A class is a blue print of an object
                * It has actions/abilities - called member functions or methods
                * It has properties - called member variables (such as Length property of String class)
                * Inheritance is possible
                * Can be used as a Datatype (e.g. String is a Class)
               
               Object
                * Create an Object from a Class
                * Example: Audi Object made from a Car Class
                    * Properties: HP, Amount of Wheels, Lumen, Doors
                    * Abilities/Actions: Drive, Break, Open Window, Make Light
                    * Inheritance: e.g. A5 < Audi < Car
            */

            // Create an object from the Human Class
            // an instance of Human
            Human sidney = new Human();
            // Access and change public variable
            sidney.firstName = "Sidney";
            sidney.lastName = string.Empty;
            // Call methods from Human Class
            sidney.IntroduceMyself();

            Human allie = new Human();
            allie.firstName = "Allie";
            allie.lastName = "Shafer";
            allie.IntroduceMyself();

            Human lisa = new Human();
            lisa.firstName = "Lisa";
            lisa.lastName = "Shafer";
            lisa.IntroduceMyself();

            Human brent = new Human();
            brent.firstName = "Brent";
            brent.lastName = string.Empty;
            brent.IntroduceMyself();

            Console.ReadKey();
        }
    }
}