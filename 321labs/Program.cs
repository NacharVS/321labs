using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            locker.loker.Start();

            Tasker.Tasks.Start();

            Task MaxThread = new Task(Tasker.Tasks.Max);
            Task SortThread = new Task(Tasker.Tasks.Sort);
            Task SummThread = new Task(Tasker.Tasks.Summ);
            MaxThread.Start();
            MaxThread.Wait();
            SortThread.Start();
            SortThread.Wait();
            SummThread.Start();
            SummThread.Wait();

        }
    }
}