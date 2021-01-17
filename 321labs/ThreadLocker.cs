using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs
{
    class ThreadLocker
    {
        static int[] mas1 = new int[10];
        static int[] mas2 = new int[10];
        static int[] masResult = new int[10];

        static object locker = new object();

        public static void FillingArray()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Первый массив");
                foreach (var item in mas1)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public static void FillingArray2()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas2[i] = rnd.Next(1, 20);
                }
                Console.WriteLine("Второй массив");
                foreach (var item in mas2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Sum()
        {
            lock (locker)
            {

                for (int i = 0; i < masResult.Length; i++)
                {
                    masResult[i] = mas1[i] + mas2[i];

                }
                Console.WriteLine("Сумма");
                foreach (var item in masResult)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public void Start()
        {
            Thread thread1 = new Thread(FillingArray);
            Thread thread2 = new Thread(FillingArray2);
            Thread thread3 = new Thread(Sum);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
