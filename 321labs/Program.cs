using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;
using MongoDB.Bson;

namespace _321labs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior
            {
                Helth = 100,
                Damage = 40,
                Range = 30,
                Speed = 12
            };
            MongoCRUD mongoCRUD = new MongoCRUD("OtkritiyRot");
            mongoCRUD.ConnectionMongoDatabase();
            mongoCRUD.CreatNewDataInCollection("Chelust", warrior).Wait();
            mongoCRUD.ReplaceData("Chelust", new Warrior()
            {
                Helth = 90,
                Damage = 60,
                Range = 10,
                Speed = 80,
            }).Wait();
            mongoCRUD.UpdateDataBySpeed("Chelust", 10).Wait();


        }
      
    }
}
