using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class Tasks
    {
        static int[] numbers = { 2, 5, 4, 1, 10 };

        public static void Sum()
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            Console.WriteLine("Sum:" + sum);
        }

        public static void Max()
        {
            int max = 0;
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("Max: " +max);
        }

        public static void SortArray()
        {
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
