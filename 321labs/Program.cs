using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _321labs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior 
            { Helth = 100, 
              Damage = 37,
              Range = 10,
              Speed = 46
            };

            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("test");


        }
      
    }
}
