using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableAndIEnumerator
{
    class Program
    {
        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non generic collections

        // - used to iterate through a collection
        // - can use foreach loops
        // - IEnumarble makes objects countable

        /// <summary> 
        /// IEnumerable contains a single method that you must implement when
        /// implementing this interface
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through
        /// the collection by exposing a Current property that points at the object 
        /// we are currently at in the collection
        /// </summary>

        /// when it is recommended to use the IEnumerable interface:
        /// - when yuor collection represents a massive database table,
        /// you don't want to copy the entire thing into memory and cause performance issues
        /// in your application.
        /// When it is NOT recommended to use the IEnumerable interface:
        /// - when you need the results right away are are possible mutating / editing
        /// the objects later on. In this case, it is better to use an Array or List
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if(!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(3);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }

    }

    class Dog
    {
        // name of the dog
        public string Name { get; set; }
        // is this a naughty dog?
        public bool IsNaughtyDog { get; set; }

        // simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        // this method will print how many treats the dog receives
        public void GiveTreat(int numberOfTreats)
        {
            //print a message containing the number of treats and the name of the dog
            Console.WriteLine($"Dog: {Name} got {numberOfTreats}! " +
                $"{Name} said whoof {numberOfTreats} times!");
        }
    }

    //a class named DogShelter that contains a generic collection of type Dog
    //must implement IEnumerable<T> to iterate through DogShelter list
    class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;
        //this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            //initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false),
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
