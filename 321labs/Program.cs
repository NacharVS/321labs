using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(Tasks.Max);
            Task t2 = new Task(Tasks.Sum);
            Task t3 = new Task(Tasks.SortArray);
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
