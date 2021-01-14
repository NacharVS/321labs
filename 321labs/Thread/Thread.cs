using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Thread
{
    class Thread
    {
        public int[] array = { 1, 2, 5, 4, 7}; 
        int count;

        public Thread(int[] array)
        {
            array = array;
        }
        public void Sum(object obj)
        {
            int[] array = (int[])obj;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i];
            }
            Console.WriteLine(count);
        }
         public void Max(object obj)
         {
            int[] array = this.array;
            Array.Sort(array);
            int max = array[array.Length - 1];
            Console.WriteLine($"максимальный элемент: {max} ");
         }
        public void Sort()
        {
            Array.Sort(array);
            Console.WriteLine("Отсортированный элемент - ");
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }
        }

        public void Start()
        {
            Thread thread = new Thread(Sort);
            Thread thread1 = new Thread(Sum);
            Thread thread2 = new Thread(Max);
            thread.Start();
            thread1.Start();
        }
    }
}           
