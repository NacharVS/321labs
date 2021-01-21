using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _321labs;

namespace _321labs.ContinuationTasks
{
    public class ContinuationTasks
    {
        private static int[] mas = new int[20];
        private static long product = 1;

        public void Filling()
        {
            Random r = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(1, 10);
            }
            Console.Write("Дан массив: ");
            foreach (var item in mas)
            {
                Console.Write($"{item}" + " ");
            }
            Console.WriteLine();
        }

        public void Product(Task t)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                product *= mas[i];
            }
            Console.WriteLine($"Произведение элементов массива = {product}");
            Console.WriteLine();
        }

        public void EvenNumbers(Task t)
        {
            List<int> evenNum = new List<int>();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0) 
                {
                    evenNum.Add(mas[i]);
                }
                evenNum.Add(mas[i]);
            }

            Console.Write("Чётные цифры массива: ");
            foreach (var item in evenNum)
            {
                Console.Write($"{item}" + " ");
            }
        }

        public void StartTask()
        {
            Task task1 = new Task(Filling);
            Task task2 = task1.ContinueWith(Product);
            Task task3 = task2.ContinueWith(EvenNumbers);
            task1.Start();
            task2.Wait();
            task3.Wait();
        }
    }
}
