using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace _321labs.Mironov.Game
{
    class Archer : IUnit, IMoveable, IRangeAttacker
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }
        [BsonIgnoreIfDefault]
        public int Speed { get; set; }
        [BsonIgnoreIfDefault]
        public int Health { get; set; }
        [BsonIgnoreIfDefault]
        public int Armor { get; set; }
        [BsonIgnoreIfDefault]
        public int RangeVisible { get; set; }
        [BsonIgnoreIfDefault]
        public int Cost { get; set; }
        [BsonIgnoreIfDefault]
        public string Description { get; set; }
        [BsonIgnoreIfDefault]
        public int X { get; set; }
        [BsonIgnoreIfDefault]
        public int Y { get; set; }
        [BsonIgnoreIfDefault]
        public int Range { get; set; }
        [BsonIgnoreIfDefault]
        public int Damage { get; set; }

        public Archer(int range, int speed, int health, int armor, int rangeVisible, int cost, string description,  int damage, int x, int y)
        {
            Range = range;
            Speed = speed;
            Health = health;
            Armor = armor;
            RangeVisible = rangeVisible;
            Cost = cost;
            Description = description;
            X = x;
            Y = y;
            Damage = damage;
        }

        public void Move(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void MoveStop()
        {
            throw new NotImplementedException();
        }

        public void RangedAttack()
        {
            throw new NotImplementedException();
        }
    }
}
