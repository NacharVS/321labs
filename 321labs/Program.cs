using _321labs.Kamalov.Game;
using System;
using System.Threading;
using System.Collections.Generic;
using _321labs.Kamalov.ThreadLocker;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Task TaskSum = new Task(() =>
            {
                int[] mas = new int[10];
                Random r = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(0, 10);
                    Thread.Sleep(500);
                }
                int a = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("Сумма");
                    a += mas[i];
                    Console.WriteLine(a);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            });
            Task TaskMax = new Task(() =>
            {
                int[] mas = new int[10];
                Random r = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(0, 10);
                    Thread.Sleep(500);
                }
                int b = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("Max");
                    if (b < mas[i])
                    {
                        b = mas[i];
                    }

                    Console.WriteLine(b);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            });
            Task TaskSort = new Task(() =>
            {
                int[] mas = new int[10];
                Random r = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(0, 10);
                    Thread.Sleep(500);
                }
                int c;
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            c = mas[i];
                            mas[i] = mas[j];
                            mas[j] = c;
                            Console.WriteLine($"{mas[i]}");
                            Thread.Sleep(100);
                        }
                    }
                }
                Console.WriteLine("Сортировка");
                Console.WriteLine();
            });
            TaskSum.Start();
            TaskMax.Start();
            TaskSort.Start();
            TaskMax.Wait();
            TaskSort.Wait();
        }
    }
}