using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _321labs.asyncStart
{
    class Laba7
    {
        public static int[] arr1 = new int[10];
        public static int[] arr2 = new int[10];
        public static int[] arr3 = new int[10];


        public static void RandomArr1()
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                Random random = new Random();
                arr1[i] = random.Next(10);
                Console.WriteLine("Array1 " + arr1[i]);
            }
        }
        
        public static void RandomArr2()
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                Random random1 = new Random();
                arr2[i] = random1.Next(10);
                Console.WriteLine("Array2 " + arr2[i]);
            }
        }

        public static void Summ()
        {
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
        }

        public static async void Async() 
        {
            await Task.Run(()=>RandomArr1());
            await Task.Run(() => RandomArr2());
            await Task.Run(() => Summ());
        }

        public static void MainLaba7()
        {
            Async();
            Thread.Sleep(2000);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}

