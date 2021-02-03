using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Bson;

namespace _321labs.Game
{
    [BsonIgnoreExtraElements]
    abstract class Unit
    {     
        [BsonId]
        abstract public ObjectId Id { get; set; }
        
        protected Unit(int LVL, string Name)
        {
            this.LVL = LVL;
            this.Name = Name;
        }
        
        [BsonIgnoreIfDefault]
        abstract protected int PowerCoef { get; }
        abstract protected int AggilityCoef { get; }
        abstract protected int DefenseCoef { get; }
        abstract protected int MaxHealthCoef { get; }

        abstract public int LVL { get; set; }
        abstract public int Exp { get; set; }
        abstract public string Name { get; set; }
        abstract public int MaxHealth { get; }
        abstract public int Health{get; set;}
        abstract public int Power { get;  }
        abstract public int Aggility { get;  }
        abstract public int Defense { get;  }
        abstract public void GetDamage(int Damage);
    }
}
