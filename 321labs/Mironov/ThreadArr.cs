using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Mironov.Threads
{
    class ThreadArr
    {
        private int[] arr;

        public int[] Arr { get => arr; set => arr = value; }

        public ThreadArr(int[] arr)
        {
            this.Arr = arr;
        }

        public void Start()
        {
            Thread threadSort = new Thread(new ThreadStart(SortArr));
            Thread threadMax = new Thread(new ThreadStart(MaxArr));
            Thread threadSum = new Thread(new ThreadStart(SumArr));
            threadSum.Start();
            threadMax.Start();
            threadSort.Start();
         
           
        }

        public void MaxArr()
        {
                int max = 0;
                for (int i = 0; i < this.Arr.Length; i++)
                {
                    if (max <= this.Arr[i])
                    {
                        max = this.Arr[i];
                    }
                }
                Console.WriteLine("Max num in array is " + max);
            }
        public void SumArr()
        {
            int sum = 0;
            foreach(var item in this.Arr)
            {
                sum += item;
            }
            Console.WriteLine("Sum array is " + sum);
        }
        public void SortArr()
        {
            Array.Sort(this.Arr);
            foreach(var item in this.Arr)
            {
                Console.Write(item+" ");
            }
        }

    }
        

       


    
}
