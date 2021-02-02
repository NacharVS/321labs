using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace _321labs.Fedotov.Game
{
    class Archer : IUnit, IMove, IShooting
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Guid id { get; set; }

        [BsonIgnoreIfDefault] 
        public string NickName { get; set; } = "Player";
        [BsonIgnoreIfDefault]
        public bool FlagLive { get; set; } = true;
        [BsonIgnoreIfDefault]
        public int Health { get; set; } = 100;
        [BsonIgnoreIfDefault]
        public int PositionX { get; set; }
        [BsonIgnoreIfDefault]
        public int PositionY { get; set; }
        [BsonIgnoreIfDefault]
        public int PositionZ { get; set; }
        [BsonIgnoreIfDefault]
        public int SpeedMove { get; set; }
        [BsonIgnoreIfDefault]
        public int AgilityMove { get; set; }
        [BsonIgnoreIfDefault]
        public int Distance { get; set; }
        [BsonIgnoreIfDefault]
        public int Accuracy { get; set; }
        [BsonIgnoreIfDefault]
        public Weapon weapon { get; set; }

        public void StopMove()
        {
            Console.WriteLine("Лучник стоит");
        }

        public void StartMove()
        {
            Console.WriteLine("Лучник идет");
        }

        public void TakeDamage()
        {
            Console.WriteLine("Выстрел из лука");
        }

    }
}
