using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Tasks
{
    class TasksProgram
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Task task1 = new Task(() => { });           
        }
        static void Summ(object obj)
        {
            if (obj is Class2 class2)
            {
                int summ = class2.a[0];
                foreach (var item in class2.a)
                {
                    summ += item;
                }
                Console.WriteLine($"Сумма: {summ}");
            }
        }
        static void Max(object obj)
        {
            if (obj is Class2 class2)
            {
                int max = class2.a[0];
                foreach (var item in class2.a)
                {
                    max = item;
                }
                Console.WriteLine($"Сумма: {max}");
            }
        }
        static void Sort(object obj)
        {
            if (obj is Class2 class2)
            {
                Array.Sort(class2.a);

                foreach (var item in class2.a)
                {
                    Console.WriteLine($"Сортировка: {item + " "}");
                }

            }
        }
    }
