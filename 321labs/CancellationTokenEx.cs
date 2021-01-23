using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class CancellationTokenEx
    {
        public static void Product(double num1, double num2) => Console.WriteLine($"Произведение: {num1 * num2}");

        public static void Sum(double num1, double num2) => Console.WriteLine($"Сумма: {num1 + num2}");

        public static void Pow(double num1, double num2) => Console.WriteLine($"Число {num1} в степени {num2} равно {Math.Pow(num1, num2)}");

        public static void Run(double num1, double num2, CancellationToken token)
        {
            while (true)
            {
                Task taskProduct = new Task(() = )

                Console.WriteLine($"Выберите действие \n " +
                    $"1. Произведение чисел.\n" +
                    $"2. Сумма чисел \n" +
                    $"3. Возведение в степень \n");

                int paragraph = Convert.ToInt32(Console.ReadKey());
                switch (paragraph)
                {
                    case 1: 

                    default:
                        break;
                }
                Console.WriteLine("Введите");
            }
        }
    }
}
