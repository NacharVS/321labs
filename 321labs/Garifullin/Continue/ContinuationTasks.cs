using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Garifullin.Continue
{
    class ContinuationTasks
    {
        static int[] mas = new int[20];
        long prod = 1;

        public void MassFull()
        {
            Random rand = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 10);
                Console.WriteLine($"{i + 1} элемент массива {mas[i]}");
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }
        public void Product(Task t)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                prod *= mas[i];
                Thread.Sleep(20);
            }
            Console.WriteLine(prod);
        }
        public void Evendigits(Task t)
        {
            //prod = Math.Abs(prod);
            //var digits = new List<int>();
            //while (prod > 0)
            //{
            //    int digit = prod % 10;
            //    prod /= 10;
            //    digits.Add(digit);
            //}

        }

        public void StartThreads()
        {
            Task full = new Task(MassFull);
            Task prodv = full.ContinueWith(Product);

            full.Start();

            prodv.Wait();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            ContinuationTasks tasks = new ContinuationTasks();
            tasks.StartThreads();
        }
    }
}
