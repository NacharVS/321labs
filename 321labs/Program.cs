using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;

namespace _321labs
{
    class Program
    {

        static void Main(string[] args)
        {
            ContinuationTasks continuationTasks = new ContinuationTasks();
            Task task1 = new Task(continuationTasks.RandomElevent);
            Task task2 = task1.ContinueWith(t => continuationTasks.ProductMas());
            Task task3 = task2.ContinueWith(t => continuationTasks.EvenNumbers());
            task1.Start();
            task3.Wait();
            
        }

       
    }
}
