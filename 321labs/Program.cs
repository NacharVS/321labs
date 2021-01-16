using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");

            Thread randomArr1 = new Thread(new ThreadStart(LockThread.RandomizerArr1));
            randomArr1.Start();
            Thread randomArr2 = new Thread(new ThreadStart(LockThread.RandomizerArr2));
            randomArr2.Start();
            Thread threadSum = new Thread(new ThreadStart(LockThread.Sum));
            threadSum.Start();
        }
    }
}
