using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(ContinuationTasks.CreateArray);
            Task t2 = t.ContinueWith(ContinuationTasks.GetEvenNumvers);

            t.Start();
            t2.Wait();
        }
    }
}
