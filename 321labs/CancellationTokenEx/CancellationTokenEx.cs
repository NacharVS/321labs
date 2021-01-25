using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _321labs;

namespace _321labs.CancellationTokenEx
{
    class CancellationTokenEx
    {
        private static int[] mas = new int[10];
        private static int a, b, c;
        private static int z = 3;
        private static int m1 = 1, m2 = 1, m3 = 1;
        private static Random r = new Random();

        public static void StartTask()
        {
            Console.WriteLine("Введите '1' для отмены операции массива или любую другую для её продолжения");
            Console.WriteLine("Введите '2' для отмены операции суммы или любую другую для её продолжения");
            Console.WriteLine("Введите '3' для отмены операци произведения или любую другую для её продолжения");
            Console.WriteLine();

            CancellationTokenSource cancelTokenSource1 = new CancellationTokenSource();
            CancellationToken token1 = cancelTokenSource1.Token;
            CancellationTokenSource cancelTokenSource2 = new CancellationTokenSource();
            CancellationToken token2 = cancelTokenSource2.Token;
            CancellationTokenSource cancelTokenSource3 = new CancellationTokenSource();
            CancellationToken token3 = cancelTokenSource3.Token;

            Task task1 = new Task(() => Array(token1));
            Task task2 = new Task(() => Sum(token2));
            Task task3 = new Task(() => Product(token3));
            task1.Start();
            Console.WriteLine($"Через 10 секунд запустится операция массива");
            task2.Start();
            Console.WriteLine($"Через 20 секунд запустится операция суммы");
            task3.Start();
            Console.WriteLine($"Через 30 секунд запустится операция произведения");

            for (; z > 0;)
            {
                string s = Console.ReadLine();

                if (s == "1" && m1 == 1)
                {
                    cancelTokenSource1.Cancel();
                    Console.WriteLine("Операция массива прервана");
                    Console.WriteLine();
                    m1--;
                    z--;
                }
                if (s == "2" && m2 == 1) 
                {
                    cancelTokenSource2.Cancel();
                    Console.WriteLine("Операция суммы прервана");
                    Console.WriteLine();
                    m2--;
                    z--;
                }
                if (s == "3" && m3 == 1) 
                {
                    cancelTokenSource3.Cancel();
                    Console.WriteLine("Операция произведения прервана");
                    Console.WriteLine();
                    m3--;
                    z--;
                }
            }
            return;
        }
        private static void Array(CancellationToken token1)
        {
            Thread.Sleep(10000);
            if (token1.IsCancellationRequested)
            {
                return;
            }
            Console.Write("Нужно заполнить данный массив: ");
            foreach (int item in mas)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                if (token1.IsCancellationRequested)
                {
                    return;
                }

                mas[i] = r.Next(1, 10);
                Console.WriteLine();
                foreach (int item in mas)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Массив заполнен");
            Console.WriteLine();
            m1--;
            z--;
        }
        private static void Sum(CancellationToken token2)
        {
            Thread.Sleep(20000);
            if (token2.IsCancellationRequested)
            {
                return;
            }
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            c = a + b;
            Console.WriteLine($"Сумма чисел {a} и {b} равен {c}");
            m2--;
            z--;
        }
        private static void Product(CancellationToken token3)
        {
            a = 1;
            Thread.Sleep(30000);
            for (int i = 0; i < mas.Length; i++)
            {
                if (token3.IsCancellationRequested)
                {
                    return;
                }

                b = r.Next(1, 5);
                c = a * b;
                Console.WriteLine($"{a} умножить на {b} равно {c}");
                a = c;             
            }
            m3--;
            z--;
        }
    }
}

