using System;
using System.Threading;
using _321labs.Fedotov.Game;
using _321labs.Fedotov;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Я без понятия правильно это или нет, я не мб это все вообще не правильно");
            //AsyncStart threads = new AsyncStart();
            //threads.Start();
            //Console.ReadLine();


            MongoCRUD db = new MongoCRUD("GameUnit");
            var recs = db.LoadRecords<Archer>("Archer");

            //Archer a = new Archer();

            //db.InsertRecord("Archer", a);
            //Archer a1 = new Archer()
            //{
            //    PositionX = 270,
            //    PositionY = 100,
            //    PositionZ = 40,
            //    SpeedMove = 30,
            //    AgilityMove = 40,
            //    Distance = 100,
            //    Accuracy = 40,
            //    weapon = new Weapon("Pistol", 7, 10, 100, TimeSpan.FromSeconds(3), 800, 15)
            //};
            //db.InsertRecord("Archer", a1);

            //Archer a2 = new Archer()
            //{
            //    PositionX = 100,
            //    PositionY = 300,
            //    PositionZ = 20,
            //    SpeedMove = 40,
            //    AgilityMove = 26,
            //    Distance = 250,
            //    Accuracy = 80,
            //    weapon = new Weapon("Sniper", 5, 6, 96, TimeSpan.FromSeconds(10), 4200, 120)
            //};
            //db.InsertRecord("Archer", a2);

            //Archer a3 = new Archer()
            //{
            //    SpeedMove = 40,
            //    AgilityMove = 26,
            //    Distance = 250,
            //    Accuracy = 80,
            //    weapon = new Weapon("Sniper", 5, 6, 96, TimeSpan.FromSeconds(10), 4200, 120)
            //};
            //db.InsertRecord("Archer", a3);

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.id}: {(rec.FlagLive? "Health " + rec.Health : "Dead")}");
                if (rec.weapon != null)
                {
                    Console.WriteLine($"Weapon {rec.weapon.Name}, Bullet {rec.weapon.BulletInTheHolder}/{rec.weapon.CountHolder}, ReloadTime {rec.weapon.ReloadTime}," +
                                  $" Damage {rec.weapon.Damage}, Durability {rec.weapon.Durability}");
                }
            }

        }
    }
}
