using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace _321labs.Garifullin.Locks
{
    class CreateLocker
    {
        private static object locker = new object();

        static int[] firstArr = new int[10];
        static int[] secondArr = new int[10];
        static int[] sum = new int[10];
        
        public void First()
        {
            lock (locker)
            {
                Random rand = new Random();

                for (int i = 0; i < firstArr.Length; i++)
                {
                    firstArr[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i + 1} элемент первого массива {firstArr[i]}");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }
        }
        public void Last()
        {
            lock (locker)
            {
                Random rand = new Random();

                for (int i = 0; i < secondArr.Length; i++)
                {
                    secondArr[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i + 1} элемент второго массива {secondArr[i]}");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }
        }
        public void Sum()
        {
            lock (locker)
            {
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = firstArr[i] + secondArr[i];
                    Console.WriteLine($"Сумма {i + 1} элементов: {sum[i]}");
                    Thread.Sleep(10);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            CreateLocker createLocker = new CreateLocker();
            Thread thread = new Thread(createLocker.First);
            Thread thread1 = new Thread(createLocker.Last);
            Thread thread2 = new Thread(createLocker.Sum);

            thread.Start();
            thread1.Start();
            lock (locker)
            {
                thread2.Start();
            }
        }
    }
}
