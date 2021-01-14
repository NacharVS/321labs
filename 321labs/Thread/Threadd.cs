using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Thread
{
    class Threadd
    {
        public void ThreadSum(Object obj)
        {
            int[] mas = { 42, 12, 58, 71, 2, 82, 99, 3, 31, 15 };
            mas = (int[])obj;
            int a = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Сумма элементов:");
                a += mas[i];
                Console.WriteLine(a);
                Thread.Sleep(1000);
            }
        }

        public void ThreadMax(Object obj)
        {
            int[] mas = { 42, 12, 58, 71, 2, 82, 99, 3, 31, 15 };
            mas = (int[])obj;
            int b = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Максимальный элемент:");
                if (b < mas[i])
                {
                    b = mas[i];
                }

                Console.WriteLine(b);
                Thread.Sleep(1000);
            }
        }
        public void ThreadSort(Object obj)
        {
            int[] mas = { 42, 12, 58, 71, 2, 82, 99, 3, 31, 15 };
            mas = (int[])obj;
            int c;
            Console.WriteLine($"Массив который мы будем сортировать: {mas}");
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        c = mas[i];
                        mas[i] = mas[j];
                        mas[j] = c;
                        Console.WriteLine($"{mas}");
                        Thread.Sleep(100);
                    }
                }
            }
            Console.WriteLine("Сортировка завершена");
        }
    }
}

