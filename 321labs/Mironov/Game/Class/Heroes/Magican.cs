﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game.Class.Heroes
{
    class Magican : IUnit, IMagic,IMoveable
    {
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RangeVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Mana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObjectId id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MagicAttack()
        {
            throw new NotImplementedException();
        }

        public void Move(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void MoveStop()
        {
            throw new NotImplementedException();
        }
    }
}
