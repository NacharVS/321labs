using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Threads
{
    class Threads : IThreadOperations
    {
        static int[] arr = { 43, 245, -56 };

        public void Max()
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Максимальный элемент массива: {max} \n");
        }
        public void Sort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int z = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = z;
                    }
                }
            }
            Console.Write("Отсортированный по возрастанию массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
        public void Sum()
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Сумма массива: {sum}");
        }
    }
}
