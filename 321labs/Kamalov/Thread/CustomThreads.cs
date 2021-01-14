using System;
using System.Threading;

namespace _321labs.Kamalov.Threads
{
    class CustomThreads
    {
        int total;
        int amount;
        int temp;

        public CustomThreads()
        {

        }
        
        public void Total(object obj)
        {
            int[] vs = (int[])obj;

            for (int i = 0; i < vs.Length; i++)
            {
                amount += vs[i];
                Console.WriteLine($"Total - {amount}");
            }
            Console.WriteLine($"All Total - {amount}");
            Thread.Sleep(55);
        }
        public void Maximum(object obj)
        {
            int[] vs = (int[])obj;
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] > total)
                {
                    total = vs[i];
                    Console.WriteLine($"Max - {total}");
                }
                Thread.Sleep(55);
            }
            Console.WriteLine($"All Max - {total}");
        }
        public void Sort(object obj)
        {
            int[] mass = (int[])obj;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                        Console.WriteLine($"Sorted - {mass[i]}");
                        Console.WriteLine($"Sorted - {mass[j]}");
                        Thread.Sleep(55);
                    }
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Total sort - {mass[i]}");
                Thread.Sleep(55);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3123, 165, 2123, 464, 7, -22, 512 };

            CustomThreads arr = new CustomThreads();
            Thread test1 = new Thread(new ParameterizedThreadStart(arr.Total));
            Thread test2 = new Thread(new ParameterizedThreadStart(arr.Maximum));
            Thread test3 = new Thread(new ParameterizedThreadStart(arr.Sort));

            test1.Start(test);
            test2.Start(test);
            test3.Start(test);
        }
    }
}