using System;

namespace Structs
{
    // structs can implement one or more interfaces
    // structs do not support inheritance
    // struct members can not be abstract, virtual, or protected --> only public or private
    struct Game
    {

        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        // Cannot create a constructor in "struct"
        // NOT ALLOWED :
        /*
        public Game()
        {

        }
        */

        // structs can have defined constructors
        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine($"Game 1 Name : {name}");
            Console.WriteLine($"Game 1 Developed by : {developer}");
            Console.WriteLine($"Game 1 Rating : {rating}");
            Console.WriteLine($"Game 1 Release Date : {releaseDate}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.Display();

            Console.WriteLine("-----------------------------------");

            Console.ReadKey();
        }
    }

    // CLASSES ONLY:
    /*
     * Can support inheritance
     * Are reference (pointer) types
     * The reference can be bull
     * Have memory overhead per new instance
    */

    // STRUCTS ONLY:
    /*
     * Cannot support inheritance
     * Are value types
     * Are passed by value (like integers)
     * Cannot have a null reference (unless Nullable is used)
     * Do not have a memory overhead per new instance - unless 'boxed'
    */

    // BOTH CLASSES AND STRUCTS:
    /*
     * Are compound data types typically used to containe a few variables
       that have some logical relationship.
     * Can contain methods and events
     * Can support interfaces
    */
}
