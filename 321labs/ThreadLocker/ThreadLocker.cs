using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs
{
    class ThreadLocker
    {
        static Random rnd = new Random();
        static object x = new object();
        static int[] first = new int[10];
        static int[] second = new int[10];
        static int[] third = new int[10];


        public static void GenerateRndDigitFirst()
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
            }
        }
        public static void GenerateRndDigitSecond()
        {
            lock (x)
            {
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
        }

        public static void SumArray()
        {
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
        }

        public void Start()
        {
            Thread first = new Thread(GenerateRndDigitFirst);
            Thread second = new Thread(GenerateRndDigitSecond);
            Thread sum = new Thread(SumArray);
            first.Start();
            second.Start();
            lock (x)
            {
                sum.Start();
            }
        }
    }
}
