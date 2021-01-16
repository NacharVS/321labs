using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Nanite : ICanWalk, ICanAttack
    {
        int x;
        int y;
        int hp = 30;
        public string Name { get => "Нанит"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 0; }
        public int MovementSpeed { get => 5; }
        public int Damage { get => 5; }
        public double TimeBetweenAttacks { get => 1; }
        public int EnergyCost { get => 5; }
        public int AttackRange { get => 1; }
        public int X { get; }
        public int Y { get; }
        public Player Team { get; set; }
        public Replicant Replicator { get; set; }

        public void Attack(IUnit attacked) 
        {
            if (Distance(attacked.X, attacked.Y) <= this.AttackRange)
            {
                attacked.Hp -= this.Damage - attacked.Armor;
            }
            else
            {
                MoveTo(attacked.X, attacked.Y);
            }
        }

        public double MoveTo(int x, int y)
        {
            double timeToTravel = Distance(x, y) / MovementSpeed;
            return timeToTravel;
        }
        public double Distance(int x, int y)
        {
            int destX = (int)Math.Pow(x - this.x, 2);
            int destY = (int)Math.Pow(y - this.y, 2);
            return Math.Sqrt(destX + destY);
        }
    }
}
