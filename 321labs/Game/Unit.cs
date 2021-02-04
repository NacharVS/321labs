using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System.Linq;
using System.Threading.Tasks;

namespace _321labs.Game
{
   public class Unit
    {
        public int Armor { get; set; }
        public int Range { get; set; }
        public int Sight { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        int Speed { get; set; }
        public Unit(string name, int level, int hp, int armor, int range, int sight, int speed)
        {
            this.Armor = armor;
            this.Range = range;
            this.Sight = sight;
            this.Speed = speed;
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
        }
        static void Main(string[] args)
        {
            static async Task SaveDocs()
            {
                List<Unit> units = new List<Unit>();
                string connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("gameRanil");
                var collection = database.GetCollection<Unit>("Farmer");
                Farmer workerRanil = new Farmer("Marat", 50, 30, 20, 160, 32, 14)
                {
                    Hp = 100,
                    Level = 20,
                    Range = 10,
                    Name = "Ranil",
                    Sight = 200,
                    Armor = 123,
                    Speed = 22,

                };
                await collection.InsertOneAsync(workerRanil);
            }
            SaveDocs();
            Console.ReadKey();
        }
    }
}
