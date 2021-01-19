using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class ContinuationTasks
    {
        static int[] array = new int [20];
        static Random random = new Random();
        static int product = 1;
        static string p; // = Convert.ToString(product);

        static int[] GeneratArr(int[] arr)
        {
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 50);
                Console.Write(arr[i] + " ");
            }
            return arr;
        }

        static string Product(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine($"\nПроизведение всех элементов массива: {Math.Abs(product)}");
            p = Convert.ToString(product);
            return p;
        }

        static string EvenDigits(string p)
        {
            
            string Cifra = "";
            for (int i = 0; i < p.Length; i++)
            {

                if (Convert.ToChar(p[i]) % 2 == 0)
                {
                    Cifra += p[i];
                }
            }
            p = Cifra;
            Console.WriteLine("Четные цифры: " + p);
            return p;
        }

        public static void Start(int[] arr)
        {
            Task<int[]> task1 = new Task<int[]>(() => GeneratArr(arr));
            Task<string> task2 = task1.ContinueWith(arr => Product(arr.Result));
            Task<string> task3 = task2.ContinueWith(p => EvenDigits(p.Result));
            task1.Start();
            task3.Wait();

        }
    }
}
