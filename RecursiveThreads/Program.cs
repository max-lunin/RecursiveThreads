using System.Diagnostics;

class Program
{
    static void Main()
    {
        Recursive();
    }

    static void Recursive()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine(
                              $"Thread ID: {Thread.CurrentThread.ManagedThreadId}, " +
                              $"Total threads: {Process.GetCurrentProcess().Threads.Count}");
            Recursive();
        });
        thread.IsBackground = true;
        thread.Start();
        thread.Join();
    }
}