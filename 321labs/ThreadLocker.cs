using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class ThreadLocker
    {
        static int[] mas1 = new int[10];
        static int[] mas2 = new int[10];
        static int[] masResult = new int[10];

        static object locker = new object();
        public static void Filling()
        {
            lock (locker)
            {
                Random rand = new Random();
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] = rand.Next(1, 10);
                }

                for (int i = 0; i < mas2.Length; i++)
                {
                    mas2[i] = rand.Next(1, 10);
                }
                Out();
            }
        }

        public static void Sum()
        {
            for (int i = 0; i < masResult.Length; i++)
            {
                masResult[i] = mas1[i] + mas2[i];
            }
            for (int i = 0; i < masResult.Length; i++)
            {
                Console.Write(masResult[i] + " ");
            }
            Console.WriteLine();
        }

        private static void Out()
        {
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
        }
    }
}
