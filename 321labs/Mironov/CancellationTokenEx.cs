using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Mironov
{
    class CancellationTokenEx
    {

        public static void Start()
        {

        }

        public static void Fibanchi(int x, CancellationToken token)
        {
            for (int i = 0; i < x; i++)
            {
                if (i==0)
                {
                    Console.WriteLine($"{i+1} элемент фибанначи = ");
                }
            }


        }
        public static void Factorial(int x, CancellationToken token)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }

                result *= i;
                Console.WriteLine($"Факториал числа {x} равен {result}");
                Thread.Sleep(5000);
            }
        }

        public static void Deegree(int x, CancellationToken token)
        {
            int sum = x;
            int i = 2;
            while (token.IsCancellationRequested)
            {
                sum *= x;
                Console.WriteLine($"{i} степень числа {x} равен {sum}");
                i++;
                Thread.Sleep(2000);
            }
        }

    }
}
