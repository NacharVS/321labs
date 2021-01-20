using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Mironov
{
    class ContinuationTasks
    {
       private static long[] arr = new long[20];
        static Random rnd = new Random();
        public static void Start()
        {
            Task task1 = new Task(GenerateValue);
            Task<long> task2 = task1.ContinueWith(m=>MultiplyElem());
            Task task3 = task2.ContinueWith(m =>ShowEven(task2.Result));
            task1.Start();
            task3.Wait();

        }
        private static void GenerateValue()
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

        private static long MultiplyElem()
        {
            long product=1;
            foreach (var item in arr)
            {
                product *= item;
            }
            return product;
        }
        private static void ShowEven(long number)
        {
            Console.WriteLine(number);
            string num = number.ToString();
            long[] b = new long[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                b[i]=Int64.Parse(num[i].ToString());
            }
            Console.WriteLine("Even numbers");
            for (int i = 0; i < b.Length; i++)
            {
                if(b[i] % 2 == 0)
                {
                    Console.Write(b[i]+" ");
                }
            }
        }


    }
}
