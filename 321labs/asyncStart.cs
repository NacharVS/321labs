using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs
{
    class asyncStart
    {
        const int arraySize = 20;
        public static int[] firstArray = new int[10];
        public static int[] secondArray = new int[10];
        public static int[] results = new int[10];
        public static Random random = new Random();

        

        public static async void FirstArrayFillAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = random.Next(0, 100);
                }
            });
        }

        public static async void SecondArrayFillAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    secondArray[i] = random.Next(0, 100);
                }
            });
        }

        public static async void SumAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < results.Length; i++)
                {
                    results[i] = firstArray[i] + secondArray[i];
                }
            });
        }

        public static async void SortAsync()
        {
            await Task.Run(() =>
            {
                Array.Sort(results);
            });
        }
        public static void Start()
        {
            FirstArrayFillAsync();
            SecondArrayFillAsync();
            SumAsync();
            SortAsync();
        }
    }
}
