using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.ThreadsLocker
{
    public class ThreadsLockerProgram
    {
        static object locker = new object();
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] arr3 = new int[10];
        static Random rand = new Random();
        public static void MainLocker()
        {
            Thread RandomThread1 = new Thread(GenerateIntRandomArrays);
            Thread RandomThread2 = new Thread(GenerateIntRandomArrays);
            Thread SumThread1 = new Thread(SumIntArr);

            RandomThread1.Start(new ArrRandData(arr1));
            RandomThread2.Start(new ArrRandData(arr2));
            Thread.Sleep(2000);
            SumThread1.Start(new ArrSumData(arr1, arr2, arr3));
            Thread.Sleep(2000);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{arr1[i]} + {arr2[i]} = {arr3[i]}");
            }
        }

        static void GenerateIntRandomArrays(object obj)
        {
            if (obj is ArrRandData arr)
            {
                lock (locker)
                {
                    for (int i = 0; i < arr._arr.Length; i++)
                    {
                        arr._arr[i] = rand.Next(10);
                    }
                }
            }
        }

        static void SumIntArr(object obj)
        {
            if (obj is ArrSumData arr)
            {
                lock(locker)
                {
                    for (int i = 0; i < arr._arr1.Length; i++)
                    {
                        arr._resultArr[i] = arr._arr1[i]+arr._arr2[i];
                    }
                }

            }
        }
        private class ArrRandData
        {
            public int[] _arr;
            public ArrRandData(int[] arr)
            {
                _arr = arr;
            }
        }
        private class ArrSumData
        {
            public int[] _arr1;
            public int[] _arr2;
            public int[] _resultArr;

            public ArrSumData( int[] arr1, int[] arr2, int[] resultArr)
            {
                _arr1 = arr1;
                _arr2 = arr2;
                _resultArr = resultArr;
            }
        }
    }
}
