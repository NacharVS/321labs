using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class LockThread
    {
        static int[] arr1 = new int[SIZEARRAY];
        static int[] arr2 = new int[SIZEARRAY];
        static int[] arr3 = new int[SIZEARRAY];

        const int SIZEARRAY = 10;

        static object locker = new object();

        static Random rnd = new Random();

        public static void RandomizerArr1()
        {
            lock (LockThread.locker)
            {
                Console.WriteLine("Первый массив: ");
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = rnd.Next(0, 100);
                    Console.Write($"{arr1[i]}, ");
                }
                Console.WriteLine();
            }
        }
        
        public static void RandomizerArr2()
        {
            lock (LockThread.locker)
            {
                Console.WriteLine("Второй массив:");
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr2[i] = rnd.Next(-100, 0);
                    Console.Write($"{arr2[i]}, ");
                }
                Console.WriteLine();
            }
        }

        public static void Sum()
        {
            lock (locker)
            {
                Console.Write("Сумма элементов массивов: ");
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
                Console.Write($"{arr3[i]}, ");
            }
            Console.WriteLine();

        }
    }
}
