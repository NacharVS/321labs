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
            Archer archer2 = new Archer(25,5,55,2,13,25,"Good Archer",20,4,0);
           
            MongoCRUD.Delete("Good Archer").GetAwaiter().GetResult();
            Console.ReadKey();

        }
    }
}
