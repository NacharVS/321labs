using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System.Linq;
using System.Threading.Tasks;


namespace _321labs.Garifullin.Game
{
    class RanilAllWorker : Unit, IWorker
    {
        public int WorkPower { get; set; }
        public RanilAllWorker(int phealth, int pexperience, int pposition, string pname, int pworkPower) : base(phealth, pexperience, pposition, pname)
        {
            this.WorkPower = pworkPower;
            Console.WriteLine("Гений создан");
        }
        public void Improve(Building building)
        {
            int temp = building.Health;
            int alpha = building.Defence;
            if (building is Base)
            {
                building.Health += WorkPower * 2;
                building.Defence += WorkPower * 2;
            }
            else
            {
                building.Health += WorkPower;
                building.Defence += WorkPower;
            }
            Console.WriteLine($"Здоровье и защита {building.Name} улучшены с {temp} и {alpha} на {building.Health} и {building.Defence}");
        }

        private static async Task SaveDocs()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<RanilAllWorker>("Worker");
            RanilAllWorker workerRanil = new RanilAllWorker(50, 30, 20, "Marat", 160)
            {
                Health = 100,
                Experience = 20,
                Position = 10,
                Name = "Ranil",
                WorkPower = 200
            };
            await collection.InsertOneAsync(workerRanil);
        }

        static void Main(string[] args)
        {
            RanilAllWorker.SaveDocs();
            Console.ReadKey();
        }
    }

}
