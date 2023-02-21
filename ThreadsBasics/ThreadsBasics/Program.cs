using System;
using System.Threading;

namespace ThreadsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World! 1");
            //pauses program for 1000 milliseconds (1 second)
            Thread.Sleep(1000); //generally don't do this in the Main thread

            Console.WriteLine("Hello, World! 2");
            Thread.Sleep(1000);

            Console.WriteLine("Hello, World! 3");
            Thread.Sleep(1000);

            Console.WriteLine("Hello, World! 4");
            */

            //Threads : a piece of work that can be executed. They can also be executed at the same time

            // Create and start a new thread
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();

            Console.ReadKey();
        }
    }
}