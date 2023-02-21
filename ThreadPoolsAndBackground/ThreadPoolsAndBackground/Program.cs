using System.Linq;

namespace ThreadPoolsAndBackground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Threads are used to run specific work/work items

            //set thread to background thread
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            })
            { IsBackground = true }.Start();

            //Create multiple threads
            Enumerable.Range(0,100).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });

                /*
                new Thread(() =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                }).Start();
                */
            });

            Console.ReadKey();
        }
    }
}