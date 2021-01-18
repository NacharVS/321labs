using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread:");

            ThreadLocker threadLocker = new ThreadLocker();
            threadLocker.Start();

            Console.WriteLine("Task:");

            ThreadTask threadTask = new ThreadTask();
            threadTask.Start();
        }
    }
}
