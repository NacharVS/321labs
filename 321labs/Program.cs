using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {   static int[] arr = new int[20];
        static void Main(string[] args)
        {
            List<Game.GameCreationStart> listHero = new List<Game.GameCreationStart>();
            Game.GameCreationStart hero1 = new Game.GameCreationStart("Smelev Ranil", new DateTime(2002, 09, 03), 18, 4, 120);
            listHero.Add(hero1);
            Console.WriteLine(Game.GameCreationStart.SearchByName(listHero[0]));

            //CancellationTokenEx.Start();
            //ContinuationTasks.Start(arr);
            //locker.loker.Start();
            //Tasker.Tasks.Start();

            //Task MaxThread = new Task(Tasker.Tasks.Max);
            //Task SortThread = new Task(Tasker.Tasks.Sort);
            //Task SummThread = new Task(Tasker.Tasks.Summ);
            //MaxThread.Start();
            //MaxThread.Wait();
            //SortThread.Start();
            //SortThread.Wait();
            //SummThread.Start();
            //SummThread.Wait();
        }
    }
}