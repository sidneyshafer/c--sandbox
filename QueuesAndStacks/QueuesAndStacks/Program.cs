using System;
using System.Collections.Generic;

namespace QueuesAndStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Stacks and Queues - data structures / data organization
              
             * Stacks:
                * Uses System.Collections.Generic;
                * Data can be added/removed from top
                * Can't access the elements in the middle
                * First come last out or last in, first out (LIFO)
                * Examples:
                    * Reversing Data --> Web browser back button, Undo/Redo buttons
                    
             * Stack Operations:
                * Push(Object obj) -> adds data to the top of the stack
                * Object Pop() -> removes data from the top of the stack stack
                * Object Peek() -> returns data on top of stack without removing it

              * Queues:
                * Data can be added from the rear (back) and removed from the front
                * Executed in the order they came in 
                * Can't access the elements in the middle
                * First in first out (FIFO)
                * Examples:
                    * OS IO requests, mouse movements
                    * Managing web requests in a server
                    * Queuing input in video games
                    
              * Queues Operations:
                * Enqueue(Object obj) -> add data to the queue (added to the back)
                * Object Dequeue() -> remove data from the front
                * Object Peek() -> return data in front of queue without removing it
            
             */

            // Define a new stack
            // can be any type of data (ie. class, string), but can only hold 1 type of data
            Stack<int> stack = new Stack<int>();
            // Add integer to stack
            stack.Push(1);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek()); // output -> 1
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek()); // output -> 2
            stack.Push(3);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek()); // output -> 3
            stack.Push(4);

            // remove items from stack
            int stackItem = stack.Pop(); // Pop() returns a value of the stack data type
            Console.WriteLine("Popped value is : {0}", stackItem);

            Console.WriteLine();

            // Stacks Challenge - create a while loop to delete stack items
            Stack<int> numStack = new Stack<int>();
            numStack.Push(1);
            numStack.Push(2);
            numStack.Push(3);
            numStack.Push(4);
            numStack.Push(5);
            numStack.Push(6);

            // last in, first out (LIFO)
            while (numStack.Count > 0)
            {
                Console.WriteLine("Current stack count is : {0}", numStack.Count);
                Console.WriteLine("Top value {0} was removed from stack", numStack.Pop());
                Console.WriteLine("Stack count after Pop() is : {0}", numStack.Count);
                Console.WriteLine();
            }

            // reversing an array
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> myStack = new Stack<int>();

            // display numbers in array
            Console.WriteLine("The numbers in the array are :");
            // foreach number in the array
            foreach (int number in numbers)
            {
                //print it
                Console.Write(number + " ");
                //push it into the stack
                myStack.Push(number);

            }
            Console.WriteLine("");

            //display numbers in reverse
            Console.WriteLine("The numbers in reverse are : ");
            //as long as our stack is not empty
            while (myStack.Count > 0)
            {
                //Pop it and store it in a variable
                int number = myStack.Pop();
                //print the value popped
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
