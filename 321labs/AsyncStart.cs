using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class AsyncStart
    {



        public static void GenerationArr(int[] arr)
        {
            Random rand = new Random();
            foreach (int item in arr)
            {
                arr[item] = rand.Next(1, 20);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        public static void SumArr(int[] arr, int[] arr2,int[] arrRes)
        {
            foreach (int item in arrRes)
            {
                arrRes[item] = arr[item] + arr2[item]; 
            }
            foreach (int item in arrRes)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
