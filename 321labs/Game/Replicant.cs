using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Replicant : ICanWalk, ICanAttack, ICanProduce<Nanite>
    {
        const int maxNaniteCapacity = 15;
        double x;
        double y;
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
        public double X { get => x; }
        public double Y { get => y; }
        public Player Team { get; set; }
        internal List<Nanite> Nanites { get => nanites; set => nanites = value; }

        public Replicant(double x, double y)
        {
            this.y = y;
            this.x = x;
        }

        public void Attack(IUnit attacked)
        {
            double dist = Distance(attacked.X, attacked.Y);
            if (dist <= this.AttackRange)
            {
                attacked.Hp -= this.Damage - attacked.Armor;
            }
            else
            {
                double k = (dist - this.AttackRange) / dist;
                double attRangeX = this.X + (attacked.X - this.X) * k;
                double attRangeY = this.Y + (attacked.Y - this.Y) * k;
                MoveTo(attRangeX, attRangeY);
                this.Attack(attacked);
            }
        }

        public void MoveTo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(double x, double y)
        {
            int destX = (int)Math.Pow(x - this.x, 2);
            int destY = (int)Math.Pow(y - this.y, 2);
            return Math.Sqrt(destX + destY);
        }

        public void Produce(Nanite unit) //Репликант может проивзодить нанитов, но не больше 15 шт.
        {
            int cost = unit.EnergyCost;
            if (Team.Energy >= cost && Nanites.Count < maxNaniteCapacity)
            {
                unit.Team = this.Team;
                Team.Energy -= unit.EnergyCost;
                unit.Replicator = this;
                Nanites.Add(unit);
            }
            else
            {
                Console.WriteLine("Не хватает енергии или нанитов слишком много");
            }
        }
    }
}
