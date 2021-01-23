using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class ContinuationTasks
    {
        static long[] arr = new long[20];

        public static long[] Arr { get => arr; set => arr = value; }

        public static void Randomizer()
        {
            Random rnd = new Random();

            for (int i = 0; i < ContinuationTasks.Arr.Length; i++)
            {
                ContinuationTasks.Arr[i] = rnd.Next(-1000, 1000);
                Console.WriteLine($"{i + 1}-ый элемент массива: {ContinuationTasks.Arr[i]}");
            }
            Console.WriteLine();
        }

        public static void Product()
        {
            long product = 1;
            for (int i = 0; i < ContinuationTasks.Arr.Length; i++)
            {
                product *= ContinuationTasks.Arr[i];
            }

            Console.WriteLine($"Произведение элементов массива: {product} \n");

            long a;
            int z = 10;
            int size;
            if (product > 0)
            {
                size = product.ToString().Length;
            }
            else
            {
                size = product.ToString().Length - 1;
            }
            Console.WriteLine("Четные цифры:");
            for (int i = 0; i < size; i++)
            {
                a = product % z;
                if (a % 2 == 0)
                {
                    if (a < 0)
                    {
                        a *= -1;
                    }
                    Console.WriteLine(a);
                }
                
                product -= a;
                product /= z;
            }
        }
    }
}