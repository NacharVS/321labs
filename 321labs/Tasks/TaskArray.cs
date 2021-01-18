using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    public class TaskArray
    {
        static int[] arr = { 43, 245, -56 };

        public static void Max()
        {
            int max = TaskArray.arr[0];

            for (int i = 0; i < TaskArray.arr.Length; i++)
            {
                if (TaskArray.arr[i] > max)
                {
                    max = TaskArray.arr[i];
                }
            }
            Console.WriteLine($"Максимальный элемент массива: {max} \n");
        }
        public static void Sort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < TaskArray.arr.Length - 1; j++)
                {
                    if (arr[j] > TaskArray.arr[j + 1])
                    {
                        int z = TaskArray.arr[j];
                        TaskArray.arr[j] = TaskArray.arr[j + 1];
                        TaskArray.arr[j + 1] = z;
                    }
                }
            }
            Console.Write("Отсортированный по возрастанию массив: ");
            for (int i = 0; i < TaskArray.arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
        public static void Sum()
        {
            int sum = 0;

            for (int i = 0; i < TaskArray.arr.Length; i++)
            {
                sum += TaskArray.arr[i];
            }
            Console.WriteLine($"Сумма массива: {sum}");
        }
    }
}
