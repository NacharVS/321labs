using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Mongo
    {
        public static Task Add(ICommonUnit unit)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BsonDocument>("Units");
            return collection.InsertOneAsync(unit.ToBsonDocument());
        }

        public static Task Replace(ICommonUnit unit)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<ICommonUnit>("Units");
            return collection.ReplaceOneAsync(new BsonDocument("Cost",200), unit, new ReplaceOptions { IsUpsert = true });
        }
    }
}
