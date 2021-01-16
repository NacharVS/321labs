using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs
{
    class Lockers
    {
        const int SizeOfArrays = 10;
        static int[] array1 = new int[SizeOfArrays];
        static int[] array2 = new int[SizeOfArrays];
        static int[] results = new int[SizeOfArrays];
        static object locker = new object();

        static Lockers()
        {
            Thread[] threads = new Thread[3];
            threads[0] = new Thread(Arr1FillIn);
            threads[1] = new Thread(Arr2FillIn);
            threads[2] = new Thread(Summ);

            lock (locker)
            {
                threads[0].Start();
                threads[1].Start();
            }
            threads[2].Start();

        }
        public static void Arr1FillIn()
        {
                var rnd = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(0, 100);
                }
        }

        static void Arr2FillIn()
        {
                var rnd = new Random();
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rnd.Next(0, 100);
                }
        }

        static void Summ()
        {
            lock (locker)
            {
                for (int i = 0; i < results.Length; i++)
                {
                    results[i] = array1[i] + array2[i];
                }
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
            }
            
        }

    }
}
