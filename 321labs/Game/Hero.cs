
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _321labs.Game
{
    class Hero : IHero
    {
     
        [BsonId]
        [BsonIgnoreIfDefault]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public int Health { get; set; }
        [BsonIgnoreIfDefault]
        public int Vision { get; set; }
        [BsonIgnoreIfDefault]
        public int NightVision { get; set; }
        [BsonIgnoreIfDefault]
        public int Armor { get; set; }
        [BsonIgnoreIfDefault]
        public int Damage { get; set; }
        [BsonIgnoreIfDefault]
        public int AttackRange { get; set; }
        [BsonIgnoreIfDefault]

        public int MoveSpeed { get; set; }


        public void Move()
        {
            Console.WriteLine("Челик ходит");
        }

        public void Shoot()
        {
            Console.WriteLine("Челик стреляет");
        }
        public Hero()
        {

        }
        public Hero(string Name, int Health, int Vision, int NightVision, int Armor, int Damage, int AttackRange, int MoveSpeed)
        {
            this.Name = Name;
            this.Health = Health;
            this.Vision = Vision;
            this.Armor = Armor;
            this.Damage = Damage;
            this.AttackRange = AttackRange;
            this.MoveSpeed = MoveSpeed;
        }
    }
}
