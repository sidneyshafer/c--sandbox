using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Inheritance in C#
             
             * Inheritance allows us to define a class in terms of another class,
               which makes it easier to create and maintain an application. This
               also provides an opportunity to reuse the code functionality
               and speeds up implementation time.

             * Example:
                * Base Class: Car
                    - Properties: HP (hoarse power), Windows, Wheels
                    - Methods: Drive, Honk
                * Deriving Class: Streets Car
                        - Properties: HP, Windows, Wheels, & Comfort
                        - Methods: Drive, Honk, & Streetride
                * Deriving Class: Race Car
                        - Properties: HP, Windows, Wheels, & Torbo
                        - Methods: Drive, Honk, & Racing

            Parent/base class ---> (inherits properties and methods) ---> child class

            */

            Radio myRadio = new Radio(false, "Sony");
            myRadio.ListenRadio();
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(true, "Samsung");
            //method of child class
            myTV.WatchTV();
            //method of base class
            myTV.SwitchOff();
        }
    }
}
