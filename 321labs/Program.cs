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
            ThreadLocker threads = new ThreadLocker();
            threads.Start();
        }
    }
}
