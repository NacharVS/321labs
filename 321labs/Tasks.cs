using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace _321labs
{
    class Tasks
    {
        public int[] arr = new int[4] { 4, 2, 3, 4 };
    
  


        public void Sorting()
        {
            Array.Sort(arr);
            Console.WriteLine("Отсортированная вещь: \n");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " \n");
            }
        }

        public void MaxThread()
        {
            int[] bufferArray = this.arr;
            Array.Sort(bufferArray);
            int max = bufferArray[bufferArray.Length - 1];
            Console.WriteLine($"Максимальный элемент - {max}\n");

        }

        public void SumArray()
        {
            int sum = 0;
                foreach (var item in arr)
                {
                    sum += item;
                }
         
            Console.WriteLine($"Сумма всех элементов равна {sum}\n");


        }
        public void Start()
        {
            Task theard = new Task(Sorting);
            Task theard1 = new Task(SumArray);
            Task thread2 = new Task(MaxThread);
            theard.Start();
            theard.Wait();
            theard1.Start();
            theard1.Wait();
            thread2.Start();
          
        }

    }
}
