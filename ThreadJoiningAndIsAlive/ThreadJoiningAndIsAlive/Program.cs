using System.Threading;

namespace ThreadJoiningAndIsAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            //Join() blocks the called thread. In this case, it is blocking the main thread
            //thread1.Join();
            //Console.WriteLine("Thread1Function done");

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done within 1 sec");
            }
            else
            {
                Console.WriteLine("Thread1Function not done within 1 sec");
            }

            thread2.Join();
            Console.WriteLine("Thread2Function done");

            for (int i = 0; i < 10; i++)
            {
                //if thread is still running
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still running");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 completed");
                }
            }

            
            Console.WriteLine("Main Thread ended");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to Main Thread");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}