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
            Sniper sniper = new Sniper(100, 50, "Alex", 45);
            Sniper sniper1 = new Sniper(100, 5, "Fedor", 34);
            FireTower fireTower = new FireTower(100, 0 ,"fire", 34);
            fireTower.Shoot(sniper1);
        }
    }
}