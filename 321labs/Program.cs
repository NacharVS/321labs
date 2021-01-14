using System;
using System.Threading;
using _321labs.Game;
using _321labs.Koshelev.Thread;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            int[] mas = { 1, 2, 4, 63, 4, 85, 3, 6, 9, 6, 3, 5, 9, 35, 6 };
            Threads threads = new Threads(mas);
            Thread thread = new Thread(new ThreadStart(threads.Max));
            thread.Start();
            thread = new Thread(new ThreadStart(threads.SortMas));
            thread.Start();
            thread = new Thread(new ThreadStart(threads.SumMas));
            thread.Start();



        }
    }
}
