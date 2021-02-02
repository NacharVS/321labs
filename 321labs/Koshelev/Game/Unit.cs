using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _321labs.Game
{
    class Unit : IUnit, IAttack
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Guid Id { get; set; }
        [BsonIgnoreIfDefault]
        public int Helth { get; set; }
        [BsonIgnoreIfDefault]
        public int Damage { get; set; }
        [BsonIgnoreIfDefault]
        public int Speed { get; set; }
        [BsonIgnoreIfDefault]
        public int Range { get; set; }
        [BsonIgnoreIfDefault]
        public int Exp { get; set; }
        [BsonIgnoreIfDefault]
        public double PositionX { get; set; }
        [BsonIgnoreIfDefault]
        public double PositionY { get; set; }

        public void Attack(Unit enemy)
        {
            Console.WriteLine("Attack hahaha");
        }
    }
}
