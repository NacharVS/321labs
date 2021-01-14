using System;
using _321labs.Fedotov.Game;
using _321labs.Fedotov;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Я без понятия правильно это или нет, я не мб это все вообще не правильно");
            Threads threads = new Threads(new []{5,5,6,8,9,8,9,5,9,84,4,1,9,4,6,9});
            threads.Start();
        }
    }
}
