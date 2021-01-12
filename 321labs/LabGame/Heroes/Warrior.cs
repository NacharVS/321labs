using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using _321labs.LabGame.Base;

namespace _321labs.LabGame.Heroes
{
    class Warrior : Unit, IMoveable
    {
        public override Vector2 UnitPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float HealthPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Defense { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Attack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Range { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CanMoveToPoint(Vector2 position)
        {
            throw new NotImplementedException();
        }

        public override bool InRange(Vector2 position)
        {
            //Дистанция до точка
            double dist = Math.Sqrt(Math.Pow((position.X - UnitPosition.X), 2) + Math.Pow((position.Y - UnitPosition.Y), 2));

           //Находится ли точка в досягаемости нашего юнита?
            if (dist < Range)
                return true;
            else 
                return false;
        }

        void IMoveable.MoveToPoint(Vector2 position)
        {
            Vector2.Lerp(UnitPosition,position,0.5f);
        }
    }
}
