
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Garifullin.Threads
{
    class CustomThread
    {
        int amount;

        public CustomThread()
        {

        }

        public void Total(object obj)
        {
            int[] vs = (int[])obj;

            for (int i = 0; i < vs.Length; i++)
            {
                amount += vs[i];
                Console.WriteLine($"Total: {amount}");
            }
            Console.WriteLine($"All Total {amount}");
            Thread.Sleep(50);
        }
    }
}
