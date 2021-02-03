using System;
using System.Threading;
using _321labs.Threads;
using System.Threading.Tasks;
using _321labs.ThreadLocker;
using _321labs.TaskLaba3;
using _321labs.ContinuationTasks;
using _321labs.CancellationTokenEx;
using _321labs.Game;
using _321labs.asyncStart;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;



namespace _321labs
{
    class Program
    {
        static string connectionString;
        static MongoClient client;
        static IMongoDatabase database;
        static IMongoCollection<Unit> mongoCollection;
        static void LoadData()
        {
            connectionString = "mongodb://localhost";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("praktika");
            mongoCollection = database.GetCollection<Unit>("Unit01");
        }
        static async Task UpdateByName(string name,int LVL)
        {
            await mongoCollection.UpdateManyAsync(Builders<Unit>.Filter.Eq(u=>u.Name,name),Builders<Unit>.Update.Set(u=>u.LVL,LVL));
        }
        static async Task LoadUnitInDatabase(Unit unit) 
        {
            await mongoCollection.InsertOneAsync(unit);
        }

        static void Main(string[] args)
          
        {
            LoadData();
            UpdateByName("Коля",20).GetAwaiter().GetResult();
            //LoadUnitInDatabase(new WarUnit("Коля", 1)).GetAwaiter().GetResult();
            //LoadUnitInDatabase(new TankUnit("T-34", 4)).GetAwaiter().GetResult();
            //LoadUnitInDatabase(new WarUnit("Коля", 1)).GetAwaiter().GetResult();
            //LoadUnitInDatabase(new WisdomCastle("Антон", 1, 5)).GetAwaiter().GetResult();
            //LoadUnitInDatabase(new WisdomCastle("Данила-Мастер", 1, 5)).GetAwaiter().GetResult();

            //Laba2.MainLaba2();
            //ThreadLocker.TheadLocker.MainTheadLocker();
            //Console.WriteLine("Leave hope behind all who enters here....");
            //TaskLaba.MainTask();
            //ContinuationTask.MainTask();
            //CancellationTokenEx.CancellationTokenEx.MainCancellationTokenEx();
            //Laba7.MainLaba7();


            //string connectionString = "mongodb://localhost";
            //MongoClient client = new MongoClient(connectionString);
            //IMongoDatabase database = client.GetDatabase("LabaLaba8");
            //var mongoCollection = database.GetCollection<WarUnit>("Unit");
            //mongoCollection.InsertOne(new WarUnit("Коля",1));


        }
    }
}
