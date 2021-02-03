using _321labs.Mironov.Game;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Mironov
{
    class MongoCRUD
    {



        public static Task Add(IUnit unit)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game321");
            var collection = database.GetCollection<BsonDocument>("Units");
            return collection.InsertOneAsync(unit.ToBsonDocument());
        }
        public static Task Replace(IUnit unit, int value, string parametr)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game321");
            var collection = database.GetCollection<IUnit>("Units");
            return collection.ReplaceOneAsync(new BsonDocument(parametr, value), unit, new ReplaceOptions { IsUpsert = true });
        }

        public static async Task Update(string parametr,int value )
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game321");
            var collection = database.GetCollection<IUnit>("Units");
            var result = await collection.UpdateOneAsync(
                 new BsonDocument(parametr, value),
                 new BsonDocument("$set", new BsonDocument("Health", 3)));
            Console.WriteLine("найдено по соответствию: {0}; обновлено: {1}",
                result.MatchedCount, result.ModifiedCount);
        }



    }
}
