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

        static ContinuationTasks()
        {
            Task<int[]> start = new Task<int[]>(WriteInArray);
            Task<long> task2 = start.ContinueWith(pr => Product(pr.Result));
            Task task3 = task2.ContinueWith(eDig => EvenDigits(eDig.Result));
            start.Start();
        }

        static int[] WriteInArray()
        {
            int[] intArray = array;
            Console.Write("Массив: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(1, 10);
                Console.Write(intArray[i]+" ");
            }
            Console.WriteLine();
            return intArray;
        }

        static long Product(int[] array)
        {
            long product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine("Проивзедение: "+ product);
            return product;
        }

        static List<int> EvenDigits(long product)
        {
            List<int> evenDigints = new List<int>();
            double prd = product;
            int numberLength = prd.ToString().Length-1;
            while (numberLength != -1)
            {
                int digit = (int)Math.Floor(prd / Math.Pow(10, numberLength));
                if (digit % 2 == 0)
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
            return evenDigints;
        }
    }
}