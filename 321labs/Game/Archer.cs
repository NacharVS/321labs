using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _321labs.Game
{
    class Archer : Unit, IArcher
    {
        public int Energy { get; set; }
        public int Dexterity { get; set; }
        public Archer(int hp, int defence, int range, int damage, int speed) : base(hp, defence, range, damage, speed)
        {

        }

        public void Hike()
        {
            this.Speed += 40;
        }

        public void UpDamage()
        {
            this.Damage += 100;
        }

        public static async Task SaveDocs()
        {
            string connectionSring = "mongodb://localhost:27017";
            var client = new MongoClient(connectionSring);
            var database = client.GetDatabase("321Shmelev");
            var collection = database.GetCollection<Archer>("archer");
            Archer archer = new Archer(100, 30, 10, 150, 15)
            {
                Energy = 100,
                Dexterity = 100
            };
            await collection.InsertOneAsync(archer);
        }
    }
}
