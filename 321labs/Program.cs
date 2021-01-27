using _321labs.Mironov;
using _321labs.Mironov.Locker;
using _321labs.Mironov.Threads;
using System;
using System.Threading;
using _321labs.Mironov.Game.Class;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("Leave hope behind all who enters here....");

             User g1 = new User("fff");
             User g2 = new User("kkk");
             User g3 = new User("moma");
             User g4 = new User("dio");
             User g5 = new User("dio");

            
             var player = User.SearchByName("dio");
             foreach (var itemUser in player)
             {
                 Console.WriteLine(itemUser.UserName + " Victories:" + itemUser.Victories);
             }
             Console.WriteLine($"All matches {User.GameStat()}");

        }
    }
}
