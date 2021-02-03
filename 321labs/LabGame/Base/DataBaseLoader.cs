using System;
using System.Collections.Generic;
using System.Text;
using MongoDB;
using MongoDB.Driver;

namespace _321labs.LabGame.Base
{
    class DataBaseLoader
    {
        public static string DataBaseString { get; set; } = "mongodb://localhost";
        public MongoClient Client { get; set; } = new MongoClient(DataBaseString);
        


        async void LoadUnits<T>(string DBName,string CollName,IEnumerable<T> LoadingCollection) where T:Unit
        {
                var db = Client.GetDatabase(DBName);
                var coll = db.GetCollection<T>(CollName);
                await coll.InsertManyAsync(LoadingCollection);
        }

        async void LoadAllUnits(string DBName, string CollName)
        {
            var db = Client.GetDatabase(DBName);
            var coll = db.GetCollection<Unit>(CollName);
            await coll.InsertManyAsync(Unit.Units);
        }

        async void ReplaceUnit<T>(string DBName, string CollName,FilterDefinition<T> filter,Unit NewUnit) where T:Unit
        {
            var db = Client.GetDatabase(DBName);
            var coll = db.GetCollection<Unit>(CollName);
            await coll.ReplaceOneAsync(u=>u.Name == NewUnit.Name,NewUnit);
        }
    }
}
