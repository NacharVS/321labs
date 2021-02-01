using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Mironov
{
    class asyncStart
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] result = new int[10];
        static Random rnd = new Random();
        public static  void Start()
        {
             GenerateValueAsync(arr1);
             GenerateValueAsync(arr2);
            SumArrayAsync();
             SortArrayAsync();

        }



        private static void GenerateValue(int[] arr)
        {
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(1, 20);
                }
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
        }

        private static async void GenerateValueAsync(int[] arr)
        {
            
            await Task.Run(()=>GenerateValue(arr));
        }

        private static void SumArray()
        {
            Console.WriteLine("");
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }

        private static async void SumArrayAsync()
        {

            await Task.Run(() => SumArray());
        }

        private static void SortArray()
        {
            Console.WriteLine("");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine("");

        }
        private static async void SortArrayAsync()
        {
            
            await Task.Run(() => SortArray());
        }

    }

      

}

