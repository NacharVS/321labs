using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class ContinuationTasks1
    {
        public static int[] array = new int[20];
        public static void RandomArr()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random rand = new Random();
                array[i] = rand.Next(20);
                Console.WriteLine(array[i]);
            }
        }
        public static void ProductArr()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i + 1];
                Console.WriteLine("Ответ: " + array[i]);
            }
        }
        public static void EvenArr()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int x = 0; x < array.Length; x++)
                    {
                        array[x] = i;
                        Console.WriteLine("Все четные числа:" + array[x]);
                    }
                }
            }
        }
        public static void TaskStart()
        {
            Task task = new Task(() => RandomArr());
            task.Start();
            Task task1 = task.ContinueWith(rand => ProductArr());
            Task task2 = task1.ContinueWith(array => EvenArr());

            Task.WaitAll(task, task1, task2);
        }

    }
}