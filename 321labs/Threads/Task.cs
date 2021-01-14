using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    class Task
    {
        public int[] Mas;
        int sum;
        int o;
        int p;
        public Task(int[] mas)
        {
            Mas = mas;
        }
        public void TaskSum(object obj)
        {
            int[] mas = (int[])obj;

            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
                Console.WriteLine($"Находим сумму {sum}");
            }
            Console.WriteLine($"Ваша сумма {sum}");
            Thread.Sleep(10);
        }
        public void MasMax(object obj)
        {
            int[] mas = (int[])obj;
            for (int i = 0; i < mas.Length; i++)
            {
                o = mas[i];
                if (o > p)
                {
                    p = o;
                    Console.WriteLine($"Находм максимум {p}");
                }
                Thread.Sleep(10);
            }
            Console.WriteLine($"Ваш максимум максимум {p}");
        }
        public void MasSort(object obj)
        {
            int[] mas = (int[])obj;
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                        Console.WriteLine($"Сортируем {temp}");
                        Thread.Sleep(10);
                    }
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Отсортировали {mas[i]}");
                Thread.Sleep(10);
            }
        }
    }
}
