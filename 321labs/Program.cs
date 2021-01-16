using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");

            Thread thread = new Thread(new ThreadStart(ThreadLocker.Filling));
            thread.Start();

            Thread resultThread = new Thread(new ThreadStart(ThreadLocker.Sum));
            resultThread.Start();
        }
    }
}
