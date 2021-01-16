using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");

            ThreadLocker t = new ThreadLocker();
            Thread thread = new Thread(new ThreadStart(t.Sum));
        }
    }
}
