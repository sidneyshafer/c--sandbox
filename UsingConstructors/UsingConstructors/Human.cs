using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructors
{
    internal class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // Constructor
        // Has the same name as the class itself
        // Whenever a Human object is created, the firstName and LastName must be provided
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            // 'this' keyword refers to this object
            // set this object firstName equal to the firstName of the object
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            Console.WriteLine("I have {0} eyes and am {1} years old.", eyeColor, age);
        }

    }
}
