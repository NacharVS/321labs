using _321labs.Mironov.Game;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Mironov
{
    class Database
    {

        public static async Task Connect()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game321");
            var collection = database.GetCollection<BsonDocument>("Units");

        }

        public static async Task Add(IUnit unit)
        {

        }

        public static async Task ShowResult(IUnit unit)
        {

        }

    }
}
