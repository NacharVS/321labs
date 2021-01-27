using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class AsyncLab
    {
        const int arraySize = 20;
        public static int[] firstArray = new int[arraySize];
        public static int[] secondArray = new int[arraySize];
        public static int[] results = new int[arraySize];
        public static Random random = new Random();

        public static void Start()
        {
            FirstArrayFillAsync();
            SecondArrayFillAsync();
            SumAsync();
            SortAsync();
        }

        public static async void FirstArrayFillAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < arraySize; i++)
                {
                    firstArray[i] = random.Next(0, 100);
                }
            });
        }

        public static async void SecondArrayFillAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < arraySize; i++)
                {
                    secondArray[i] = random.Next(0, 100);
                }
            });
        }

        public static async void SumAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < arraySize; i++)
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
    }
}
