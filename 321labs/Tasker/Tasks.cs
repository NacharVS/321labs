using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Tasker
{
    class Tasks
    {
        static int[] number = { 165, 65, 89, 45, 18, 21, 7 };
        static object locks = new object();
        public static void Summ()
        {
            lock (locks)
                Console.WriteLine("Сумма массива: ");
            int summ = 0;
            for (int i = 0; i < number.Length; i++)
            {
                summ += number[i];
            }
            Console.WriteLine(summ);
        }

        public static void Max()
        {
            lock (locks)
                Console.WriteLine("Максимальное число массива: ");
            int max = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void Sort()
        {
            lock (locks)
                Console.WriteLine("Отсортированный  массив: ");
            int temp;
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
        public static void Start()
        {
            Task MaxThread = new Task(Max);
            Task SortThread = new Task(Sort);
            Task SummThread = new Task(Summ);
            MaxThread.Start();
            SortThread.Start();
            SummThread.Start();
        }
    }
}
