using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class CancellationTokenEx
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static CancellationTokenSource token1 = new CancellationTokenSource();
        static CancellationTokenSource token2 = new CancellationTokenSource();
        static CancellationTokenSource token3 = new CancellationTokenSource();

        public void Start()
        {
            Task task1 = new Task(Generic);
            Task task2 = new Task(Sum);
            Task task3 = new Task(ShowEven);
            task1.Start();
            task2.Start();
            task3.Start();
            

            string str = Console.ReadLine();
            int[] arrayInt = {1, 2, 3};
            int[] arrayIntR = str.Split(' ').Select(int.Parse).ToArray();
            IEnumerable<int> arrayToken = arrayInt.Except(arrayIntR); 

            foreach (int item in arrayToken)
            {
                switch (item)
                {
                    case 1:
                        token1.Cancel();
                        break;

                    case 2:
                        token2.Cancel();
                        break;

                    case 3:
                        token3.Cancel();
                        break;
                }
            }

            task1.Wait();
            task2.Wait();
            task3.Wait();
        }
        void Generic()
        {
            if (token1.IsCancellationRequested) return;

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.WriteLine("Сгенерировался " + array[i]);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        void Sum()
        {
            if (token2.IsCancellationRequested) return;

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Thread.Sleep(1000);
            }
            Console.WriteLine("Сумма массива: " + sum);
        }

        void ShowEven()
        {
            if (token3.IsCancellationRequested) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("Четные цифры:" + array[i]);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
