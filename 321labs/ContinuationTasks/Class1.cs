using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _321labs.ContinuationTasks
{
    class ContinuationTask
    {
        
        static long[] a = new long[20];


        Task task1 = new Task(() =>
    {
        Random rnd = new Random();

        long result = 1;
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            a[i] = rnd.Next(1, 10);
            Console.WriteLine(a[i]);
        }
        Console.WriteLine("");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            result *= a[i];
        }
        Console.WriteLine("Произведение = {0}", result);
        Console.ReadKey();
        
    });
        
        
        








        
        static void Display(Task t)
        {


        }

        }
       
    }

