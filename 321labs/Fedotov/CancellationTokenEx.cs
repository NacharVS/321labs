using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class CancellationTokenEx
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static CancellationTokenSource cancellationToken = new CancellationTokenSource();
        CancellationToken token1 = cancellationToken.Token;
        CancellationToken token2 = cancellationToken.Token;
        CancellationToken token3 = cancellationToken.Token;

        public void Start()
        {
            Task task1 = new Task(Generic);
            Task task2 = new Task(Sum);
            Task task3 = new Task(ShowEven);

            task1.Wait();
            task2.Wait();
            task3.Wait();

            Console.WriteLine("Введите какие операции выбрать(вводить в строку через пробел всего 3 операции):");
            string str = Console.ReadLine();
            int[] arrayint = str.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrayint.Length; i++)
            {
                
            }
        }
        void Generic()
        {
            if (token1.IsCancellationRequested) return;

            Console.WriteLine("Сгенерировался");
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        void Sum()
        {
            if (token2.IsCancellationRequested) return;

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine("Сумма массива: " + sum);
        }

        void ShowEven()
        {
            if (token3.IsCancellationRequested) return;

            Console.WriteLine("Четные цифры:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
