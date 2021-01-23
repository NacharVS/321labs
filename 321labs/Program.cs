using System;
using System.Threading;
using _321labs.Fedotov.Game;
using _321labs.Fedotov;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Я без понятия правильно это или нет, я не мб это все вообще не правильно");
            CancellationTokenEx threads = new CancellationTokenEx();
            threads.Start();
        }
    }
}
