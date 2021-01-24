using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class CancelationTokenLab
    {
        public static void Start(int arg)
        {
            string input;
            while (true)
            {
                CancellationTokenSource cancelTokenSource1 = new CancellationTokenSource();
                CancellationTokenSource cancelTokenSource2 = new CancellationTokenSource();
                CancellationTokenSource cancelTokenSource3 = new CancellationTokenSource();
                CancellationToken token1 = cancelTokenSource1.Token;
                CancellationToken token2 = cancelTokenSource2.Token;
                CancellationToken token3 = cancelTokenSource3.Token;

                input = Console.ReadLine(); //цыфрами 1-3 можно преравть работающий в данный момент поток (писать слитно)
                var t1 = new Task(() => Exp(arg, token1));
                t1.Start();
                var t2 = new Task(() => Factorial(arg, token2));
                t2.Start();
                var t3 = new Task(() => NaturalLog(arg, token3));
                t3.Start();

                foreach (var item in input)
                {
                    if (item == '1')
                    {
                        cancelTokenSource1.Cancel();
                    }
                    else if (item == '2')
                    {
                        cancelTokenSource2.Cancel();
                    }
                    else if (item == '3')
                    {
                        cancelTokenSource3.Cancel();
                    }
                }
                t1.Wait();
                t2.Wait();
                t3.Wait();
            }
        }

        public static void Exp(int exp, CancellationToken token)
        {
            for (int i = 0; i < 9; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Экспонента отменена");
                    return;
                }
                Thread.Sleep(500);
            }
            Console.WriteLine(Math.Exp(exp));
        }

        public static void Factorial(int number, CancellationToken token)
        {
            long factorial = 1;
            for (int i = 1; i < number + 1; i++)
            {
                factorial *= i;
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Факториал отменён");
                    return;
                }
                Thread.Sleep(500);
            }
            Console.WriteLine(factorial);
        }

        public static void NaturalLog(int number, CancellationToken token)
        {
            for (int i = 0; i < 5; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Натуральный логарифм отменён");
                    return;
                }
                Thread.Sleep(500);
            }
            Console.WriteLine(Math.Log(number));
        }
    }
}
