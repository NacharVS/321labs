using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class CancellationTokenExa
    {
        static CancellationTokenSource cancelTokenSource1 = new CancellationTokenSource();
        static CancellationTokenSource cancelTokenSource2 = new CancellationTokenSource();
        static CancellationTokenSource cancelTokenSource3 = new CancellationTokenSource();
        static CancellationToken token1 = cancelTokenSource1.Token;
        static CancellationToken token2 = cancelTokenSource2.Token;
        static CancellationToken token3 = cancelTokenSource3.Token;
        static Random random = new Random();
        static int[] arr = new int[10];
        static int sum = 0;
        static int division = 0;
        static long prod = 1;
        static string stop;

        static Task taskSum = new Task(() =>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 30);
            }
            
            Console.WriteLine("Arr");
            foreach (var item in arr)
            {
                if (token1.IsCancellationRequested)
                {
                    Console.WriteLine("Operation Sum aborted");
                    return;
                }

                Console.WriteLine("Sum: {0}",sum += item);
                Thread.Sleep(1000);
            }
        });

        static Task taskDiv = new Task(() =>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 30);
                division += arr[i];
            }
            while (division != 0)
            {
                if (token2.IsCancellationRequested)
                {
                    Console.WriteLine("Operation Division aborted");
                }
                division = division / 2;
                Console.WriteLine("Division: {0}", division);
                Thread.Sleep(1000);
            }
        });

        static Task taskProd = new Task(() =>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 30);
            }
            foreach (var item in arr)
            {
                if (token3.IsCancellationRequested)
                {
                    Console.WriteLine("Operation Product aborted");
                    return;
                }
                Console.WriteLine("Product: {0}", prod *= item);
                Thread.Sleep(1000);
            }
        });

        static public void Start()
        {
            Console.WriteLine("Choose which programm you want stop: 1 - Sum, 2 - Division, 3 - Product");
            taskSum.Start();
            taskDiv.Start();
            taskProd.Start();

            stop = Console.ReadLine();
            if (stop == "1")
                cancelTokenSource1.Cancel();
            if (stop == "2")
                cancelTokenSource2.Cancel();
            if (stop == "3")
                cancelTokenSource3.Cancel();

            taskSum.Wait();
            taskDiv.Wait();
            taskProd.Wait();
            
        }
    }
}
