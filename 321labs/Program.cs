using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(() =>
            {

            });

            task.Start();
            {
                //    Task task1 = new Task(() => ContinuationTasks.Randomizer());

                //    Task task2 = task1.ContinueWith(sum => ContinuationTasks.Product());



                //    task1.Start();
                //    task2.Wait();
                //}

                //static int Sum(int a, int b) => a + b;

                //static void SumConsole(int sum)
                //{
                //    Console.WriteLine(sum);
            }
        }
    }
}
