using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Thread
{
    class ThreadArr
    {
        private int[] arr;

        public ThreadArr(int[] arr)
        {
            this.Arr = arr;
        }

        public int[] Arr { get => arr; set => arr = value; }

        public void MaxArr(object threadArr)
        {
            if (threadArr is ThreadArr)
            {
                int max = 0;
                for (int i = 0; i < threadArr.Arr.Length; i++)
                {
                    if (max <= threadArr.Arr[i])
                    {
                        max = threadArr.Arr[i];
                    }
                }
                Console.WriteLine("Max num in array is " + max);
            }
        }
        public void SumArr(ThreadArr threadArr)
        {
            int sum = 0;
            foreach(var item in threadArr.Arr)
            {
                sum += item;
            }
            Console.WriteLine("Sum array is "+ sum);
        }

        public void SortArr(ThreadArr threadArr)
        {
            Array.Sort(threadArr.Arr);
        }


    }
}
