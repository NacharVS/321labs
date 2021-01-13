using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Butcher : IUnit, IMove, IWork
    {
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int SpeedMove { get; set; }
        public int AgilityMove { get; set; }
        public void StopMove()
        {
            Console.WriteLine("Стоит");
        }

        public void StartMove()
        {
            Console.WriteLine("Идет");
        }

        public void StartWork()
        {
            Console.WriteLine("Начинает резать МЯСО");
        }

        public void StopWork()
        {
            Console.WriteLine("Перестал резать МЯСО");
        }
    }
}
