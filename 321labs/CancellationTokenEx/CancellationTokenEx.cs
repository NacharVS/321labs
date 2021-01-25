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
        private static Random r = new Random();

        private static void Array(CancellationToken token1)
        {
            Console.WriteLine("Через 5 секунд запустится операция массива");
            Thread.Sleep(5000);
            if (token1.IsCancellationRequested)
                return;
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
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Массив заполнен");
            Console.WriteLine();
            z--;
        }
        private static void Sum(CancellationToken token2)
        {
            Console.WriteLine("Через 10 секунд запустится операция суммы");
            if (token2.IsCancellationRequested)
                return;
            Thread.Sleep(10000);
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            c = a + b;
            Console.WriteLine($"Сумма чисел {a} и {b} равен {c}");
            z--;
        }
        private static void Product(CancellationToken token3)
        {
            Console.WriteLine("Через 15 секунд запустится операция произведения");
            Thread.Sleep(15000);
            a = 1;
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
                z--;
            }
        }

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
            task2.Start();
            task3.Start();

            for (; z > 0;)
            {
                string s = Console.ReadLine();
                if (s == "1")
                {
                    cancelTokenSource1.Cancel();
                    Console.WriteLine("Операция массива прервана");
                    z--;
                }
                if (s == "2")
                {
                    cancelTokenSource2.Cancel();
                    Console.WriteLine("Операция суммы прервана");
                    z--;
                }
                if (s == "3")
                {
                    cancelTokenSource3.Cancel();
                    Console.WriteLine("Операция произведения прервана");
                    z--;
                }
                task1.Wait();
                task2.Wait();
                task3.Wait();
            }
        }
    }
}
