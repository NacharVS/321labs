using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Mironov
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
            Console.WriteLine("1-Фибаначи 2-Факториал  3-Степень");

            int x = Convert.ToInt32(Console.ReadLine());
            Task task1 = new Task(() => Fibanchi(x, token1));
            Task task2 = new Task(() => Factorial(x, token2));
            Task task3 = new Task(() => Deegree(x, token3));

            task1.Start();
            task2.Start();
            task3.Start();
       
            Console.WriteLine("Введите номер операции  для её отмены операции или любой другой символ для ее продолжения:");
            string s = Console.ReadLine();
            if (s == "1")
                cancelTokenSource1.Cancel();
            if (s == "2")
                cancelTokenSource2.Cancel();
            if (s == "3")
                cancelTokenSource3.Cancel();
        }

        public static void Fibanchi(int x, CancellationToken token)
        {
            int j = 1;
            for (int i = 1; i <= x; i+=j)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
                Console.WriteLine($"{i} элемент фибначи = {i}");
                j = i - j;
                Thread.Sleep(1500);
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
                Thread.Sleep(1000);
            }
        }

        public static void Deegree(int x, CancellationToken token)
        {
            int sum = x;
            int i = 2;
            while (token.IsCancellationRequested==false)
            {
                sum *= x;
                Console.WriteLine($"{i} степень числа {x} равен {sum}");
                i++;
                Thread.Sleep(500);
            }
        }

    }
}
