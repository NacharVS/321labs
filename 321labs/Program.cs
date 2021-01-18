using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() =>
            {
                TaskArray.Max();
            });
            Task task2 = new Task(() =>
            {
                TaskArray.Sum();
            });
            Task task3 = new Task(() =>
            {
                TaskArray.Sort();
            });

            task1.Start();
            task1.Wait();
            
            task2.Start();
            task2.Wait();

            task3.Start();
            task3.Wait();
        }
    }
}
