using _321labs.Kamalov.Threads;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3123, 165, 2123, 464, 7, -22, 512 };

            CustomThread arr = new CustomThread();
            Thread test1 = new Thread(new ParameterizedThreadStart(arr.Total));
            Thread test2 = new Thread(new ParameterizedThreadStart(arr.Maximum));
            Thread test3 = new Thread(new ParameterizedThreadStart(arr.Sort));

            test1.Start(test);
            test2.Start(test);
            test3.Start(test);
        }
    }
}