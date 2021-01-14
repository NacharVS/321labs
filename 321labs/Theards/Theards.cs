using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.TheardArray
{
    class Theards
    {
        int[] arr = new int[4] { 1, 2, 3, 4 };
        public int[] Arr
        {
            get;
            set;
        }
        Thread SortArrayThread;
        Thread MaxArrayThread;
        Thread SumArrayThread;
        
        
        public void Sorting()
        {
            Array.Sort(arr);
            Console.WriteLine("Отсортированная вещь: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }

        public void MaxThread()
        {
            int[] bufferArray = this.Arr;
            Array.Sort(bufferArray);
            int max = bufferArray[bufferArray.Length - 1];
            Console.WriteLine($"Максимальный элемент - {max}/n");
                                                        
        }

        public void SumArray()
        {
            int sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var item in arr)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Сумма всех элементов равна {sum}");
            

        }
        public void Start()
        {
            Thread theard = new Thread(Sorting);
            Thread theard1 = new Thread(SumArray);
            Thread thread2 = new Thread(MaxThread);
            theard.Start();
            theard1.Start();
            //Thread theard2 = new Thread(Sorting);
        }
    }
}
