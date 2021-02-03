using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _321labs.Sudakov
{
    class Hero : IUnit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public int Health { get; set; }
        [BsonIgnoreIfDefault]
        public int MoveSpeed { get; set; }
        [BsonIgnoreIfDefault]
        public int Armor { get; set; }
        [BsonIgnoreIfDefault]
        public int Range { get; set; }
        [BsonIgnoreIfDefault]
        public int Damage { get; set; }

        public void DoDamage()
        {
            Console.WriteLine("Я бью!");
        }

        public void Move()
        {
            Console.WriteLine("Бродим бродим");
        }
    }
}
