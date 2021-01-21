using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace _321labs
{
    class ContinuationTasks
    {
        static int[] array = new int[20];
        static Random rnd = new Random();

        private static void Generator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 5);
            }

            Console.Write("Elements array: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static long Product()
        {
            long product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            return product;
        }
        private static void Even(long number)
        {
            Console.WriteLine("Sum product of array: {0}",number);
            Console.Write("Even digit: ");
            string num = number.ToString();
            long[] a = new long[num.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(num[i].ToString());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }

        public void Start()
        {
            Task task1 = new Task(Generator);
            Task<long> task2 = task1.ContinueWith(g => Product());
            Task task3 = task2.ContinueWith(e => Even(task2.Result));
            task1.Start();
            task3.Wait();
        }
    }
}
