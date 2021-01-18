using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class Tasks
    {
        static int[] array = new int[10];


        public void Start()
        {
            Generic();
            Task task1 = new Task(Max);
            Task task2 = new Task(Sum);
            Task task3 = new Task(Sort);

            task1.Start();
            task2.Start();
            task3.Start();
            task1.Wait();
            task2.Wait();
            task3.Wait();
        }

        void Generic()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
        }

        void Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine("Max = " + max);
        }

        void Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine("Sum = " + sum);
        }

        void Sort()
        {
            Array.Sort(array);
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }
    }
}
