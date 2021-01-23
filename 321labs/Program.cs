using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Console.WriteLine($"Выберите режим: \n" +
                $"1. Сумма двух чисел \n" +
                $"2. Проверка на четность \n" +
                $"3. Возвести в квадрат");
            int paragraph = Convert.ToInt32(Console.ReadLine());
            if (true)
            {

            }
            Task task1 = new Task(() => CancellationTokenEx.Sum(20, 12));
        }
    }
}
