using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace _321labs.Mironov.Game.Class
{
    class WatchTower : IUnit, IRangeAttacker
    {
        public int Range { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObjectId id { get; set; }
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RangeVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void RangedAttack()
        {
            throw new NotImplementedException();
        }
    }
}
