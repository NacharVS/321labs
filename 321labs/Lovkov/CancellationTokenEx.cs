using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _321labs.Lovkov
{
    class CancellationTokenEx
    {
        int a = 0;
        int b = 0;
        int c = 0;

        public void ValuesInput()
        {      
                Console.WriteLine("Введите первое целое значение: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе целое значение: ");
                b = Convert.ToInt32(Console.ReadLine());
        }

        public void Product()
        {
            if (a !=0 && b !=0)
            {
                c = a * b;
                Console.WriteLine($"Произведние чисел {a} и {b} равно: {c}");
            }
            else
                Console.WriteLine("Вы не ввели значение");
        }

        public void Sum()
        {
            if (a != 0 && b != 0)
            {
                c = a + b;
                Console.WriteLine($"Сумма чисел {a} и {b} равно: {c}");
            }
            else
                Console.WriteLine("Вы не ввели значение или ввели 0");
        }

        public void StartTaskGroup()
        {
            Task task1 = new Task(ValuesInput);
            Task task2 = new Task(Product);
            Task task3 = new Task(Sum);
        }

        static void Main(string[] args)
        {
            CancellationTokenEx g = new CancellationTokenEx();
            Task task4 = new Task(g.ValuesInput);
            Task task5 = new Task(g.Product);
            Task task6 = new Task(g.Sum);

            task4.Start();
            task5.Wait();

        }
    }
}

