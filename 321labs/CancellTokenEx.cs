using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class CancellTokenEx
    {
        static int[] numbers = { 2, 5, 4, 1, 10 };

        public static void Sum()
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            Console.WriteLine("Sum:" + sum);
            Thread.Sleep(3000);
        }

        public static void Max()
        {
            int max = 0;
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("Max: " + max);
            Thread.Sleep(2000);
        }

        public static void SortArray()
        {
            Thread.Sleep(5000);
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }

        public static void Start()
        {
            CancellationTokenSource token1 = new CancellationTokenSource();
            CancellationTokenSource token2 = new CancellationTokenSource();
            CancellationTokenSource token3 = new CancellationTokenSource();

            Task t1 = new Task(Sum);
            Task t2 = new Task(Max);
            Task t3 = new Task(SortArray);
            t1.Start();
            t2.Start();
            t3.Start();

            int num = Convert.ToInt32(Console.ReadKey());
            switch (num)
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
            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
