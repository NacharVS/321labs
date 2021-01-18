using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Game;

namespace _321labs
{
    class Program
    {
        static int[] mas1 = { 1, 5, 89, 6, 11, 4, 7, 9, 7, 12, 3, 6, 8, 44 };

        static void Main(string[] args)
        {
            //
            Threads threads = new Threads(mas1);
            Task task = new Task(threads.Max);
            Task task1 = new Task(threads.SortMas);    
            Task task2 = new Task(threads.SumMas);
            task.Start();
            task1.Start();
            task2.Start();
            task.Wait();
            task1.Wait();
            task2.Wait();
            //
        }
    }
}
