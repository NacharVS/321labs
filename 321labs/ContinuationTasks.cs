using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class ContinuationTasks
    {
        static int[] array = new int[20];
        static Random rnd = new Random();
        static int product =1;
        static List<int> evenDigints = new List<int>();

        static ContinuationTasks()
        {
            Task start = new Task(WriteInArray);
            Task task2 = start.ContinueWith(Product);
            Task task3 = start.ContinueWith(EvenDigits);
            start.Start();
        }

        static void WriteInArray()
        {
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        static void Product(Task t)
        {
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine("Проивзедение: "+ product);
        }

        static void EvenDigits(Task t)
        {
            double prd = product;
            int numberLength = prd.ToString().Length;
            while (numberLength != 0)
            {
                int digit = (int)Math.Floor(prd / Math.Pow(10, numberLength));
                if (digit %2==0)
                {
                    evenDigints.Add(digit);
                }
                prd -= digit * Math.Pow(10, numberLength);
                
                numberLength--;
            }
            Console.Write("Чётные цифры: ");
            foreach (var item in evenDigints)
            {
                Console.Write(item + " ");
            }
        }
    }
}