using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    public class MyArray
    {
        static int[] number = { 165, 65, 89, 45, 18, 21, 7 };
        static void Summ()
        {
            Console.WriteLine("Сумма массива: ");
            int summ = 0;
            for (int i = 0; i < number.Length; i++)
            {
                summ += number[i];
            }
            Console.WriteLine(summ);
        }

        static void Max()
        {
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

        static void Sort()
        {
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
            Thread MaxThread = new Thread(Max);
            Thread SummThread = new Thread(Summ);
            Thread SortThread = new Thread(Sort);
            MaxThread.Start();
            SortThread.Start();
            SummThread.Start();
        }
    }
}
