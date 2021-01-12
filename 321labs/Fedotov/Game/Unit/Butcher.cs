using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Butcher : ILife, IMove, IWork
    {
        public bool flagLive { get; set; }
        public int health { get; set; }
        public int speedMove { get; set; }
        public int agilityMove { get; set; }
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
