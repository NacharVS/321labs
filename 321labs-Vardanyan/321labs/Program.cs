using System;
using System.Threading;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] namber = { 3, 6, 59, 78, 56, 89 };
            Threads.MyArray a = new Threads.MyArray(namber);
            Thread MaxThread = new Thread(new ThreadStart(a.Max));
            Thread SummThread = new Thread(new ThreadStart(a.Summ));
            Thread SortThread = new Thread(new ThreadStart(a.Sort));

            MaxThread.Start(); 
            SortThread.Start();
            SummThread.Start();
        }
    }
}
 
