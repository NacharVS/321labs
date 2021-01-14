using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Garifullin.Threads
{
    class ThreadArray
    {
        int sum;
        int b;
        int temp;
        public ThreadArray()
        {
            
        }
        public void ArrSum(object obj)
        {
            int[] vs = (int[])obj;

            for (int i = 0; i < vs.Length; i++)
            {
                sum += vs[i];
                Console.WriteLine($"Нахождение суммы {sum}");
            }
            Console.WriteLine($"Итого сумма {sum}");
            Thread.Sleep(10);
        }
        public void MaxArr(object obj)
        {
            int[] vs = (int[])obj;
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] > b)
                {
                    b = vs[i];
                    Console.WriteLine($"Нахождение максимума {b}");
                }
                Thread.Sleep(10);
            }
            Console.WriteLine($"Итоговый максимум {b}");
        }
        public void Comparer(object obj)
        {
            int[] vs = (int[])obj;
            for (int i = 0; i < vs.Length - 1; i++)
            {
                for (int j = i + 1; j < vs.Length; j++)
                {
                    if (vs[i] > vs[j])
                    {
                        temp = vs[i];
                        vs[i] = vs[j];
                        vs[j] = temp;
                        Console.WriteLine($"Сортировка {vs[i]}");
                        Console.WriteLine($"Сортировка {vs[j]}");
                        Thread.Sleep(10);
                    }
                }
            }
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine($"Итого сортировки {vs[i]}");
                Thread.Sleep(10);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = {-1, 1, 2, 231, -3, 4, 7, 22, 512 };

            ThreadArray arr = new ThreadArray();
            Thread thread = new Thread(new ParameterizedThreadStart(arr.ArrSum));
            Thread thread1 = new Thread(new ParameterizedThreadStart(arr.MaxArr));
            Thread thread12 = new Thread(new ParameterizedThreadStart(arr.Comparer));


            thread.Start(m);
            thread1.Start(m);
            thread12.Start(m);
        }
    }
}
