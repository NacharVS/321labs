using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs
{
    class ThreadUltimate
    {
        int[] array;

        public int[] Array { get => array; set => array = value; }

        public ThreadUltimate(int[] array)
        {
            this.Array = array;
        }

        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum of all array elements: {0}", sum);
        }

        public void Max()
        {
            int maxElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElements)
                {
                    maxElements = array[i];
                }
            }
            Console.WriteLine("Max element of array: {0}", maxElements);
        }

        public void Sort()
        {
            Console.Write("Sort of array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }

        public void ThreadStart()
        {
            Thread threadSum = new Thread(new ThreadStart(Sum));
            Thread threadMax = new Thread(new ThreadStart(Max));
            Thread threadSort = new Thread(new ThreadStart(Sort));

            threadSum.Start();
            threadMax.Start();
            Thread.Sleep(100);
            threadSort.Start();
        }
    }
}
