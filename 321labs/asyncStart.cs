using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class asyncStart
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] arrSumm = new int[10];
        static Random random = new Random();

        static int[] GeneratArr(int[] arr)
        {
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 50);
                //Console.Write(arr[i] + " ");
            }
            return arr;
        }

        static void SummArray(int[] arr1, int[] arr2, int[] arrSumm)
        {
            for (int i = 0; i < arr1.Length && i < arr2.Length && i < arrSumm.Length; i++)
            {
                arrSumm[i] = arr1[i] + arr2[i];
            }
            Array.Sort(arrSumm);
        }

        static void Wivod(in)

        public static void Start(int[] arr)
        {
            GeneratArr(arr1);
            GeneratArr(arr1);
            SummArray(arr1, arr2, arrSumm);
        }
    }
}
