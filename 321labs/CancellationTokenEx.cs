using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs
{
    class CancellationTokenEx
    {
        Random rnd = new Random();
        CancellationTokenSource cancellationTokenSource1 = new CancellationTokenSource();
        CancellationTokenSource cancellationTokenSource2 = new CancellationTokenSource();
        CancellationTokenSource cancellationTokenSource3 = new CancellationTokenSource();


        Task FirstTask;
        Task SecondTask;
        Task ThirdTask;
        int[] array = { 2, 3, 4, 2, 3, 1, 2, 3, 4, 3 };
        
        void ArrayProduct()
        {
            CancellationToken token = cancellationTokenSource1.Token;
            long product = 1;
            foreach (var item in array)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                product *= item;
                Console.WriteLine($"Product of array is: {product}");
                Thread.Sleep(1000);
            }
        }
        void ArrayElementsSum()
        {
            CancellationToken token = cancellationTokenSource2.Token;
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                sum += array[i];
                
                Console.WriteLine($"Sum of array is: {sum}");
                Thread.Sleep(3000);
            }
        }
        void ArrayElementsDif()
        {
            CancellationToken token = cancellationTokenSource3.Token;
            long dif = array[1];
            for (int i = 1; i < array.Length; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                dif -= array[i];

                Console.WriteLine($"Difference of array is: {dif}");
                Thread.Sleep(5000);
            }
        }
        public void Start()
        {
            FirstTask = new Task(ArrayProduct);
            FirstTask.Start();
            SecondTask = new Task(ArrayElementsSum);
            SecondTask.Start();
            ThirdTask = new Task(ArrayElementsDif);
            ThirdTask.Start();
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Operation 1 canceled");
                    cancellationTokenSource1.Cancel();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Operation 2 canceled");
                    cancellationTokenSource2.Cancel();
                }
                else if(input == "3")
                {
                    Console.WriteLine("Operation 3 canceled");
                    cancellationTokenSource3.Cancel();
                }
            }
            FirstTask.Wait();
            SecondTask.Wait();
            ThirdTask.Wait();
        }

        
    }
}
