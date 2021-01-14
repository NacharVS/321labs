using System;
using System.Threading;

namespace _321labs.Treads
{
    public class Threads
    {
        int[] arr;
        Thread sumThread;
        Thread maxElemThread;
        Thread sortingThread;
        public int[] Arr { get => this.arr; set => this.arr = value; }

        public Threads(int[] array)
        {
            this.arr = array;
        }

        public void StartThreads()
        {
            sumThread = new Thread(new ThreadStart(ElementSum));
            maxElemThread = new Thread(new ThreadStart(MaxElement));
            sortingThread = new Thread(new ThreadStart(ArraySort));
            sumThread.Start();
            maxElemThread.Start();
            sortingThread.Start();
        }

        void ElementSum()
        {
            int sum = 0;
            foreach (var item in this.arr)
            {
                sum += item;
            }
            Thread.Sleep(100);
            Console.WriteLine($"Sum of array elements:{sum}");
            Console.WriteLine();
        }
        void MaxElement()
        {
            int[] bufferArray = this.arr;
            Array.Sort(bufferArray);
            int max = bufferArray[bufferArray.Length - 1];
            Thread.Sleep(200);
            Console.WriteLine($"Max element value: {max}");
            Console.WriteLine();
        }
        void ArraySort()
        {
            Array.Sort(this.arr);
            Thread.Sleep(300);
            Console.Write("Sorted array: ");
            foreach (var item in this.arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
