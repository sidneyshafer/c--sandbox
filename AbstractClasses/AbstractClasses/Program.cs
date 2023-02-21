using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                // Use the "as" keyword to create a variable of a certian type
                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube.");
                }

                // Use the "is" keyword to check if a variable is of a certain type
                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube.");
                }

                // cast from object
                // every class is inheriting from object
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a Volume of {1}", cube2.Name, cube2.Volume());
            }

            // INTERFACES VS ABSTRACT CLASSES
            // Abstract Classes
            /*  * A class designed to be inherited by subclasses
             *  * Provide a blueprint for derived classes
             *  * Set rules of what the derived classes should implement
             *  * Cannot create objects from the abstract class --> only the derived classes
             *  * Create a base class --> code reduction; implement common vunctionality
             *  * Example: a Motorcycle Class and Car Class are derived from the Vehical Class (abstract class)
            */

            // Interfaces
            /*  * An interface is a contract
             *  * Can only contain method declarations --> NOT method definitions
             *  * They define an ability a class has
             *  * Example: Bicycle Class, Motorcycle Class, and Car Class inherit from Vehicle Class
             *  * -- create ISelfDriving interface within Vehicle class
            */

            // Similarities
            /*  * Cannot be instantiated --> cannot create objects from these classes
             *  * Both support Polymorphism
            */

            // Differences
            /*
             * Interface
             *  * Not implemented at all
             *  * Cannot have Constructor
             *  * Contains only method declaration
             *  * Classes can implement more than one interface
             *  * Class must implement all of its members
             * 
             * * Abstract Class
             *  * Either partially implemented or not implemented at all
             *  * Can have constructors
             *  * May contain method definitations, fields
             *  * Classes can only extend (inherit) one class
             *  * Classes must implement abstract members only
            */

            // When should you choose inheritance over an interface when designing
            // C# class libraries?
            /*  * Use an abstract class if you have some functionality that you want
             *    its sub-classes to have. For example, if you have a set of functions
             *    you want sub-classes to have, put them in an abstract class. The abstract
             *    class is used when the derived class shares its core properties and
             *    behavior of the abstract class. The kind of behavior that actually defines
             *    the class.
             *
             *  * Use an interface if you want a general contract on a behavior or
             *    functionality. Interfaces are typically loose compared abstract classes.
             *    You wouldn't want to use interfaces in a situation where you are constantly
             *    writing the same code for all of the interface methods.
            */

            // Summary
            /*  When we talk about abstract classes, we define the characteristics of an object
             *  type; specifying what an object is. -----> "What the object is" (ABSTRACT CLASS)
             *  When we talk about an interface, we are establishing a contract about what the
             *  object can do. -----> "What the object can do" (INTERFACE)
            */

            Console.ReadKey();
        }
    }
}
