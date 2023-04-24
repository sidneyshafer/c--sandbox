using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericAndNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections
            /*
             * Collections are classes that we can use to store a collections of objects
             * Not limited to one type of objects
             * No size constraints, it can grow in size as we add more elements
             * We use them to store, manage and manipulate groups of objects more efficiently:
                * Adding
                * Deleting
                * Replacing
                * Searching
                * Copying
              
             * Types of Collections
                * Non-Generic
                    * Can store any type of objects
                    * Located in: System.Collections namespace
                    
                * Generic
                    * Limited to one type of objects
                    * Located in: System.Collections.Generic namespace
            */

            // Non-Generic Collection Examples
            int num1 = 5;
            float num2 = 3.14f;
            string name = "Sidney";
            
            ArrayList myArrList = new ArrayList();
            
            myArrList.Add(num1);
            myArrList.Add(num2);
            myArrList.Add(name);

            // loop through arraylist
            foreach (object item in myArrList)
            {
                Console.WriteLine(item);
            }

            // Generic Collection
            string animal1 = "Cat";
            string animal2 = "dog";
            string animal3 = "Flamingo";
            
            List<string> myList = new List<string>();

            myList.Add(animal1);
            myList.Add(animal2);


            Console.ReadKey();
        }
    }
}
