using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Kamalov.ContinuationTasks
{
    class ContinuationTasks
    {
        Task TaskGeneration = new Task(() =>
        {
            int[] array = new int[20];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 5);
                Thread.Sleep(1000);
            }
            Task TaskProduct = new Task(() =>
            {
                int a = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Sum elements:");
                    a *= array[i];
                    Console.WriteLine(a);
                    Thread.Sleep(2000);
                }
                Console.WriteLine();
            });
            Task TaskEven = new Task(() =>
            {
                int a = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Sum elements:");
                    if ((array[i] % 2) == 0)
                    {
                        Console.WriteLine(a);
                        Thread.Sleep(2000);
                    }
                }
                Console.WriteLine();
            });
        });

    }
}

