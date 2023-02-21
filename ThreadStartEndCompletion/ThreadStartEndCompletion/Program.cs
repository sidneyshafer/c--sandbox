using System.Threading.Tasks;

namespace ThreadStartEndCompletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            //Thread variable
            var thread = new Thread(() =>
            {
                //get id of specific thread
                Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                //set the taskComplectionSource to true
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
            });

            //Console.WriteLine($"Thread number : {thread.ManagedThreadId}");
            //sart thread
            thread.Start();

            var test = taskCompletionSource.Task.Result;

            Console.WriteLine("Task was done : {0}", test);
            
            Console.ReadKey();
        }
    }
}