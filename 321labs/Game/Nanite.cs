using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Game
{
    class Nanite : ICanWalk, ICanAttack
    {
        double x;
        double y;
        int hp = 30;

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public string Name { get => "Нанит"; }
        [BsonIgnoreIfDefault]
        public int Hp { get => hp; set => hp = value; }
        [BsonIgnoreIfDefault]
        public int Armor { get => 0; }
        [BsonIgnoreIfDefault]
        public int MovementSpeed { get => 5; }
        [BsonIgnoreIfDefault]
        public int Damage { get => 5; }
        [BsonIgnoreIfDefault]
        public double TimeBetweenAttacks { get => 1; }
        [BsonIgnoreIfDefault]
        public int EnergyCost { get => 5; }
        [BsonIgnoreIfDefault]
        public int AttackRange { get => 1; }
        [BsonIgnoreIfDefault]
        public double X { get => x; }
        public double Y { get => y; }
        public Player Team { get; set; }
        [BsonIgnoreIfDefault]
        public Replicant Replicator { get; set; }
        

        public Nanite(double x, double y)
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
    }
}
