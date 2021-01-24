using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _321labs.Lovkov
{
    class CancellationTokenEx
    {
        static public CancellationTokenSource cancelToken = new CancellationTokenSource();
        public CancellationToken token = cancelToken.Token;
        static public CancellationTokenSource cancelToken1 = new CancellationTokenSource();
        public CancellationToken token1 = cancelToken1.Token;
        int a = 0;
        int b = 0;
        int c = 0;
        int sum;
        long prod = 1;
        public void ValuesInput()
        {
            Console.WriteLine("Введите первое целое значение: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое значение: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine($"\nВведите символ запускающий поток");
                Console.WriteLine($"'a' - Sum,'b' - Product, 'c' - Чтобы перейти к отмене потоков\n");
                string a = Console.ReadLine();
                if (a == "a")
                {
                    Task task1 = new Task(Sum);
                    task1.Start();
                }
                if (a == "b")
                {
                    Task task3 = new Task(Product);
                    task3.Start();
                }
                if (a == "c")
                {
                    Console.WriteLine("Далее");
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine($"\nВведите символ останавливающий один из потоков");
                Console.WriteLine($"1 - Sum,  2 - Product, 3 - Чтобы закончить остановки потоков\n");
                string s = Console.ReadLine();
                if (s == "1")
                    cancelToken.Cancel();
                if (s == "2")
                    cancelToken1.Cancel();
                if (s == "3")
                {
                    Console.WriteLine("Вы вышли из остановок потоков");
                    break;
                }
            }
        }

        public void Product()
        {
            for (int i = 0; i < c; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Prod canceled");
                    return;
                }
                prod = a * b;
                Console.WriteLine($"Product {prod}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Произведние чисел {a} и {b} равно: {c}");
        }

        public void Sum()
        {
            for (int i = 0; i < c; i++)
            {
                if (token1.IsCancellationRequested)
                {
                    Console.WriteLine("Sum canceled");
                    return;
                }
                sum = a + b;
                Console.WriteLine($"Sum {sum}");
                Thread.Sleep(2000);
            }
            Console.WriteLine($"Сумма чисел {a} и {b} равно: {c}");
        }

        public void StartTaskGroup()
        {
            Task task1 = new Task(ValuesInput);
            Task task2 = new Task(Product);
            Task task3 = new Task(Sum);
        }


    }
}

