using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    public class MyArray
    {
        int[] number;
        public MyArray(int[] number)
        {
            this.number = number;
        }

        public void Summ()
        {
            Console.WriteLine("Сумма массива: ");
            int summ = 0;
            for (int i = 0; i < number.Length; i++)
            {
                summ += number[i];
            }
            Console.WriteLine(summ);
        }

        public void Max()
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

        public void Sort()
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
    }
}
