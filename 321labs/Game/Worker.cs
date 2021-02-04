using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Worker : ICanProduce<IBuilding>, ICanWalk
    {
        double x;
        double y;
        int hp = 60;

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string Name { get => "Рабочий"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 0; }
        public int EnergyCost { get => 50; }
        public Player Team { get; set; }
        public double X { get => x; }
        public double Y { get => y; }
        public int MovementSpeed { get => 3; }

        public Worker(double x, double y)
        {
            this.y = y;
            this.x = x;
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
