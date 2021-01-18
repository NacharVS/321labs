using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.locker
{
    class loker
    {
        static int[] FirstArray = new int[10];
        static int[] SecondArray = new int[10];
        static int[] SummArray = new int[10];
        static object locks = new object();
        static void GenerateRandomArray1()
        {
            lock (locks)
            {
                Random rnd = new Random();
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    FirstArray[i] = rnd.Next(1, 50);
                }
                Console.WriteLine("Первый массив: ");
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    Console.WriteLine(FirstArray[i]);
                }
            }
        }
        static void GenerateRandomArray2()
        {
            lock (locks)
            {
                Random rnd = new Random();
                for (int i = 0; i < SecondArray.Length; i++)
                {
                    SecondArray[i] = rnd.Next(1, 50);
                }
                Console.WriteLine("Второй массив: ");
                for (int i = 0; i < SecondArray.Length; i++)
                {
                    Console.WriteLine(SecondArray[i]);
                }
            }
        }
        static void Summ()
        {
            lock (locks)
            {
                for (int i = 0; i < SummArray.Length; i++)
                {
                    SummArray[i] = FirstArray[i] + SecondArray[i];
                }
                Console.WriteLine("Сумма: ");
                for (int i = 0; i < SummArray.Length; i++)
                {
                    Console.WriteLine(SummArray[i]);
                }
            }

        }
        public static void Start()
        {
            Thread thread1 = new Thread(GenerateRandomArray1);
            Thread thread2 = new Thread(GenerateRandomArray2);
            Thread thread3 = new Thread(Summ);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
