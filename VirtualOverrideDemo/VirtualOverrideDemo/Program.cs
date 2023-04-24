using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Virtual and Override Keywords
            Dog dog = new Dog("Tj", 14);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
