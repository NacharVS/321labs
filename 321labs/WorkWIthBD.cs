using _321labs.Game;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class WorkWIthBD
    {
        public static async Task SaveDocs()
        {
            string connectionSring = "mongodb://localhost:27017";
            var client = new MongoClient(connectionSring);
            var database = client.GetDatabase("321Shmelev");
            var collection = database.GetCollection<Archer>("archer");
            Archer archer = new Archer(100, 30, 10, 150, 15)
            {
                Name = "Keks",
                Energy = 100,
                Dexterity = 100
            };
            await collection.InsertOneAsync(archer);
        }

        public static async Task Replace()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("321Shmelev");
            var collection = database.GetCollection<Archer>("archer");
            await collection.ReplaceOneAsync(new BsonDocument("Name", "Keks"), new Archer(1, 1, 1, 1, 1)
            {
                Name = "Ilya",
                Energy = 150,
                Dexterity = 40
            });
        }

        public static async Task Update()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("321Shmelev");
            var collection = database.GetCollection<Archer>("archer");
            await collection.UpdateOneAsync(new BsonDocument("Name", "Ilya"), new BsonDocument("$set", new BsonDocument("Energy", 2000)));
        }

        public static async Task DeleteOneByName(string name)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("321Shmelev");
            var collection = database.GetCollection<Archer>("archer");
            await collection.DeleteOneAsync(str => str.Name == name);
        }
        public static async Task DeleteManyByName(string name)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("321Shmelev");
            var collection = database.GetCollection<Archer>("archer");
            await collection.DeleteManyAsync(str => str.Name == name);
        }
    }
}
