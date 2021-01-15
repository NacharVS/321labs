using _321labs.Kamalov.Game;
using System;
using System.Threading;
namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            Sniper sniper = new Sniper(100, 50, "Rq", 45);
            Sniper sniper1 = new Sniper(100, 5, "fd", 34);
            sniper.Shoot(sniper1);
        }
    }
}