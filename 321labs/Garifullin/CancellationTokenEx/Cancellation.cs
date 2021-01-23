using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Garifullin.CancellationTokenEx
{
    class Cancellation
    {
        int a;
        int c;
        int b;
        int sum;
        int dif;
        long prod = 1;
        public void Sum()
        {
            for (int i = 0; i < c; i++)
            {
                sum += a + b;
                Console.WriteLine($"Sum {sum}");
                Thread.Sleep(2000);
            }
        }
        public void Difference()
        {
            for (int i = 0; i < c; i++)
            {
                dif -= a - b;
                Console.WriteLine($"Difference {dif}");
                Thread.Sleep(3000);
            }
        }
        public void Product()
        {
            for (int i = 0; i < c; i++)
            {
                prod *= a * b;
                Console.WriteLine($"Product {prod}");
                Thread.Sleep(1000);
            }
        }
        public void Finish()
        {
            Console.WriteLine("Дайте числовое значение переменной 'a'");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дайте числовое значение длинны циклов");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дайте числовое значение переменной для арифметический действий");
            b = Convert.ToInt32(Console.ReadLine());

            Task task1 = new Task(Sum);
            Task task2 = new Task(Difference);
            Task task3 = new Task(Product);
            task1.Start();
            task2.Start();
            task3.Start();
            task1.Wait();
            task2.Wait();
            task3.Wait();

        }
        static void Main(string[] args)
        {
            Cancellation c = new Cancellation();
            c.Finish();
            Console.WriteLine("Leave hope behind all who enters here....");
        }
    }
}
