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
            Archer archer1 = new Archer(15,5,50,2,1204,20,"Simple Archer",0,0);
            string description = "SimpleArcher";
            Database.Replace(description,archer1).GetAwaiter().GetResult();
            Console.ReadKey();

        }
    }
}
