using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _321labs;

namespace _321labs.ContinuationTasks
{
    class ContinuationTasks
    {
        Task TaskGenerate = new Task(() =>
        {
            int[] mas = new int[20];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(1, 5);
                Thread.Sleep(500);
            }
            Task TaskProduct = new Task(() =>
            {
                int a = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("Сумма элементов:");
                    a *= mas[i];
                    Console.WriteLine(a);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            });
            Task TaskEven = new Task(() =>
            {
                int a = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("Сумма элементов:");
                    if ((mas[i]%2)==0)
                    {
                        Console.WriteLine(a);
                        Thread.Sleep(1000);
                    }
                }
                Console.WriteLine();
            });
        });
    }
}
