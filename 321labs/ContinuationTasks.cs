using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _321labs
{
    class ContinuationTasks
    {
        static int[] arr = new int [20];
        static Random random = new Random();

        static void GeneratArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
                Console.WriteLine(array[i]);
            }
        }

        static void Product(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine($"Произведение всех элементов массива: {product}");
        }

        public static void Start(int[] array)
        {
            GeneratArr(array);
            Product(array);

        }
    }
}
