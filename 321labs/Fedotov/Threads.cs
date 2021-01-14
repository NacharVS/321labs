using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Fedotov
{
    class Threads
    {
        int[] array;

        public Threads(int[] mass)
        {
            array = mass;
        }

        public void Start()
        {
            Thread threadMax = new Thread(new ThreadStart(Max));
            Thread threadSum = new Thread(new ThreadStart(Sum));
            Thread threadSort = new Thread(new ThreadStart(Sort));
            threadMax.Start();
            threadSum.Start();
            threadSort.Start();
        }

        void Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            Console.WriteLine("Max="+max);
        }

        void Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine("Sum=" + sum);
        }

        void Sort()
        {
            Array.Sort(array);
            foreach (int item in array)
            {
                Console.Write(item+" ");
            }
        }
    }
}
