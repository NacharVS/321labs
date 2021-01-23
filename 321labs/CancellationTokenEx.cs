using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class CancellationTokenEx
    {
        public static void Sum(double num1, double num2)
        {
            Console.WriteLine($"Сумма: {num1 + num2}.");
        }
        
        public static void Even(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Четное.");
            }
            else
            {
                Console.WriteLine("Нечетное.");
            }
        }
        public static void Squared(int num)
        {
            Console.WriteLine(Math.Sqrt(num));
        }
    }
}
