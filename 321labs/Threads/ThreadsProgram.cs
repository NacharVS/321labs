using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace _321labs.Threads
{
    public class ThreadsProgram
    {
        public static void ThreadsMain()
        {
            int[] arr = new int[10] { 1, 2, 33, 44, 5, 3, 2, 4, 2, 4 };
            ArrayThreadData arrData = new ArrayThreadData(arr);
            Thread SumThread = new Thread(SumIntArray);
            Thread MaxThread = new Thread(MaxIntArray);
            Thread SortThread = new Thread(SortIntArray);
            SumThread.Start(arrData);
            MaxThread.Start(arrData);
            SortThread.Start(arrData);
        }

        static void SumIntArray(object obj)
        {
            if (obj is ArrayThreadData arrData)
            {
                int sum = 0;
                foreach (int i in arrData.arr)
                {
                    sum += i;
                }
                Console.WriteLine($"Sum Thread Work Result = {sum}");
            }
        }

        static void MaxIntArray(object obj)
        {
            if (obj is ArrayThreadData arrData)
            {
                int max = arrData.arr[0];
                foreach (int i in arrData.arr)
                {
                    if (max < i)
                    {
                        max = i;
                    }
                }
                Console.WriteLine($"Max Thread Work Result = {max}");
            }
        }

        static void SortIntArray(object obj)
        {
            if (obj is ArrayThreadData arrData)
            {
                Array.Sort(arrData.arr);
                foreach (int i in arrData.arr)
                {
                    Console.WriteLine(i);
                }
            }
        }


        private class ArrayThreadData
        {
            public int[] arr;

            public ArrayThreadData(int[] arr)
            {
                this.arr = arr;
            }
        }
    }
}
