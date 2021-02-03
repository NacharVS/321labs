using System;
using System.Threading;
using System.Collections.Generic;
using _321labs.Sudakov;
using _321labs.Game;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Hero hero = new Hero
            {
                Name = "Sasha",
                Health = 100,
                MoveSpeed = 10,
                Armor = 50,
                Range = 30,
                Damage = 50
            };
            Hero hero1 = new Hero
            {
                Name = "21333",
                Health = 100,
                MoveSpeed = 500,
                Armor = 50,
                Range = 30,
                Damage = 50
            };
            

            MongoCrud.Replace(hero1).GetAwaiter().GetResult();
            
        }
    }
}
