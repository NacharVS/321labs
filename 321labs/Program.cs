using _321labs.Kamalov.Game;
using System;
using System.Threading;
using System.Collections.Generic;
using _321labs.Kamalov.ThreadLocker;

namespace _321labs
{
    class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            Locker createLocker = new Locker();
            Thread thread1 = new Thread(createLocker.First);
            Thread thread2 = new Thread(createLocker.Second);
            Thread thread3 = new Thread(createLocker.Sum);

            lock (locker)
            {
                thread1.Start();
            }
            lock (locker)
            {
                thread2.Start();
            }
            lock (locker)
            {
                thread3.Start();
            }
        }
    }
}