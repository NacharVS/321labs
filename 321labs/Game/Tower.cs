using System;
using System.Collections.Generic;
using System.Text;
using _321labs.intaface;
using _321labs.Game.inteface;
namespace _321labs.inteface
{
    class Tower: Iattack , Iunit
    {
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int Damage { get; set; }
        public int armor { get; set; }
        
        public void TakeDamage()
        {
            Console.WriteLine("Выстрел");
        }
    }
}
