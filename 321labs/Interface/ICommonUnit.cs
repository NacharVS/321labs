using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    interface ICommonUnit
    {
        [BsonId]
        [BsonIgnoreIfDefault]

        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        string TypeUnit { get; }
        [BsonIgnoreIfDefault]
        double Cost { get; set; }
        [BsonIgnoreIfDefault]
        string Name { get; set; }
        [BsonIgnoreIfDefault]
        int Hp { get; set; }
        [BsonIgnoreIfDefault]
        int Strenght { get; set; }
        [BsonIgnoreIfDefault]
        int Armor { get; set; }
        [BsonIgnoreIfDefault]
        double Evasion { get; set; }
        void Attack();
        void Display();
    }
}
