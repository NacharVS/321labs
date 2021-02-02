using _321labs.Game;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Koshelev
{
    class MongoCRUD
    {

        public string NameDatabase { get; set; }
        IMongoDatabase Database { get; set; }

        public MongoCRUD(string nameDatabase)
        {
            NameDatabase = nameDatabase;
        }

        public void ConnectionMongoDatabase()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
             Database = client.GetDatabase(NameDatabase);
        }
        public async Task CreatNewDataInCollection<T>(string dataCollection, T TObject)
        {
            var collection = Database.GetCollection<T>(dataCollection);
            await collection.InsertOneAsync(TObject);
        }


        public async Task ReplaceData(string dataCollection, Warrior warrior)
        {
            var collection = Database.GetCollection<Warrior>(dataCollection);
            await collection.ReplaceOneAsync(war => war.Damage == 27, warrior, new ReplaceOptions { IsUpsert = true });
        }
        public async Task UpdateData(string dataCollection, Warrior warrior)
        {
            var collection = Database.GetCollection<Warrior>(dataCollection);
            await collection.UpdateManyAsync(w => w.Speed == 12, new UpdateDefi)
        }

    }
}
