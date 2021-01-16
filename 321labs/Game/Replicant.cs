using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Replicant : ICanWalk, ICanAttack, ICanProduce<Nanite>
    {
        const int maxNaniteCapacity = 15;
        int x;
        int y;
        int hp = 150;
        List<Nanite> nanites = new List<Nanite>(maxNaniteCapacity);
        public string Name { get => "Репликант"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 2; }
        public int MovementSpeed { get => 2; }
        public int Damage { get => 20; }
        public double TimeBetweenAttacks { get => 1.3; }
        public int EnergyCost { get => 120; }
        public int AttackRange { get => 4; }
        public int X { get; }
        public int Y { get; }
        public Player Team { get; set; }

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

        public void Produce(Nanite unit) //Репликант может проивзодить нанитов, но не больше 15 шт.
        {
            int cost = unit.EnergyCost;
            if (Team.Energy >= cost && nanites.Count < maxNaniteCapacity)
            {
                unit.Team = this.Team;
                Team.Energy -= unit.EnergyCost;
                unit.Replicator = this;
                nanites.Add(unit);
            }
            else
            {
                Console.WriteLine("Не хватает енергии или нанитов слишком много");
            }
        }
    }
}
