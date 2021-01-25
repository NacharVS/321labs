using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Выберите режим: \n" +
                $"1. Сумма двух чисел \n" +
                $"2. Проверка на четность \n" +
                $"3. Возвести в квадрат");
            int paragraph = Convert.ToInt32(Console.ReadLine());
            
            Task task1 = new Task(() => CancellationTokenEx.Sum(20, 12));
            Task task2 = new Task(() => CancellationTokenEx.Even(20));
            Task task3 = new Task(() => CancellationTokenEx.Squared(5));

            if (paragraph == 1)
            {
                task1.Start();
                Thread.Sleep(1000);
            }
            else if (paragraph == 2)
            {
                task2.Start();
            }
            else if(paragraph == 3)
            {
                task3.Start();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Такого режима нет");
            }
        }
    }
}
