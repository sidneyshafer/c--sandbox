using System;

namespace DelegatesCreate
{
    internal class Program
    {
        //defining a delegate type called FilterDelegate that takes as Person object
        //and returns a bool
        //delegates are kind of like instructions for methods
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            //Create 4 Person objects
            Person p1 = new Person() { Name = "Sidney", Age = 21 };
            Person p2 = new Person() { Name = "Allie", Age = 16 };
            Person p3 = new Person() { Name = "Lisa", Age = 55 };
            Person p4 = new Person() { Name = "Brent", Age = 53 };
            Person p5 = new Person() { Name = "Linda", Age = 74 };

            //add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);


            //Anonymous Method - Method 1
            //methods that do not have a name, but behaves like a method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Between 20 & 30", people, filter);

            //Anonymous Method - Method 2
            DisplayPeople("All:", people, delegate (Person p) { return true; });

            Console.ReadKey();
            
        }

        //a method to display the list of people that passes the filter condition (returns true)
        //this method will take a title to be displayed, the list of people, and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            //print the title
            Console.WriteLine($"-----{title}-----");

            //loop through people list
            foreach (Person p in people)
            {
                //check if the person passes the filter
                if (filter(p))
                {
                    //print the person's name and age
                    Console.WriteLine("{0}, is {1} years old.", p.Name, p.Age);
                }
            }
        }

        // ==========FILTERS==========
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

        // ===== CODING EXERCISE =====
        /*
         * using System;
            namespace Coding.Exercise
            {
                public class Run
                {
                    public delegate float OperationDelegate(float a, float b);
        
                    public static float Add(float a, float b){
                        return a+b;
                    }
        
                    public static float Subtract(float a, float b){
                        return a-b;
                    }
        
        
                    public static float Multiply(float a, float b){
                        return a*b;
                    }
        
                    public static float Divide(float a, float b){
                        return a/b;
                    }
        
                    public static float ApplyOperation(float a, float b, OperationDelegate oper)
                    {
                        float result;
            
                        result = oper(a, b);
            
                        return result;
                    }
                }
            }
        */
    }
}