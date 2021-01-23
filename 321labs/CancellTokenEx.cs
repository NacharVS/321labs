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
            CancellationTokenSource cancellation = new CancellationTokenSource();
            CancellationToken token = cancellation.Token;

            Task t1 = new Task(Sum);
            Task t2 = new Task(Max);
            Task t3 = new Task(SortArray);
            Info();
            int num = Convert.ToInt32(Console.ReadKey());


            //switch (num)
            //{
            //    case 1:
            //        t1.Start();
            //        t2.Start();
            //        t3.Start();
            //        break;
            //    case 2:
            //        t1.Start();
            //        t2.Start();
            //        break;
            //    case 3:
            //        t2.Start();
            //        t3.Start();
            //        break;
            //    case 4:
            //        t1.Start();
            //        t3.Start();
            //        break;
            //    case 5:
            //        t1.Start();
            //        break;
            //    case 6:
            //        t2.Start();
            //        break;
            //    case 7:
            //        t3.Start();
            //        break;
            //    default:
            //        t1.Start();
            //        t2.Start();
            //        t3.Start();
            //        break;
            //}

        }
        private static void Info()
        {
            Console.WriteLine("Choose which function tou want to run:");
            Console.WriteLine("1 - All");
            Console.WriteLine("2 - Sum and Max");
            Console.WriteLine("3 - Max and Sort");
            Console.WriteLine("4 - Sum and Sort");
            Console.WriteLine("5 - Sum");
            Console.WriteLine("6 - Max");
            Console.WriteLine("7 - Sort");
        }
    }
}
