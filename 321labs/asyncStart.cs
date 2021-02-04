using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class asyncStart
    {
        static int[] first = new int[10];
        static int[] second = new int[10];
        static int[] result = new int[10];
        static Random rnd = new Random();

        static void GenArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 30);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }

        static async void GenArrAsync(int[] arr)
        {
            await Task.Run(() => GenArr(arr));
        }

        static void SumArr()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = first[i] + second[i];
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }

        static async void SumArrAsync()
        {
            await Task.Run(() => SumArr());
        }

        static void SortArr()
        {
            Array.Sort(result);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        static async void SortArrAsync()
        {
            await Task.Run(() => SortArr());
        }
        public static void asyncStarts()
        {
            GenArrAsync(first);
            GenArrAsync(second);
            SumArrAsync();
            SortArrAsync();
        }
    }
}
