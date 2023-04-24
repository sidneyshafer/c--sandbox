using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMultipleConstructors
{
    internal class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created.");
        }

        // Parameterized Constructor
        public Human(string firstName)
        {
            this.firstName = firstName;

        }

        // Parameterized Constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Parameterized Constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // Parameterized Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {

            
            if(age != 0 && firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, my name is {0} {1} and I am {2} years old.", firstName, lastName, age);
            }
            else if(eyeColor != null && age != 0 && firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, my name is {0} {1} and I am {2} years old.", firstName, lastName, age);
                Console.WriteLine("I have {0} eyes.", eyeColor);
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, my name is {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, my name is {0}.", firstName);
            }
        }

    }
}