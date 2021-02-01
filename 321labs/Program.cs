using _321labs.Mironov;
using _321labs.Mironov.Locker;
using _321labs.Mironov.Threads;
using System;
using System.Threading;
using _321labs.Mironov.Game.Class;
using _321labs.Mironov.Game;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("Leave hope behind all who enters here....");
            Archer archer1 = new Archer(12,5,50,2,100,20,"SimpleArcher",0,0);
            Database.Add(archer1).GetAwaiter();
            Console.ReadKey();

        }
    }
}
