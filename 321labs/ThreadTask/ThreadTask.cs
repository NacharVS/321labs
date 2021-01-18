using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs
{
    class ThreadTask
    {
        static Random rnd = new Random();
        static object x = new object();
        static int[] first = new int[10];
        static int[] second = new int[10];
        static int[] third = new int[10];

        Task taskGen = new Task(() =>
        {
            lock (x)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    first[i] = rnd.Next(1, 30);
                }

                Console.Write("First array: ");
                foreach (var item in first)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < second.Length; i++)
                {
                    second[i] = rnd.Next(1, 30);
                }

                Console.Write("Second array: ");
                foreach (var item in second)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        });

        Task taskSum = new Task(() =>
        {
            Thread.Sleep(100);
            lock (x)
            {
                for (int i = 0; i < third.Length; i++)
                {
                    third[i] = first[i] + second[i];
                }

                Console.Write("Sum of arrays: ");
                foreach (var item in third)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        });

        public void Start()
        {
            taskGen.Start();
            lock (x)
            {
                taskSum.Start();
            }
            taskSum.Wait();
            taskGen.Wait();

        }
    }
}
