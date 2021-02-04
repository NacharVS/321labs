using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Gunner : ICanWalk, ICanAttack
    {
        double x;
        double y;
        int hp = 80;
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string Name { get => "Стрелок";  }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 1;  }
        public int MovementSpeed { get => 3;  }
        public int Damage { get => 10;  }
        public double TimeBetweenAttacks { get => 0.5;  }
        public int EnergyCost { get => 60; }
        public int AttackRange { get => 5;  }
        public double X { get => x; }
        public double Y { get => y; }
        public Player Team { get; set; }

        public Gunner(double x, double y)
        {
            this.y = y;
            this.x = x;
        }


        public void Attack(IUnit attacked) //attacked = атакуемый (тот кого будет атаковать)
        {
            //Если у юнита атака не достаёт до цели то он пойдёт к точке из которой он сможет атаковать 
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
