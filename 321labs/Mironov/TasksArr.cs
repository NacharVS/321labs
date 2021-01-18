using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Mironov
{
    class TasksArr
    {
        private int[] arr;

        public int[] Arr { get => arr; set => arr = value; }

       

        public TasksArr(int[] arr)
        {
            this.Arr = arr;
        }

        public void Start()
        {
            Task threadSort = new Task(SortArr);
            Task threadMax = new Task(MaxArr);
            Task threadSum = new Task(SumArr);
            threadSum.Start();
            threadMax.Start();
            threadSort.Start();
            Task.WaitAny(threadSum, threadMax, threadSort);


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
            foreach (var item in this.Arr)
            {
                sum += item;
            }
            Console.WriteLine("Sum array is " + sum);
        }
        public void SortArr()
        {
            Array.Sort(this.Arr);
            foreach (var item in this.Arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}

