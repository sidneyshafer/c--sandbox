using System;

namespace LambdaExpressions
{
    internal class Program
    {
        //defining a delegate type called FilterDelegate that takes as Person object
        //and returns a bool
        //delegates are kind of like instructions for methods
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            //Lambda Expressions
            /*
             * can be used to create anonymous methods
             * Lambda declaration operator : => "goes to"
             * Expression Lambda : (input-parameters) => expression
             * Statement Lambda : (input-parameters) => { 
             *                          <sequence of statements (statement block)> 
             *                          }
            */

            // YOU CAN STORE A LAMBDA AS A VARIABLE
            /*
             *  Func<int, int> PlusOne = (a) => a+1;
                # this function gets an int argument and returns another int
                # You can have a return or not. And you can have no argument or have multiple. 
 
                # it is the way you can call this function
                int res = PlusOne(3);
                # res = 4
            */

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

            //Statement Lambda
            string searchKeyword = "S";
            DisplayPeople("Age > 20 With Search Keyword : " + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            // Expression Lambda
            DisplayPeople("Exactly 21:", people, p => p.Age == 21);


            Console.ReadKey();
        }

        //a method to display the list of people that passes the filter condition(returns true)
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
    }
}