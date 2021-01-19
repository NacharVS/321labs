﻿using System;
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

            Console.WriteLine("Четные цифры:");
            for (int i = 0; ; i++)
            {
                a = product % z;
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                else if ((product < 10) && (product > -10))
                {
                    return;
                }
                product -= a;
                product /= z;
            }
        }
    }
}

//1234567891012
//asd 2
//asd 1
//asd 910
//asd 7800
//asd 56000
//asd 340000
//asd 1200000