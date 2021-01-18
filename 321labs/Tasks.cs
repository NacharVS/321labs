using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Tasks
    {
        static int[] array = new int[10];
        static int sumResult;
        static int maxResult;
        static int[] oldArray;
        static Random rnd = new Random();

        static Tasks()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            Task task = new Task(Start);
            task.Start();
        }
        static void Start()
        {
            Task sum = new Task(() =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sumResult += array[i];
                }
                Console.WriteLine("Сумма:" + sumResult);
            });

            Task max = new Task(() =>
            {
                maxResult = array[1];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxResult)
                    {
                        maxResult = array[i];
                    }
                }
                Console.WriteLine("Максимальный: " + maxResult);
            });

            Task sort = new Task(() =>
            {
                oldArray = array;
                Array.Sort(array);
                Console.Write("Старый массив:");
                foreach (var item in oldArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                Console.Write("Отсртированный:");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }

            });
            max.Start();
            sum.Start();
            sort.Start();

            max.Wait();
            sum.Wait();
            sort.Wait();

        }

    }
}
