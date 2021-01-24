using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{

    class CancellationTokenEx
    {
        static int number1 = 27;
        static int number2 = 4;

        public static void Product(double num1, double num2, CancellationToken token) => Console.WriteLine($"Произведение: {num1 * num2} \n");
        
        public static void Sum(double num1, double num2, CancellationToken token) => Console.WriteLine($"Сумма: {num1 + num2} \n");

        public static void Pow(double num1, double num2, CancellationToken token) => Console.WriteLine($"Число {num1} в степени {num2} равно {Math.Pow(num1, num2)} \n");
        
        public static void Run()
        {
            while (true)
            {
                CancellationTokenSource cancellationTokenSourceProduct = new CancellationTokenSource();
                CancellationToken tokenProduct = cancellationTokenSourceProduct.Token;
                CancellationTokenSource cancellationTokenSourceSum = new CancellationTokenSource();
                CancellationToken tokenSum = cancellationTokenSourceSum.Token;
                CancellationTokenSource cancellationTokenSourcePow = new CancellationTokenSource();
                CancellationToken tokenPow = cancellationTokenSourcePow.Token;

                Console.WriteLine($"Выберите действие \n" +
                    $"1. Произведение чисел {number1} и {number2}.\n" +
                    $"2. Сумма чисел {number1} и {number2} \n" +
                    $"3. Возведение в степень числа {number1} в степени {number2} \n");

                Task taskProduct = new Task(() => Product(number1, number2, tokenProduct));
                Task taskSum = new Task(() => Sum(number1, number2, tokenSum));
                Task taskPow = new Task(() => Pow(number1, number2, tokenPow));

                char paragraph = Console.ReadKey().KeyChar;


                switch (paragraph)
                {
                    case '1':
                        taskProduct.Start();
                        
                        cancellationTokenSourceSum.Cancel();
                        cancellationTokenSourcePow.Cancel();
                        break;
                    case '2':
                        taskSum.Start();

                        cancellationTokenSourceProduct.Cancel();
                        cancellationTokenSourcePow.Cancel();
                        break;
                    case '3':
                        taskPow.Start();

                        cancellationTokenSourceProduct.Cancel();
                        cancellationTokenSourceSum.Cancel();
                        break;
                    default:
                        Console.WriteLine("Вы вышли за пределы вселенной");
                        break;
                }
            }
        }
    }
}
