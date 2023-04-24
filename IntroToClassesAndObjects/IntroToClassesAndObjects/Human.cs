using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClassesAndObjects
{
    // This class is a blueprint for a datatype
    internal class Human
    {
        // Member Variable
        // Add public keyword so variable can be accessed from porgram
        // Add private keyword so variable cannot be changed from program
        public string firstName;
        public string lastName;

        // Member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName);
        }

    }
}
