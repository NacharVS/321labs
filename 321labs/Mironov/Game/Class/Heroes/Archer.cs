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
        public ObjectId id
        {
            get ;
            set ;
        }

        public int Range { get ; set ; }
        public int Speed { get ; set; }
        public int Health { get ; set ; }
        public int Armor { get; set; }
        public int RangeVisible { get; set; }
        public int Cost { get; set; }
        public string Description  {get; set; }
        [BsonIgnoreIfDefault]
        public int X { get; set; }
        [BsonIgnoreIfDefault]
        public int Y { get; set; }



        public Archer(int range, int speed, int health, int armor, int rangeVisible, int cost, string description, int x, int y)
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
