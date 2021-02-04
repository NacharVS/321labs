using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class War_unit : IUnit
    {
        [BsonId]
        [BsonIgnoreIfDefault]

        public ObjectId Id { get; set; }
        double cost;
        string name;
        int hp;
        int strenght;
        double evasion;
        int armor;
        public string TypeUnit { get; } = "Воин";
        public War_unit(double cost, string name, int hp, int strenght, int armor, double evasion)
        {
            this.Cost = cost;
            this.Name = name;
            this.Hp = hp;
            this.Strenght = strenght;
            this.Armor = armor;
            this.Evasion = evasion;

        }

        public double Cost { get => cost; set => cost = value; }
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Strenght { get => strenght; set => strenght = value; }
        public double Evasion { get => evasion; set => evasion = value; }
        public int Armor { get => armor; set => armor = value; }

        
        public void Attack()
        {
            Console.WriteLine("Warrior damage {0}", (Strenght + Armor) * 2);
        }
        public void EXAttac()
        {
            Strenght = Strenght * 2;
            Console.WriteLine("Strenght increase {0}", Strenght);
        }
        public void Display()
        {
            Console.WriteLine("Type unit: {0}", TypeUnit);
            Console.WriteLine("Cost unit: {0}", Cost);
            Console.WriteLine("Name unit: {0}", Name);
            Console.WriteLine("HP unit: {0}", Hp);
            Console.WriteLine("Strenght unit: {0}", Strenght);
            Console.WriteLine("Armor unit: {0}", Armor);
            Console.WriteLine("Evasion unit: {0}", Evasion);
        }
    }
}
