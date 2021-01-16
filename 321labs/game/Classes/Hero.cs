using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Hero : Unit, IWalking
    {
        int speed;

        public int Speed { get => speed; set => speed = value; }

        public Hero(int hp, int armor, int strenght) : base(hp, armor, strenght)
        {

        }

        public void Walking(int x, int y)
        {
            Console.Write(this.Title + "перешёл с позиции:" + this.X + " : " + this.Y);
            this.X = x;
            this.Y = y;
            Console.Write("на" + this.X + " : " + this.Y);
        }
    }
}
