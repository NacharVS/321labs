﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace _321labs.Mironov.Game.Class
{
    class TownHall : IUnit
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int RangeVisible { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public int X {  get; set; }
        public int Y { get; set; }
        public ObjectId id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
