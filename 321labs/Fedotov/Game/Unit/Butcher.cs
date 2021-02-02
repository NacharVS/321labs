using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Butcher : IUnit, IMove, IWork
    {
        public string NickName { get; set; }
        public Guid id { get; set; }
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int SpeedMove { get; set; }
        public int AgilityMove { get; set; }
        public void StopMove()
        {
            Console.WriteLine("Мясник стоит");
        }

        public void StartMove()
        {
            Console.WriteLine("Мясник идет");
        }

        public void StartWork()
        {
            Console.WriteLine("Начинает резать мясо");
        }

        public void StopWork()
        {
            Console.WriteLine("Перестал резать мясо");
        }
    }
}
