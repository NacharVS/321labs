using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace _321labs.Game
{
    class mongocrud
    {
        public static Task Add(IUnit unit)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game123");
            var collection = database.GetCollection<BsonDocument>("Units");
            return collection.InsertOneAsync(unit.ToBsonDocument());
        }
        public static Task Replace(Hero hero)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game123");
            var collection = database.GetCollection<IUnit>("Units");
            return collection.ReplaceOneAsync(x => x.Name == "sas",hero, new ReplaceOptions { IsUpsert = true });
        }
        public async Task UpdateDataBySpeed(string dataCollection, int speed)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game123");
            var collection = database.GetCollection<Hero>(dataCollection);
            await collection.UpdateManyAsync(w => w.MoveSpeed == 12, new BsonDocument("$inc", new BsonDocument("Speed", speed)));
        }

    }
}
