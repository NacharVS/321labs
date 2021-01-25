﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Canseltas
{
    class CancellationTokenEx
    {

        public static void Start()
        {
            CancellationTokenSource cancelTokenSource1 = new CancellationTokenSource();
            CancellationTokenSource cancelTokenSource2 = new CancellationTokenSource();
            CancellationTokenSource cancelTokenSource3 = new CancellationTokenSource();

            CancellationToken token1 = cancelTokenSource1.Token;
            CancellationToken token2 = cancelTokenSource2.Token;
            CancellationToken token3 = cancelTokenSource3.Token;
            Console.WriteLine("Введите число над которым будут делать операции");
   
            int x = Convert.ToInt32(Console.ReadLine());

            Task task1 = new Task(() => Fibanchi(x, token1));
            Task task2 = new Task(() => Factorial(x, token2));
            Task task3 = new Task(() => Deegree(x, token3));

            task1.Start();
            task2.Start();
            task3.Start();

            while (true)
            {
                Console.WriteLine("Введите номер операции  для её отмены :");
                string s = Console.ReadLine();
                if (s == "1")
                    cancelTokenSource1.Cancel();
                if (s == "2")
                    cancelTokenSource2.Cancel();
                if (s == "3")
                    cancelTokenSource3.Cancel();
                if (token1.IsCancellationRequested && token2.IsCancellationRequested && token3.IsCancellationRequested)
                {
                    break;
                }
            }

            task1.Wait();
            task2.Wait();
            task3.Wait();

        }

        public static void Fibanchi(int x, CancellationToken token)
        {
            int j = 1;
            for (int i = 1; i <= x; i += j)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция фибаначи прервана ");
                    return;
                }
                Console.WriteLine($"{i} элемент фибначи = {i}");
                j = i - j;
                Thread.Sleep(1000);
            }


        }
        public static void Factorial(int x, CancellationToken token)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция факториал прервана ");
                    return;
                }

                result *= i;
                Console.WriteLine($"Факториал числа {x} равен {result}");
                Thread.Sleep(1500);
            }
        }

        public static void Deegree(int x, CancellationToken token)
        {
            int sum = x;
            int i = 2;
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция степени прервана ");
            }
            while (token.IsCancellationRequested == false)
            {
                sum *= x;
                Console.WriteLine($"{i} степень числа {x} равен {sum}");
                i++;
                Thread.Sleep(500);
            }
        }

    }
}