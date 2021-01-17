using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.ThreadLocker
{
    static class TheadLocker
    {
        public static int[] arr1 = new int[10];
        public static int[] arr2 = new int[10];
        public static int[] arr3 = new int[10];
        static object locker = new object();

        public static void MainTheadLocker()
        {
            
            Thread thread1 = new Thread(RandomArr1);
            thread1.Start();
            Thread.Sleep(200);
            Thread thread2 = new Thread(RandomArr2);
            thread2.Start();
            Thread.Sleep(200);
            Thread thread3 = new Thread(Summ);
            thread3.Start();
            Thread.Sleep(200);


        }
        public static void RandomArr1()
        {
            lock (locker)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    Random random = new Random();
                    arr1[i] = random.Next(10);
                    Console.WriteLine("Array1 " + arr1[i]);
                }
            }
        }
        public static void RandomArr2()
        {
            lock (locker)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    Random random1 = new Random();
                    arr2[i] = random1.Next(10);
                    Console.WriteLine("Array2 " + arr2[i]);
                }
            }
        }
        public static void Summ()
        {
            lock (locker)
            {
                
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr3[i] = arr1[i] + arr2[i];
                    Console.WriteLine("Array3 "+arr3[i]);
                }
                
                

            }

        }
        
    }
}
