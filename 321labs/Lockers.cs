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
            var thr1 = new Thread(new ThreadStart(Arr1FillIn));
            var thr2 = new Thread(new ThreadStart(Arr2FillIn));
            var thr3 = new Thread(new ThreadStart(Summ));
        }
        static void Arr1FillIn()
        {
            lock (locker)
            {
                var rnd = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(0, 100);
                }
            }
        }

        static void Arr2FillIn()
        {
            lock (locker)
            {
                var rnd = new Random();
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rnd.Next(0, 100);
                }
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
            }
        }

    }
}
