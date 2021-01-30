using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class AsyncStart
    {
        private int[] arr = new int[10];
        int[] arr2 = new int[10];
        int[] arrResult = new int[10];

        async void GenerationArr(int[] arr)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Arrays");
                Random rand = new Random();
                foreach (int item in arr)
                {
                    arr[item] = rand.Next(1, 20);
                }
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
            });
        }
        async void SumArr(int[] arr, int[] arr2,int[] arrRes)
        {
            Console.WriteLine("Sum Array");
            await Task.Run(() =>
            {
                foreach (int item in arrRes)
                {
                    arrRes[item] = arr[item] + arr2[item];
                }
                foreach (int item in arrRes)
                {
                    Console.Write(item + " ");
                }
            });
        }
        async void SortArr(int[] arrRes)
        {
            Console.WriteLine("Sort Array");
            await Task.Run(() =>
            {
                Array.Sort(arrRes);
            });
        }
        public void Start()
        {
            GenerationArr(arr);
            GenerationArr(arr2);
            SumArr(arr, arr2, arrResult);
            SortArr(arrResult);
        }
    }
}
