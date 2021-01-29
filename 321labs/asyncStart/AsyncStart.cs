using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _321labs.asyncStart
{
    class AsyncStart
    {
        int[] mas1 = new int[10];
        int[] mas2 = new int[10];
        int[] sum = new int[10];
        Random r = new Random();
        public void StarAsync()
        {
            FirstArrayAsync();
            SecondArrayAsync();
            SumAsync();
            SortAsync();
        }
        public async void FirstArrayAsync()
        {
            await Task.Run(() => FirstArray());
        }
        public async void SecondArrayAsync()
        {
            await Task.Run(() => SecondArray());
        }
        public async void SumAsync()
        {
            await Task.Run(() => Sum());
        }
        public async void SortAsync()
        {
            await Task.Run(() => Sort());
        }

        private void FirstArray()
        {
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = r.Next(1, 10);
                Console.WriteLine(mas1[i]);
            }
            Console.WriteLine();
        }
        private void SecondArray()
        {
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = r.Next(1, 10);
                Console.WriteLine(mas2[i]);
            }
            Console.WriteLine();
        }
        private void Sum()
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = mas1[i] + mas2[i];
                Console.WriteLine($"{mas1[i]} + {mas2[i]} = {sum[i]}");
            }
        }
        public void Sort()
        {
            int s;
            for (int i = 0; i < sum.Length - 1; i++)
            {
                for (int j = i + 1; j < sum.Length; j++)
                {
                    if (sum[i] > sum[j])
                    {
                        s = sum[i];
                        sum[i] = sum[j];
                        sum[j] = s;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
