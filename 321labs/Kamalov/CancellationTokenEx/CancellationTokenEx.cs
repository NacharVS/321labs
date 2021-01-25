using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Kamalov.CancellationTokenEx
{
    class CancellationTokenEx
    {
        private static int[] arr = new int[10];
        private static int y, u, k;
        private static int z = 3;
        private static int t1 = 1, t2 = 1, t3 = 1;
        private static Random r = new Random();

        public static void StartTask()
        {
            Console.WriteLine("Enter '1' to cancel the array operation");
            Console.WriteLine("Enter '2' to cancel the transaction amount");
            Console.WriteLine("Enter '3' to cancel the play operation");

            CancellationTokenSource cancelTokenSourceOne = new CancellationTokenSource();
            CancellationToken tokenOne = cancelTokenSourceOne.Token;
            CancellationTokenSource cancelTokenSourceTwo = new CancellationTokenSource();
            CancellationToken tokenTwo = cancelTokenSourceTwo.Token;
            CancellationTokenSource cancelTokenSourceThree = new CancellationTokenSource();
            CancellationToken tokenThree = cancelTokenSourceThree.Token;

            Task task1 = new Task(() => Array(tokenOne));
            Task task2 = new Task(() => Sum(tokenTwo));
            Task task3 = new Task(() => Product(tokenThree));
            task1.Start();
            Console.WriteLine($"After 10 seconds the array operation will start");
            task2.Start();
            Console.WriteLine($"After 20 seconds, the sum operation will start");
            task3.Start();
            Console.WriteLine($"After 30 seconds, the product operation will start");

            for (; z > 0;)
            {
                string s = Console.ReadLine();

                if (s == "1" && t1 == 1)
                {
                    cancelTokenSourceOne.Cancel();
                    Console.WriteLine("Array operation aborted");
                    t1--;
                    z--;
                }
                if (s == "2" && t2 == 1)
                {
                    cancelTokenSourceTwo.Cancel();
                    Console.WriteLine("Amount operation aborted");
                    t2--;
                    z--;
                }
                if (s == "3" && t3 == 1)
                {
                    cancelTokenSourceThree.Cancel();
                    Console.WriteLine("Product operation interrupted");
                    t3--;
                    z--;
                }
            }
            return;
        }
        private static void Array(CancellationToken tokenOne)
        {
            Thread.Sleep(10000);
            if (tokenOne.IsCancellationRequested)
            {
                return;
            }
            Console.Write("You need to fill this array: ");
            foreach (int item in arr)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (tokenOne.IsCancellationRequested)
                {
                    return;
                }

                arr[i] = r.Next(1, 10);
                Console.WriteLine();
                foreach (int item in arr)
                {
                    Console.Write($"{item}");
                }

            }
            Console.WriteLine("The array is full");
            t1--;
            z--;
        }
        private static void Sum(CancellationToken tokenTwo)
        {
            Thread.Sleep(20000);
            if (tokenTwo.IsCancellationRequested)
            {
                return;
            }
            y = r.Next(1, 10);
            u = r.Next(1, 10);
            k = y + u;
            Console.WriteLine($"The sum of the numbers {y} and {u} is equal to {k}");
            t2--;
            z--;
        }
        private static void Product(CancellationToken tokenThree)
        {
            y = 1;
            Thread.Sleep(30000);
            for (int i = 0; i < arr.Length; i++)
            {
                if (tokenThree.IsCancellationRequested)
                {
                    return;
                }

                u = r.Next(1, 5);
                k = y * u;
                Console.WriteLine($"{y} times {u} equals {k}");
                y = k;
            }
            t3--;
            z--;
        }
    }
}