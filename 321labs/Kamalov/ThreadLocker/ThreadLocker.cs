using System;
using System.Threading;
using System.Collections.Generic;

namespace _321labs.Kamalov.ThreadLocker
{
    class Locker
    {
        static object locker = new object();

        static int[] mas1 = new int[10];
        static int[] mas2 = new int[10];
        static int[] mas3 = new int[10];

        public void First()
        {
            lock (locker)
            {
                Console.Write("First array: ");
                Random r = new Random();
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = r.Next(0, 10);
                    Thread.Sleep(500);
                }
                foreach (int item in mas1)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
            }
        }
        public void Second()
        {
            lock (locker)
            {
                Console.Write("Second array: ");
                Random r = new Random();
                for (int i = 0; i < mas2.Length; i++)
                {
                    mas2[i] = r.Next(10, 20);
                    Thread.Sleep(500);
                }
                foreach (int item in mas2)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
            }
        }
        public void Sum()
        {
            lock (locker)
            {
                for (int i = 0; i < mas3.Length; i++)
                {
                    mas3[i] = mas1[i] + mas2[i];
                    Console.WriteLine($"Сумма {mas1[i]} и {mas2[i]} массива = {mas3[i]}");
                    Thread.Sleep(500);
                }
            }
        }

    }
}