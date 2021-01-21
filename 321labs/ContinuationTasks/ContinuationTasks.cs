using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.ContinuationTasks
{
    class ContinuationTask
    {
        static long[] arr = new long[20];
        static Random rnd = new Random();
        public static void Start()
        {
            Task task1 = new Task(randomarr);
            Task<long> task2 = task1.ContinueWith(m => multiply());
            Task task3 = task2.ContinueWith(m => chetnoe(task2.Result));
            task1.Start();
            task2.Wait();
            task3.Wait();

        }
        public static void randomarr()
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static long multiply()
        {
            long chislomultiply = 1;
            foreach (var item in arr)
            {
                chislomultiply *= item;
            }
            return chislomultiply;
        }
        public static void chetnoe(long number)
        {
            Console.WriteLine(number);
            string num = number.ToString();
            long[] a = new long[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                a[i] = Int64.Parse(num[i].ToString());
            }
            Console.WriteLine("chetnie numbers");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }


    }
}