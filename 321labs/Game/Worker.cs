using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Worker : IUnit, ICanProduce<IBuilding>, ICanWalk
    {
        int x;
        int y;
        int hp = 60;
        public string Name { get => "Рабочий"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 0; }
        public int EnergyCost { get => 50; }
        public Player Team { get; set; }
        public int X { get; }
        public int Y { get; }
        public int MovementSpeed { get => 3; }

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
        public void Produce(IBuilding building)
        {
            int cost = building.EnergyCost;
            if (Team.Energy >= cost)
            {
                building.Team = this.Team;
                Team.Energy -= building.EnergyCost;
            }
            else
            {
                Console.WriteLine("Не хватает енергии");
            }
        }
    }
}
