using System;
using System.Collections.Generic;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList
            ArrayList myArrayList = new ArrayList(); // undefined ammount of objects
            ArrayList myArrayList2 = new ArrayList(100); // defined ammount of 100 objects

            // Can add any type of object/data type
            myArrayList.Add("Sidney");
            myArrayList.Add(25);
            myArrayList.Add(12);
            myArrayList.Add(true);
            myArrayList.Add(3.141592);
            myArrayList.Add(13);

            // Methods
            // delete number 13 from list
            myArrayList.Remove(13);

            // delete element at specific index
            myArrayList.RemoveAt(2); // removes number 12

            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (Double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
