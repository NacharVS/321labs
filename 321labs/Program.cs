using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Game;

namespace _321labs
{
    class Program
    {   static int[] arr = new int[20];
        static void Main(string[] args)
        {
            GameCreationStart user1 = new GameCreationStart("Andrey", new DateTime(2002, 07, 13), 167, 34, 867);
            GameCreationStart user2 = new GameCreationStart("Il'ya", new DateTime(2000, 01, 23), 577, 353, 678);
            GameCreationStart user3 = new GameCreationStart("Rob", new DateTime(2004, 10, 30), 343, 1588, 453);
            GameCreationStart user4 = new GameCreationStart("Vlamer", new DateTime(1999, 05, 15), 325, 375, 133);
            GameCreationStart user5 = new GameCreationStart("Targarian", new DateTime(1995, 09, 01), 770, 435, 2625);
            GameCreationStart user6 = new GameCreationStart("Vesteros", new DateTime(2009, 11, 11), 1407, 698, 1593);

            var userSearch = GameCreationStart.SearchByName("Kane");
            userSearch.ForEach(user => Console.WriteLine(user.UserName + " " + user.FinishedMatches));
            Console.WriteLine(GameCreationStart.GameStat());
            
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