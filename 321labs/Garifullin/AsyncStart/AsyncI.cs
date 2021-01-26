using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs.Garifullin.AsyncStart
{
    class AsyncI
    {
        int temp;
        int[] firstArr = new int[10];
        int[] secondArr = new int[10];
        int[] sum = new int[10];
        
        private void RndmFirst()
        {
            Random rand = new Random();

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = rand.Next(1, 20);
                Console.WriteLine($"{i + 1} элемент первого массива {firstArr[i]}");
            }
            Console.WriteLine();
        }
        private void RndmSecond()
        {
            Random rand = new Random();

            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = rand.Next(1, 20);
                Console.WriteLine($"{i + 1} элемент второго массива {secondArr[i]}");
            }
            Console.WriteLine();
        }
        private void Sum()
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstArr[i] + secondArr[i];
                Console.WriteLine($"Сумма {i + 1} элементов: {sum[i]}");
            }
        }
        public void Sort()
        {
            for (int i = 0; i < sum.Length - 1; i++)
            {
                for (int j = i + 1; j < sum.Length; j++)
                {
                    if (sum[i] > sum[j])
                    {
                        temp = sum[i];
                        sum[i] = sum[j];
                        sum[j] = temp;
                    }
                }
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine($"{i + 1} Итого сортировки {sum[i]}");
            }
        }
        public async void RndmFirstAsync()
        {
            await Task.Run(() => RndmFirst());
        }
        public async void RndmSecondAsync()
        {
            await Task.Run(() => RndmSecond());
        }
        public async void SumAsync()
        {
            await Task.Run(() => Sum());
        }
        public async void SortAsync()
        {
            await Task.Run(() => Sort());
        }
        public void StartThreads()
        {
            SumAsync();
            RndmFirstAsync();
            RndmSecondAsync();
            SortAsync();
        }
    }
}
