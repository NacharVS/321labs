﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Kamalov.Game
{
    class Assasin : Hero, IShoot, IRun, IStop
    {
        public Assasin(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
            Console.WriteLine($"Создан персонаж класса Sniper. Его имя: {Name}");
        }

        public void Run(int x, int y)
        {
            Console.WriteLine($"{this.Name} перместился по координатам x:{x} x:{y}");
        }

        public void Shoot(Hero hero)
        {
            double sum = this.Damage / 2;
            if (this.Damage > sum)
            {
                Console.WriteLine($"{this.Name} выстрелил незаметно из духовой трубы");
                this.Damage = this.Damage / 2;
                this.Health = this.Health - this.Damage;
                Console.WriteLine($"Врагу было нанесено: {this.Damage} урона. У врага осталось: {this.Health} HP");
            }

            else
            {
                Console.WriteLine("Он и без яда, скоро умрет...");
            }
        }

        public void Stop(Hero hero)
        {
            Speed = 0;
            Console.WriteLine($"{this.Name} - остановился и слился с фауной.");
        }

        public static async Task SaveDocs()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("DataGame");
            var collection = database.GetCollection<Assasin>("Assasin");
            Assasin workerRanil = new Assasin(100,65,"Robert",43);
            await collection.InsertOneAsync(workerRanil);
        }
        
    }
}
