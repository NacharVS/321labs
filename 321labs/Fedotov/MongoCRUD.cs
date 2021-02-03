using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using _321labs.Fedotov.Game;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _321labs.Fedotov
{
    class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }

        public T LoadRecordByName<T>(string table, string name)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("NickName", name);
            return collection.Find(filter).First();
        }

        public async Task ReplaceRecordById<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            await collection.ReplaceOneAsync(
                new BsonDocument("_id", id),
                record,
                new ReplaceOptions { IsUpsert = true });
        }
        public async Task ReplaceRecordByName<T>(string table, string name, T record )
        {
            var collection = db.GetCollection<T>(table);

            await collection.ReplaceOneAsync(
                new BsonDocument("NickName", name),
                record,
                new ReplaceOptions { IsUpsert = true });
        }

        public async Task UpdateRecordByHealth<T>(string table, string name, int record)
        {
            var collection = db.GetCollection<T>(table);

            await collection.UpdateManyAsync(
                new BsonDocument("NickName", name),
                new BsonDocument("$inc", new BsonDocument("Health", record)),
                new UpdateOptions() {IsUpsert = true});
        }

        public void DeleteRecors<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
