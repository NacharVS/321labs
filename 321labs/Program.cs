using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //CancellationTokenSource cancellation = new CancellationTokenSource();
            //CancellationToken token = cancellation.Token;

            //Task t1 = new Task(CancellTokenEx.Sum);

            Console.WriteLine(GameCreationStart.SearchByName("Oleg"));
            GameCreationStart.GameStat();
        }
    }
}
