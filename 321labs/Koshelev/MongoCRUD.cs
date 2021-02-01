using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

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
        public void CreatNewDataInCollection<T>(string dataCollection, T TObject)
        {
            var collection = Database.GetCollection<T>(dataCollection);
            collection.InsertOne(TObject);
        }

    }
}
