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
            //GameCreationStart g1 = new GameCreationStart("domiko_0", DateTime.Today, 20, 14, 900);
            //GameCreationStart g2 = new GameCreationStart("MEQUE", DateTime.Today, 30, 25, 1600);
            //GameCreationStart g3 = new GameCreationStart("CHERT", DateTime.Today, 10, 3, 200);
            //GameCreationStart g4 = new GameCreationStart("G5", DateTime.Today, 17, 14, 950);
            //GameCreationStart g5 = new GameCreationStart("Y", DateTime.Today, 50, 25, 1000);
            //GameCreationStart g6 = new GameCreationStart("Vaskin", DateTime.Today, 15, 10, 900);

            //Console.WriteLine($"GameStat: {GameCreationStart.GameStat()} ");
            //GameCreationStart player = GameCreationStart.SearchByName("CHERT");
            //Console.WriteLine(player.UserName + " Victories:" + player.Victories);
            AsyncStart threads = new AsyncStart();
            threads.Start();
            Console.ReadLine();
        }
    }
}
