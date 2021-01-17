using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Mironov.Locker
{
    class LockThread
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] result = new int[10];
        static object locker = new object();
        static Random rnd = new Random();
        public static void Start()
        {
            Thread generateValue1 = new Thread(() => GenerateValue(arr1));
            Thread generateValue2 = new Thread(() => GenerateValue(arr2));
            Thread findSum = new Thread(SumArray);
            generateValue1.Name = "Thread 1";
            generateValue2.Name = "Thread 2";
            findSum.Name = "Sum thread";
            generateValue1.Start();
            generateValue2.Start();
            lock (locker)
            {
                findSum.Start();
            }


        }



        private static void GenerateValue(int[] arr)
        {
            lock (locker)
            {

                Console.WriteLine(Thread.CurrentThread.Name);

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(1, 20);
                }
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SumArray()
        {
            lock (locker)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = arr1[i] + arr2[i];
                    Console.Write(result[i] + " ");
                }
            }

        }
    }
}
      



 
