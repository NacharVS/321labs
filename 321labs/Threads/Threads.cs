using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Thread
{
    class Threads
    {
        int[] numbers = { 2, 5, 4, 1, 10 };

        public int Sum()
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public int Max()
        {
            int max = 0;
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public void SortArray()
        {
            Array.Sort(numbers);
        }

        public static void Start()
        {
            Thread potok1 = new Thread(Sum);
        }
    }
}
