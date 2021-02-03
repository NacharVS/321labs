﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Game
{
    class MongoCrud
    {
        public static Task Add(IUnit unit)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BsonDocument>("Units");
            return collection.InsertOneAsync(unit.ToBsonDocument());
        }

        public async static Task Replace(IUnit unit, ObjectId id)
        {
            
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<IUnit>("Units");
            await collection.ReplaceOneAsync(new BsonDocument("_id", id), unit, new ReplaceOptions { IsUpsert = true });
        }
    }
}
