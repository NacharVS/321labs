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
        static CancellationTokenSource cancelTokenSource1 = new CancellationTokenSource();
        static CancellationTokenSource cancelTokenSource2 = new CancellationTokenSource();
        static CancellationTokenSource cancelTokenSource3 = new CancellationTokenSource();
        

        static int[] mas = new int[10];
        static int a, b, c;
        static Random r = new Random();

         public static void Array()
        {

            CancellationToken token1 = cancelTokenSource1.Token;
            Console.WriteLine("Через 10 секунд запустится операция массива");
            Thread.Sleep(10000);
            Console.Write("Нужно заполнить данный массив: ");
            foreach (int item in mas)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //Thread.Sleep(2000);
            for (int i = 0; i < mas.Length; i++)
            {
                if (token1.IsCancellationRequested)
                {
                    Console.WriteLine("Операция массива прервана");
                    return;
                }

                mas[i] = r.Next(1, 10);
                Console.WriteLine();
                foreach (int item in mas)
                {
                    Console.Write($"{item} ");
                }
                // Thread.Sleep(1000);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Массив заполнен");
            Console.WriteLine();
            //Thread.Sleep(3000);
        }
        public static void Sum()
        {
            CancellationToken token2 = cancelTokenSource2.Token;
            Console.WriteLine("Через 20 секунд запустится операция суммы");
            Thread.Sleep(20000);
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            c = a + b;
            for (int i = 0; i < c; i++)
            {
                if (token2.IsCancellationRequested)
                {
                    Console.WriteLine("Операция суммы прервана");
                    return;
                }
            }

            Console.WriteLine($"Сумма чисел {a} и {b} равен {c}");
            //Thread.Sleep(3000);
        }
        public static void Product()
        {
            CancellationToken token3 = cancelTokenSource3.Token;
            Console.WriteLine("Через 30 секунд запустится операция произведения");
            Thread.Sleep(30000);
            a = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (token3.IsCancellationRequested)
                {
                    Console.WriteLine("Операция произведения прервана");
                    return;
                }

                b = r.Next(1, 5);
                c = a * b;
                Console.WriteLine($"{a} умножить на {b} равно {c}");
                a = c;
                //Thread.Sleep(3000);
            }
        }


        public static void StartTask()
        {
            Console.WriteLine("Введите '1' для отмены операции массива");
            Console.WriteLine("Введите '2' для отмены операции суммы");
            Console.WriteLine("Введите '3' для отмены операци произведения");
            Console.WriteLine();

            Task task1 = new Task(Array);
            Task task2 = new Task(Sum);
            Task task3 = new Task(Product);
            task1.Start();
            task2.Start();
            task3.Start();

            string s = Console.ReadLine();
            if (s == "1")
                cancelTokenSource1.Cancel();
            if (s == "2")
                cancelTokenSource2.Cancel();
            if (s == "3")
                cancelTokenSource3.Cancel();
            Console.Read();

        }



       
    }
}
