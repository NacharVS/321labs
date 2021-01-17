using System;
using System.Numerics;

namespace _321labs.LabGame.Base
{
    public interface IHealer
    {

        public int HealZoneSize { get; set; }
        public int HealStr { get; set; }
        public void HealToPoint(Vector2 position);
        public bool InHealZone(Vector2 healPosition, Vector2 position);
    }
}
