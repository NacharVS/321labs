using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs.Tasks
{
    class Tasks
    {
        int[] arr;
        Task sumTask;
        Task maxElemTask;
        Task sortingTask;
        public int[] Arr { get => this.arr; set => this.arr = value; }

        public Tasks(int[] array)
        {
            this.arr = array;
        }

        public void StartTasks()
        {
            sumTask = new Task(ElementSum);
            maxElemTask = new Task(MaxElement);
            sortingTask = new Task(ArraySort);
            sumTask.Start();
            maxElemTask.Start();
            sortingTask.Start();
            sumTask.Wait();
            maxElemTask.Wait();
            sortingTask.Wait();
        }

        void ElementSum()
        {
            int sum = 0;
            foreach (var item in this.arr)
            {
                sum += item;
            }
            Thread.Sleep(200);
            Console.WriteLine($"Sum of array elements:{sum}");
            Console.WriteLine();
        }
        void MaxElement()
        {
            int[] bufferArray = this.arr;
            Array.Sort(bufferArray);
            int max = bufferArray[bufferArray.Length - 1];
            Thread.Sleep(300);
            Console.WriteLine($"Max element value: {max}");
            Console.WriteLine();
        }
        void ArraySort()
        {
            Array.Sort(this.arr);
            Thread.Sleep(400);
            Console.Write("Sorted array: ");
            foreach (var item in this.arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

