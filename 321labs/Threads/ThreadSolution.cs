using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    class ThreadSolution
    {
        int[] array;
        public int[] IntArray { get => array; set => array = value; }

        public ThreadSolution(int[] array)
        {
            this.array = array;
        }

        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                sum += this.array[i];
            }
            Console.WriteLine("Сумма:" + sum);
        }

        public void Max()
        {
            int max = this.array[0];
            for (int i = 1; i < this.array.Length; i++)
            {
                if (this.array[i] > max)
                {
                    max = this.array[i];
                }
            }
            Console.WriteLine("Максимальное число:" + max);
        }

        public void Sort()
        {
            Array.Sort(this.array);
            Console.Write("Отсортированный массив");
            foreach (var item in this.array)
            {
                Console.Write(item+" ");
            }
        }
       
    }
}
